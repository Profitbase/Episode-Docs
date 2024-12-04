# Delete Table Entity

Delete an entity from an Azure Table.

![img](../../../../images/flow/delete-table-entity.png)



## Properties

| Name                   | Type       | Description                |
|------------------------|------------|---------------------------------|
| Title              | Optional   | A user-defined title for the action.                 |
| Connection         | Required   | Specify the [connection](connecting-to-azure-table-storage.md) to the Azure Table Storage account.        |
| Table name         | Required   | The name of the table to insert into.                  |
| PartitionKey  | Required   | Select or enter the value of `PartitionKey`.  |
| RowKey    | Required   | Value of the `RowKey`.                                     |

