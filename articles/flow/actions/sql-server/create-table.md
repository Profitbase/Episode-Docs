# Create table

Creates a table in a SQL Server database.  

If the table already exists, this action does nothing (no error is raised). 



![img](https://profitbasedocs.blob.core.windows.net/flowimages/create-table.png)

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           |  Optional | The title or name of the command.        |
| Connection         | Required   | The SQL Server connection. |
|Table name   | Required      |  |
| Column definition | Required  |   |
|Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |

### Column definition

![img](https://profitbasedocs.blob.core.windows.net/flowimages/col-def.png)