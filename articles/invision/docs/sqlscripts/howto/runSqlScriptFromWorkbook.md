
# Run SQL Script from Workbook

To run a SQL Script from a Workbook, use the `Execute SQL Script` Workbook action found in the Action list (see image below).
![Run SQL Script from Workbook](https://profitbasedocs.blob.core.windows.net/images/Run_SQLScript_From_Workbook.png)

1) Drag and drop the `Execute SQL Script` action onto the Actions list.  
2) Optionally, add `SetParamValue()` instructions if the SQL Script is parameterized. You need one `SetParamValue(...)` pr sql parameter.  
3) Finally, use the `Execute(...)` instruction to run the script.

**Example**  
Suppose we have a SQL Script named "DeleteCustomer" that we want to run from a Workbook.
```sql
DELETE FROM Customers WHERE CustomerID = @CustomerID
SELECT @CustomerID AS DeletedCustomerID
```

Use the `SetParamValue(...)` instruction to provide the customer id, and the `Execute(...)` instruction to specify the name of the SQL Script to run.  
```javascript
SetParamValue("@CustomerID", "Customer1");
_sqlScriptResponse = Execute("DeleteCustomer");
```  

In the example above, the SQL Script returns a value that we store in the `_sqlScriptResponse` variable.  
To access the value returned from the SQL Script in other Workbook component, use the Data property of the variable.  

**Example**  
```javascript
ShowToastNotification('Customer ID was ' + _sqlScriptResponse.Data.DeletedCustomerID);
```