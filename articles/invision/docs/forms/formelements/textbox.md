
# TextBox

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/text%20area.png)

<br/>

___



## Enables displaying and editing data as a text value

**Select Value Query**

Specifies the [Data Query](../../sqlreports/dataqueries.md) which returns a single value which is set as the initial value of the Text Box.

>**Example**
>
>This example shows a query for displaying the number of units in store for a given product. 
>
    SELECT Qty  
    FROM @Object[Products].DbObjectName  
    WHERE ProductID = @ProductID 


**Max Length**

Specifies the maximum number of charachters that the user is allowed to enter in the Text Box. The default is unlimited.

**Save Data Expression**

Specifies the Data Query used for saving data. The query must handle both insertion of a new row and updating an existing one. 

>**Example**
>
>This example shows a SQL expression that updates an existing row if it already exists (updates the number of items in store for a specific product), and inserts a new row if it doesn’t exist. 
>
    MERGE @Object[Products].DbObjectName AS [Target]  
    USING(SELECT @ProductID AS Key1) AS [Source](Key1)  
    ON([Target].ProductID = [Source].Key1)  
    WHEN MATCHED THEN UPDATE SET [Target].Qty = @FormElementValue()  
    WHEN NOT MATCHED THEN  
    INSERT (ProductID,Qty)  
    VALUES([Source].Key1,@FormElementValue());
