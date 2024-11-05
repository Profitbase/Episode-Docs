# Getting started

This getting started guide outlines the main steps required to creating and running your first Flow.

### 1. Create a Workspace
Start by [creating a Workspace](./workspaces/create-workspace.md) if you don't already have one.
Before you can create any Flows, you need to have at least one [Workspace](./workspaces.md). A Workspace is a logical container of Flows and artifacts that belong together, and there is no restriction on how many Flows a Workspace can contain. Within a Workspace, you can choose to organize Flows in Folders if the number of Flows get large. If you have an existing Flow that you want to edit, you need to open the Workspace it belongs to and then select the Flow you want to edit.

![img](/images/flow/create-workspace.png)

### 2. [Optional] Grant other users permissions to the Workspace
When you create a Workspace, you will automatically be granted access to it. By default, tenant administrators have access to all Workspaces.  
If you want other (non-admin) users to have access to the Workspace, you need to explicitly grant them access. [Read more here.](./workspaces/workspace-access-control.md)  

### 3. Create a Flow

With your Workspace created, you can now [create a Flow](./flows/create-flow.md). 

![img](/images/flow/create-flow-from-portal.png)


## Run Flows
You have multiple options for running a Flow. The topics below describe different ways of running Flows during development, production, and from 3rd party apps.

[Run a Flow from the Flow Designer](./flows/running-flows/from-designer.md)  
[Run a Flow from a trigger](./flows/running-flows/from-events-in-external-systems.md)  
[Run a Flow from a 3rd party app](./flows/running-flows/from-third-party-app.md)  
[Run a Flow on a schedule](./flows/running-flows/run-scheduled.md)  

[Run a Flow from an InVision Workbook](../invision/docs/flows/how-to/run-flow-from-workbook.md)  
[Run a Flow from an InVision Form](../invision/docs/flows/how-to/run-flow-from-form-schema.md)