# Global Data Context

![img](https://profitbasedocs.blob.core.windows.net/images/Dcont.png)

<br/>

The Global Data Context is configured once pr Solution, and specifies the resources and bindings used to determine the transaction set to process when the star schema configuration of Data Stores cannot provide this information, and / or when Data Context Scopes cannot be fully configured in Workbooks. The Global Data Context is defined by **Slicer Repositories**, **Data Context Variables** and **Data Context Subjects**.

<br/>

## Slicer Repositories

Slicer Repositories are table resources (Dimensions, Facts, Settings and Data Stores) that can be used to determine the transaction set to process when a data source (Data Store or View) does not have a star schema that the Data Context can be derived from. Once a table resources is registered in the Global Data Context, it can be applied in **Slicer Repository Bindings** for  **Data Context Subjects**.


**Properties:**

``Repository``  
>The Solution Object (Setting, Data Store, Fact or Dimension) used for filtering the set of transactions to process.

``Name``  
>The name of the Data Context Resource. The name is used for referencing the resource in **Slicer Repository Bindings**.


<br/>

## Data Context Variables

Data Context Variables are declarations of resources that can be referenced in **Value Bindings**  when arbitrary values should be used to determine the transaction set to process.

Values are assigned to Data Context Variabels listed in the **Data Context Scope** definition of Data Flows, by mapping **Workbook variables**  to the Data Context Variables.

**Properties:**

``Name``  
>The name of the resource. The name is used for referencing the resource in **Value Bindings**. 

<br/>

## Data Context Subjects

Data Context Subjects are data sources and targets which are sliced by the Data Context during processing. Data Context Subjects can be Data Stores or Views.  
If the star schema configuration of a Data Store provides sufficient information to determine the transaction set during read and write operations, the Data Store does not need to be enlisted in the Global Data Context. 

Since Views does not have a star schema configuration, any View being part of a contextual data processing must be enlisted in the Global Data Context.  

**Properties:**

``Subject``  
>The Solution Object (Data Store or View) to have its transaction set managed by the Data Context during processing.

``Repository Bindings``  
>A collection of **Slicer Repository Bindings**.

``Value Bindings``  
>A collection of **Value Bindings**.


<br/>

* **Slicer Repository Binding**

    Slicer Repository Bindings are used if a Data Context Subject does not have a star schema configuration (such as Views) or if the table resources used for filtering the transaction set during processing does not exist in the star schema configuration.

    Slicer Repository Bindings supplements the star schema configuration of Data Stores by providing a connection between Data Store columns and a columns in a **Slicer Repository.**

    **Properties:** 

    ``Target Column``  
    >The name of the column in the Data Context Subject table (Data Store or View), used for filtering the transaction set read or written to during processing.  

    ``Slicer Repository``  
    >The **Slicer Repository** used for filtering transaction set. 

    ``Slicer Repository Column``  
    >The name of the column in the Slicer Repository used for matching the values in the Data Context Subject Target Column.


<br/>

* **Value Binding**

    Value Bindings defines connections between Data Context Variables and a Data Context Subject columns. If a value has been assigned to a variable through the **Data Context Scope**, the value is used for determining the transaction set being processed. The difference between using Slicer Repository Bindings and Values Bindings for filtering, is that when using Slicer Repositories, the filtering is done by joining the Subject Column on the Slicer Column and applying a WHERE clause on the Slicer Column(s), while using Value Bindings, the WHERE clause is applied directly to the Subject Column. Also, Value Bindings allows using hard coded filtering values.

    **Properties:**

    ``Target Column``  
    >The name of the column in the Data Context Subject table that the filter should be applied to. If a value has been assigned to the variable, the the value will be used for determining the transaction set to process.

    ``Variable``  
    >The **Data Context Variabel** used holding the value used for filtering. 


<br/>

## Scripting the Global Data Context

When creating a template that requires a Global Data Context configuration, you need to include a script to create the GDC at the end of the template deployment process. To do this, you need to create a Data Flow that executes when the template is deployed, an in that Data Flow, add a task that calls the *Profitbase.Invision.Cmd.ExecuteScript* function. The easiest way of doing this is to add it from the **Data Flow Item Templates toolbox** -> **Command Tasks** -> **Execute Command Script**. In the GDC screen, generate the script and copy it into the Command Script text input field of the Execute Command Script Task in the Data Flow Item.