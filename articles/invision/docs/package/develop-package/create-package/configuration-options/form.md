# Form

While 'Package Properties' offer a simple way to define static settings, they can be limiting when more dynamic, flexible, or user-specific configuration options are needed.
Using a **[Form](./../../../../../docs/forms/formschemas.md)** will give full control over the settings and functions required for deployed versions. 

A form allows for 
- Custom UI for configuration: You can design tailored interfaces for setting up Package behavior.
- Complex validation and logic: Use the Form API to enforce rules, dependencies, and dynamic defaults.
- Improved user experience: Process owners and end-users interact with intuitive forms rather than raw property lists.
- Version-specific settings: Forms can be tied to specific deployment versions, enabling granular control.

Example use case:
Instead of defining a static Hypotesia.StartDate property, a Form can be created with:
- A date picker for start and end dates
- A dropdown for selecting planning modes
- Conditional fields that appear based on user input

When using a **[Form](./../../../../../docs/forms/formschemas.md)** to define the configurations, there are important steps that you need to do:

&nbsp;&nbsp;&nbsp;&nbsp;- [Design: Set fixed height](#design)  
&nbsp;&nbsp;&nbsp;&nbsp;- [Data source: Use synonym or known source](#data-source)    
&nbsp;&nbsp;&nbsp;&nbsp;- [Validation: Implement function](#validation)  
&nbsp;&nbsp;&nbsp;&nbsp;- [Variables: ProcessId and VersionId](#variables)    

<br/>

### Design
Create a **[Form](./../../../../../docs/forms/formschemas.md)** residing as a sub object under the package, and then attach it to the Form-property in the 'Configuration options' section, when you have selected 'Form' as the option type.

![pic](https://profitbasedocs.blob.core.windows.net/images/package-configuration-set-form.png)


**Set height**<br/>
You must set the height of the UI grid. The form will be displayed with auto-height, so you must specify the UI Grid height to avoid the design to collapse.

> [!TIP]
> **Example of styling, using the Layouts-node in the form**
> <br/>Setting Rows="[height]px" will give the layout one row with the specific height.
> ```xml
> <Layouts>
>   <Grid Name="grid" Rows="300px" Columns="auto" />
> </Layouts>
> ```
>
> **Example of applying the style to the UI node**
> <br/>Apply the layout to the UI, and place all content inside the (one) child grid of the UI.
> ```xml
> <UI Grid="grid">
>   <Grid Rows="auto auto 1fr" Columns="auto auto 1fr">
>       ...
>   </Grid>
> </UI>
> ```

<br/>
<br/>

### Data source

**Use synonym**<br/>
You must use **synonym** or a fixed known datasource when accessing data, in a shared database. The <strong>@Object</strong> directive **does not work**.


> [!CAUTION]
>  When **connectiong** to a source, and setting the Source as 
>
>  ```sql
>  @Object[Data].DbObjectName
>  ```
>
>  will not work
>
> ```xml
> <SetModel Name="BudgetDataSource" 
>   Source="@Object[Data].DbObjectName"
>   Fields="Id,WorkProcessID,WorkProcessVersionID,StartDate,EndDate,Category,Owner,AmountAllocated,Currency,Status"
>   Filter="WorkProcessVersionID = @SYS_WorkProcessVersionID"
>   ItemKey="Id = @Id"
> />
> ```
>


> [!TIP]
>  When connecting to a source you need to set the Source to a known data source, like a [synonym](../../../../../docs/datapool.md#synonym)
>
> **Example** <br/>
> When data is stored in the source table "Data", you will be unable to reference these data using the directive @Object[Data].DbObjectName directive. 
> You need to apply a synonym to your source table **"Data"** and use this as the source in your form. E.g. apply a synonym called "BUDGET_DATA" to your table "Data", and use this to reference the data.
>
>  ```sql
>  BUDGET_DATA
>  ```
>
>  will work
>
> ```xml
> <SetModel Name="BudgetDataSource" 
>   Source="BUDGET_DATA"
>   Fields="Id,WorkProcessID,WorkProcessVersionID,StartDate,EndDate,Category,Owner,AmountAllocated,Currency,Status"
>   Filter="WorkProcessVersionID = @SYS_WorkProcessVersionID"
>   ItemKey="Id = @Id"
> />
> ```



**Example synonym**
![pic](https://profitbasedocs.blob.core.windows.net/images/package-configuration-form-data-synonym.png)

<br/>
<br/>

### Validation

If you need to ensure that the user has given valid input, implement a function named **Validate** which returns true or false.

**Basic example**
```xml
<Function Name="Validate">
    <![CDATA[
        // Return boolean true or false
        return true;
    ]]>
</Function>
```
> [!CAUTION]
> If the function is not implemented or is misspelled, the validation logic will treat the input as valid and proceed with the process.

Validation interaction with the user must also be handled by the validation function if the user needs feedback. If there are no user interaction implemented in the function **Validate**, on failed validation, there will be nothing informing the user of the validation result. When validation succeeds, the user will be able to continue the versioning process, hence no need for extra user interaction on success.

**Example with UI**
```xml
<Function Name="Validate">
    <![CDATA[
        
        this.app.ui.dialogs.showMessage({title: 'Validation failed',
                                          text: 'The input data is invalid, please fill in missing fields'});
        
        return false;
    ]]>
</Function>
```

<br/>
<br/>

### Variables

When the form is connected to a version, the form will have access to the **WorkProcessId** and **WorkProcessVersionId**, either via javascript or via sql parameters.

**JavaScript**<br/>
You can access the variables via the context like this:
```javascript 
this.app.variables.SYS.WorkProcessId
this.app.variables.SYS.WorkProcessVersionId
```

**SQL**<br/>
```sql
@SYS_WorkProcessID
@SYS_WorkProcessVersionID
```


> [!TIP]
> **Example using JavaScript to access the variables**<br/>
> ```xml
> <FormEventHandler On="Init">
>   <![CDATA[
>       console.log('WorkProcessId = ' + this.app.variables.SYS.WorkProcessId);
>       console.log('WorkProcessVersionId = ' + this.app.variables.SYS.WorkProcessVersionId);
>    ]]>
> </FormEventHandler>
> ```
>


> [!TIP]
> **Example using SQL to access variables**<br/>
> ```xml
> <SetModel Name="BudgetDataSource"
>       Source="BUDGET_DATA" 
>       Fields="Id,WorkProcessID,WorkProcessVersionID,StartDate,EndDate,Category,Owner,AmountAllocated,Currency,Status"
>       Filter="WorkProcessVersionID = @SYS_WorkProcessVersionID" 
>       ItemKey="Id = @Id"
> />
> ```

<br/>
<br/>


**Example design**

![pic](https://profitbasedocs.blob.core.windows.net/images/package-configuration-form-design.png)



**Example result**

![pic](https://profitbasedocs.blob.core.windows.net/images/package-configuration-form-result.png)



**Example result of failed validation**

![pic](https://profitbasedocs.blob.core.windows.net/images/package-configuration-validation-result.png)