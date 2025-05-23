# Insert rows

Inserts rows of data into a SQL Server database from a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) or a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable).

Use this action when you have many rows that you need to insert to a table.



![img](../../../../images/flow/insert-rows.png)

**Example** ![img](../../../../images/strz.jpg)  
The example above takes a file from storage, reads its JSON content, saves the data to a database, and then deletes the storage folder to keep things tidy.  Used actions: 1. [Read file from share as a stream](../azure-files/read-file-as-stream.md) 2. [Get JSON DataReader](../json/get-json-datareader.md) 3. Insert rows 4. [Delete directory](../azure-files/delete-directory.md).

</br>


## Properties

| Name               | Type            | Description                                       |
|--------------------|-----------------|---------------------------------------------------|
| Title              | Optional        | A descriptive title for the action.               |
| Connection      | Required | The [SQL Server Connection](./connection.md).         |
| Dynamic connection | Optional | Use this option of you needs to use a connection from the [Create Connection](./create-connection.md) action. |
| Source             | Required        | The data to insert. This can be a DataReader or a DataTable. |
| Destination table  | Required        | Select or enter the name of the table to insert info. |
| Batch size         | Optional        | The number of rows inserted pr batch. The default is 5000. The batch size may affect the performance of the operation, and the optimal setting may vary from case to case. |
| Result variable name | Optional  | Name of the variable containing the number of rows inserted.  |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration.|

## Target table schema

The target table is required to have a schema (columns and data types) that match the schema of the `Source` DataReader or DataTable.
The columns does not have to be in the same order, but they must **match by name and data type**.
