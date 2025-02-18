# Delete table

Deletes a table from a SQL Server database.  

If the table does not exist, this action does nothing (no error is raised).


![img](https://profitbasedocs.blob.core.windows.net/flowimages/delete-table.png)


## Properties

| Name            | Type         | Description                                       |
|-----------------|--------------|---------------------------------------------------|
| Title              | Optional        | A descriptive title for the action.               |
| Connection      | Required | The [SQL Server Connection](./connection.md).         |
| Dynamic connection | Optional | Use this option of you needs to use a connection from the [Create Connection](./create-connection.md) action. |
| Table name   | Required      | Name of the table to be deleted.  |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds. |
| Description   | Optional | Additional notes or comments about the action or configuration. |
