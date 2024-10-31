# Create Workspace

Creates a [Workspace](https://learn.microsoft.com/en-us/fabric/get-started/create-workspaces) in a Microsoft Fabric.


![img](../../../../images/flow/create-workspace-fabric.png)

## Returns
Returns a [Workspace](https://learn.microsoft.com/en-us/fabric/get-started/workspaces) object.

## Properties

| Name                | Type     | Description    |
|---------------------|----------|------------------------------------|
| Connection          | Required | The [Microsoft Fabric Connection](./microsoft-fabric-connection.md) used to make an authenticated request to the Microsoft Fabric REST API. To create a Connection, [please follow these steps](./microsoft-fabric-connection.md). Make sure to choose an authentication method with required privileges. |
| Workspace Name      | Required | Specifies the name of the workspace to be created or accessed.    |
| Workspace Description | Optional | A brief description of the workspace's purpose or contents.   |
| Capacity Id         | Optional | Specifies the capacity ID for resource allocation.  |
| Result Variable Name| Optional | The name of the variable in which the workspace result is stored. Default is `workspace`.    |
| Description         | Optional | An additional description of the environment or other relevant information.  |



