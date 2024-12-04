

# Connecting to Azure Table Storage

When adding an Azure Table Storage action, select an [existing connection](../../workspaces/workspace-objects.md) or create a new one. 

## Connection details

An Azure Blob Storage connection consists of the following fields:

| Property                         |       | 
|-------------------------------|------------------|
| Connection name                          |       Required     |
| Connection type |       Required         |






Specify the connection to an Azure Table. Supported connections are:

1. SAS Uri to a storage account with permissions to all tables,
2. SAS Uri to an Azure Table,
3. connection string to the storage account,
4. connection string to the storage account and the specified table name.


![img](../../../../images/flow/connection-type-azure-tab.png)

A [SAS URI](https://learn.microsoft.com/en-us/azure/storage/common/storage-sas-overview) connection:

![img](../../../../images/flow/foreach-table-entity3.png)

A Storage account connection:

![img](../../../../images/flow/foreach-table-entity4.png)
