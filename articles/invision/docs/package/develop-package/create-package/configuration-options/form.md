# Form

&nbsp;&nbsp;&nbsp;&nbsp;a. [Design](#a-design)  
&nbsp;&nbsp;&nbsp;&nbsp;b. [Data source](#b-data-source)    
&nbsp;&nbsp;&nbsp;&nbsp;c. [Variables](#c-variables)    
&nbsp;&nbsp;&nbsp;&nbsp;d. [Validation](#d-validation)  




### a) Design
Create a [form](./../../../../../docs/forms/formschemas.md) residing as a sub object under the package, and then attach it to the Form-property in the 'Configuration options' section, when you have selected 'Form' as the option type.

![pic](https://profitbasedocs.blob.core.windows.net/images/package-configuration-set-form.png)


The form will be displayed with auto-height, so it is recommended that you specify the UI Grid height according to your layout needs. If you don’t specify a height, the form will automatically fill the available space.

> [!TIP]
> **Example of styling, using the CSS-node in the form**
> ```xml
> <Css>
>    <![CDATA[
>        .main {
>            height: 300px;
>            align-items: center;
>            border: 1px solid black;
>            padding: 3px;
>        }
>    ]]>
> </Css>
> ```
>
> **Example of applying the style class to the UI node**
> ```xml
> <UI Grid="grid" CssClass="main" >
>       ...
> </UI>
> ```

**Example When the CSS property height is set**

![pic](https://profitbasedocs.blob.core.windows.net/images/package-configuration-form-design-height-fixed-result.png)

**Example When the CSS property height is not set**

The form will fill the page.

![pic](https://profitbasedocs.blob.core.windows.net/images/package-configuration-form-design-height-auto-result.png)





### b) Data source

When designing the form and accessing data in the versioning context, the <strong>@Object</strong> directive **does not work** and you will need to use Synonyms.


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




### c) Variables

When the form is connected to a version, the form will have access to the **WorkProcessId** and **WorkProcessVersionId**, either via javascript or via sql parameters.

> [!TIP]
> **Example using JavaScript to access the variables**
> <br/>
> You can access the variables via the context like this:
> ```javascript 
> this.app.SYS.WorkProcessId
> this.app.SYS.WorkProcessVersionId
> ```
> ```xml
> <FormEventHandler On="Init">
>   <![CDATA[
>       console.log('WorkProcessId = ' + this.app.SYS.WorkProcessId);
>       console.log('WorkProcessVersionId = ' + this.app.SYS.WorkProcessVersionId);
>    ]]>
> </FormEventHandler>
> ```
>


> [!TIP]
> **Example using SQL to access variables**
> <br/>
> ```sql
> @SYS_WorkProcessID
> @SYS_WorkProcessVersionID
> ```
> ```xml
> <SetModel Name="BudgetDataSource"
>       Source="BUDGET_DATA" 
>       Fields="Id,WorkProcessID,WorkProcessVersionID,StartDate,EndDate,Category,Owner,AmountAllocated,Currency,Status"
>       Filter="WorkProcessVersionID = @SYS_WorkProcessVersionID" 
>       ItemKey="Id = @Id"
> />
> ```




### d) Validation

If you need to ensure that the user has given correct and valid input before deploying or changing states, you can implement a form function that will validate the input data given by the user. 

This function must be named **Validate** and return boolean.

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

Validation interaction with the user must also be handled by the validation function if the user needs feedback. If there are no user interaction implemented in the form-function "Validate", on failed validation, there will be nothing informing the user of the validation result. When validation succeeds, the user will be able to continue the versioning process, hence no need for extra user interaction on success.

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



**Example design**

![pic](https://profitbasedocs.blob.core.windows.net/images/package-configuration-form-design.png)



**Example result**

![pic](https://profitbasedocs.blob.core.windows.net/images/package-configuration-form-result.png)



**Example result of failed validation**

![pic](https://profitbasedocs.blob.core.windows.net/images/package-configuration-validation-result.png)