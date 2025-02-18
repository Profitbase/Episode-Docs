# Create table

Creates a table in a SQL Server database.  

If the table already exists, this action does nothing (no error is raised). 


![img](https://profitbasedocs.blob.core.windows.net/flowimages/create-table2.png)

## Properties

| Name            | Type            | Description                                       |
|-----------------|-----------------|---------------------------------------------------|
| Title              | Optional        | A descriptive title for the action.               |
| Connection      | Required | The [SQL Server Connection](./connection.md).         |
| Dynamic connection | Optional | Use this option of you needs to use a connection from the [Create Connection](./create-connection.md) action. |
| Table name   | Required      |  Name of the table to be created.  |
| Column definition | Required  | A list of columns with data types. |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |



![img](https://profitbasedocs.blob.core.windows.net/flowimages/create-table.png)


### Column definition

![img](https://profitbasedocs.blob.core.windows.net/flowimages/col-def.png)