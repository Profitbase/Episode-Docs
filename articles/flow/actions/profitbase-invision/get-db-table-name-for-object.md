# Get database object name

Gets the database table or view name for an InVision DataStore, Table, or View.

![img](../../../../images/flow/getDatabaseObjectName.png)

**Example** ![img](../../../../images/strz.jpg)  
This flow is triggered via [HTTP trigger](../../triggers/http-trigger.md), [declares variables](declare-variables.md), [retrieves](../sql-server/get-datareader.md) the physical database object name for a selected DataStore, Table, or View, reads data from the database, converts the result to a [CSV stream](../csv/create-csv-file-as-stream.md), and [uploads](../azure-blob-storage/upload-blob.md) the file to blob storage.  
The **Get database object name** action is used to resolve the actual database table or view name at runtime so it can be passed to subsequent database actions.

<br/>

## Properties

| Name                 | Data Type | Description                                                                 |
|----------------------|-----------|-----------------------------------------------------------------------------|
| Title                | Optional  | The title or name of the action.                                            |
| Connection           | Required  | The InVision connection used to resolve the database object.                |
| Table object         | Required  | The DataStore, Table, or View for which the database object name is resolved.|
| Result variable name | Required  | The variable that stores the resolved database table or view name.          |
| Disabled             | Optional  | If enabled, the action is skipped during flow execution.                    |
| Description          | Optional  | Additional notes describing the purpose of the action.                      |
