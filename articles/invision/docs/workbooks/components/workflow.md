---
title: "Workflow"
metaKeys: "Workflow, Iteration management and reports, Status Report, Workflow Work Unit, Events,  State Changed"
folderOnly: "false"
pageIndex: 20
---



### Iteration management and reports

[Workflows](../../workflow.md) defined in the Solution are listed in the [Workbook](../../workbooks.md) Toolbox and can be added to the Workbook by dragging and dropping them onto [pages](../pages.md). When a Workflow part is added to a Workbook, you can enable the user interface for [Iteration Management](../programmingmodel/interactionmodel.md) and/or reporting the status.

To enable the user interface for Iteration Management, set the **Enable Iteration Management** property to true.

To enable the Status Report, set the **Enable Report View** property to True.

**Iteration Management**

Starting, restarting, and executing Workflow Activities is done from the Iteration Management screen. 

*	**Starting a new iteration** 
When starting a new iteration, the user can provide a name for the iteration. If no name is provided, the current date in addition to the Workflow Name will be used as the name for the iteration. 


*	**Restarting an active iteration**
The Workflow is aborted at its current state and restarted. Restarting an activity will not roll back any changes made to the data.


*	**Executing Workflow Activities**
The activities of the Workflow are listed in order of execution. If there are activities where manual execution is required (Wait Activities or Action Activities set up for manual execution), they can be executed from this list. 

**Status Report**

The Status Report screen shows the states of the Flow Control Objects for the active iteration. 
For every Flow Control Object, the state and number of members holding the state is displayed. The members are the items found in the State Context Object of the Flow Control Object. 

By selecting a state, all members of the state are displayed.

### Workflow Work Unit

Workflow Work Units defined in the Solution are listed in the Workbook Toolbox and can be added to the Workbook by dragging and dropping them onto pages.

When a Work Unit is added to a Workbook, all Workbook components (for example Worksheets) also listed as resources in the Work Unit definition gets subjected to control based on the states of the Workflow that the Work Unit object is configured to use. 

The Work Unit object is rendered as a dropdown containing the states available for the currently active Data Context (selected department, product, etc.). If the Data Context has not been configured, or the user has not selected a Data Context (for example a department from a Department filter), no states will be loaded.

When the user has changed the state, it needs to be saved. To save the selected state, the Save Action of the part needs to be executed. When the state has been saved, the dropdown list will automatically update to reflect the new available settable states. 

### Events

**State Changed**

*	This event is raised when the user selects a new state from the dropdown list:

        @Event properties  
        @Event.Data.NewValue.Name //Specifies the name of the state that the user selected  
        @Event.Data.NewValue.StateId //Specifies the id of the state that the user selected



### See Also

* [Workflow](../../workflow.md)