# Truncate table

Truncates(empties) a table in a SQL Server database.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/SQL-example-truncate.png)

## Properties

| Name         | Type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title              | Optional        | A descriptive title for the action.               |
| Connection      | Required | The [SQL Server Connection](./connection.md).         |
| Dynamic connection | Optional | Use this option of you needs to use a connection from the [Create Connection](./create-connection.md) action. |
| Table name  | Required  | Enter or select the table name. |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |




![img](https://profitbasedocs.blob.core.windows.net/flowimages/truncate-table.png)