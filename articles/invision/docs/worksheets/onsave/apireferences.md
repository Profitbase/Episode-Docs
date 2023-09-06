---
title: "API References"
metaKeys: "On Save, data validation, modifying data, sending messages and so on, Named SQL Scripts, Executing business logic before, after save, GetValue, CudDataPackage, QueryParam, TableOperationType, ExecuteNonQuery, ExecuteScalar, ExecuteScalar "
pageIndex: 1
---




#### CudDataPackage

CudDataPackage contains all rows to insert, update or delete during a save process.  

**Properties:**

**All**  
``System.Collections.Generic.List<CudRecord>``  
The list of all the rows in the live data set that was sent to the server from the client. This property only contains data if Rows was set to ‘All’ in the Arguments parts of the OnSave configuration. 

**Deletes**  
``System.Collections.Generic.List<CudRecord>``  
The list of rows to delete.  

**Updates**  
``System.Collections.Generic.List<CudRecord>``  
The list of rows to update. 

**Inserts**  
``System.Collections.Generic.List<CudRecord>``  
The list of rows to insert. 

**Parameters**  
``System.Collections.Generic.Dictionary<string,object>``  
Custom parameters passed from the client using SetParamValue(“@Param”, value);. 


>**Example**
>
>This example shows how to find all unique account IDs from the list of rows being updated, and then execute a parameterized SQL script for each account id. 
> 
>       protected override void OnBeginSave(CudDataPackage data)
    {
    base.OnBeginSave(data);    
>
        object myParam;
    if(data.Params != null && data.Params.TryGetValue("@SomeParam", out myParam) == true)
    {
        // SetParamValue(“@SomeParam”, someValue); was called when invoking save from the client
    }
>
    if(data.Updates != null)
    {
	var accountIds = (from update in data.Updates
			select update.GetValue<string>("AccountID"))
                   .Distinct();
	foreach(var accountId in accountIds)
	{
	       ExecuteNonQuery("Update @Object[UpdateHistory]  
           .DbObjectName SET LastChanged = GETDATE() WHERE AccountID = @AccountID", 
		new QueryParam[]{ new QueryParam("@AccountID", accountId) }, true);
	        }        
        }
    }


#### CudRecord	

CudRecord represents a row to insert, update or delete. The values of the row can be read from or written to by using an indexer or the GetValue method described below. The Values collection of the object allows you to iterate over all the values of the row.



**Properties:**

**Values**  
``System.Collections.Generic.List<CudValue>``  
A list of all the values of the row. Each entry has an key and value property describing the column name and value.



**Methods:**

``GetValue<T>(string columnName)``  
*Objekt of type T*  
Returns the cell value of the specified column as a type. If T does not match the type of the cell or cannot be cast, the operation fails. If the column does not exist, the default value for T is returned.

``this[string columnName]``  
*System.Object*  
Returns the cell value of the specified column. If the column does not exist, a KeyNotFoundException is thrown.


>**Example**
>
>This example shows how to ensure that the minimum value for Amount is 0 and maximum is 2000 for all rows. The data type of amount is decimal. 
>
    foreach(CudRecord row in rows)
    {
        var amount = row.GetValue<decimal?>("Amount");
        if(value == null || value < 0.0m)
        {
            row["Amount"] = 0.0m;
        }     
        else if(value > 2000.0m)
        {
            row["Amount"] = 2000.0m;
        }   
    }


#### CudValue

Represents a cell value.

**Properties:**

**Key**  
``String``  
The name of the column.

**Value**  
``System.Object``  
The value of the cell.


