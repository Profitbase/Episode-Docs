# Auto transactions

Auto Transactions enable the definition of one or more transactions derived from a source transaction or entity.    
A typical use case for using Auto Transactions is when working with driver based (financial) models. Business drivers, such as `Human Resources`, almost always comprise sub items such as salary, health insurance, retirement plans, life insurance and so more. By using Auto Transactions, you can establish a "master-details" relationship between an entity and its sub-items. This allows for automatic generation of sub-items into your budget, forecast, or any other dataset, eliminating the need for manual entry at a granular level.


## Properties  

| Name         | Type             | Description                                                |
|--------------|------------------|------------------------------------------------------------|
| Key columns  | Optional         | All Auto Transaction tables must have at least one logical key. If no Primary Key is defined on the table in InVision, or you want to use a different set of columns to make up the key, you can specify the key manually here. Flow uses the key to find which Auto Transactions rows to return from the `FilterByContext()` and `FilterByContextDistinctByTypeId()` methods. |
| Data         | Optional         | Specifies the fields / columns from the Auto Transaction table that you want to use for business logic. By default, all non-key columns are automatically available.                                                   |
| Key mappings | Optional         | Use this option to define explicit mapping between the `Key columns` and the (corresponding) columns in the data source when names does not match. Flow determines which Auto Transactions to use by comparing the values in the `Key columns` to the corresponding columns in the input row from the data source. If not specified otherwise, it matches against columns with the same name. If you need a different behavior, you need to specify the mapping between the keys explicitly. |
| Auto Transaction type | Optional | Specifies the name of the column that defines the Auto Transaction type. You can consider Auto Transaction type as a way to categorize Auto Transactions. For example "Company car" may be a type in the "Employee benefits" Auto Transactions table.  | 


## Generating Auto transactions  

To generate auto transactions, do the following:
1) Add an `Auto transactions` action to the Flow.  
2) Add a [Define Calculation Flow database output](define-calculation-flow-db-output.md) actions.
3) Add a
4) Add a [Function](../../built-in/function.md) action to do the calculations and generate the transactions.
5) Save the data to the database.

## API

| Name                            | Description                                  |
|---------------------------------|----------------------------------------------|
| FilterByContext(bool)           | Returns the Auto Transactions having key match against the data source input row currently used as context. | 
| FilterByContextDistinctByTypeField(bool) | Returns the Auto Transactions having key match against the data source input row currently used as context, also filtered by the `Auto Transaction type` property. If you have specified the `Auto transaction type` property, you should use this API to avoid the possibility of getting duplicates. |
| UseContext(input)               |                                              |
| Set{FieldId}Context(string)     | Sets the value used for matching against {FieldId} in the Auto Transaction table. For example, `SetDepartmentIDContext("a")` will set "a" as the value to match against the `DepartmentID` field in the Auto Transaction table. Use the `Get{FieldId}Context()` and `Set{FieldId}Context()` when you need to change the search context on a granular level, for example if you generate Auto Transactions in a Distribution Key loop.  |
| Get{FieldId}Context()           | Gets the value value used for matching against {FieldId} in the Auto Transactions table. For example `GetDepartmentIDContext()` returns the `department id` that is used for matching against the `DepartmentID` field in the Auto Transaction table. |