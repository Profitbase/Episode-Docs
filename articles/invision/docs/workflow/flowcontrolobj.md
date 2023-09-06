---
title: "Flow Control Objects"
metaKeys: "Flow Control Objects, State Context, Reporting Column, Relay State To,  Resources"
pageIndex: 2
---


Flow Control Objects are used for managing the state and controlling user access for performing actions (input, running scripts and data flows etc) on resources under Workflow control. You would normally have one Flow Control Object pr workflow sub process, where a sub process may be an entity called "Salary", containing the worksheets, settings, data flows etc handling input and business logic related to "Salary".

By adding resources to Flow Control Objects, you specify that the resources will be controlled by the Workflow management system and the system will control identity access to the resources when deployed in Workbooks. The access rights grated to the identities are determined based on the [states](processflow/flowcontrolconfig.md) of the Flow Control Objects.

After a Flow Control Object has been set up, it can be enabled for activities and connections. When enabling a Flow Control for an activity or connection, you need to specify the possible states the Flow Control Object may enter during the workflow phase. While the Workflow is running, the states can be set by identities working in Workbooks or by data flow processes. Typical states are "Not started», "Started", "Finished", "Rejected", etc.

*	**State Context Object**

 Flow Control Objects must have a context (for example department, region, project) that the various states can be set for. The context is specified by selecting the Dimension that a state should be set for. When publishing the Flow Control Object to a Workbook, the context must be associated to a filter in order to the state setting and getting to be handled correctly.

*	**Reporting Column(s)**

 A comma separated list of columns in the State Context Object that the Workflow Status Report is generated from.
 Suppose the State Context Object is a Dimension with 3 levels (columns L1, L2 and LEAF). If you do not specify any Reporting Columns, the Status Report will contain the states for members from every level. If, for example, you only want the Status Report to contain the members at the leaf level, you enter name of the leaf level column.

*	**Relay State To**

 Enables relaying state set for the Flow Control Object to other Flow Control Objects.
 Suppose a manager approves a report, "Budget", compiled from "Salary" and "Management Accounts" managed by different Flow Control Objects respectively. In this case, you would most likely want the state set for "Budget" to apply to the "Budget" contributers as well.

*	**Resources**

 Resources that can be associated with Flow Control Objecs are Worksheets, Settings, Data Flows and Scripts. You create one Flow Control Object pr sub process, so as an example, a Flow Control Object for a payroll sub process should contain worksheets, settings, data flows and scripts having functionality related to payroll. 

When a resource is associated to a Flow Control Object, the actions the user can perform on the object is determined based on the state of the Flow Control Object for the selected context (e.g department or project) in the Workbook. 
If the state of the Flow Control Object is outside the boundaries of the permissions granted to the user, the user will not be able to perform any actions that can affect any of the resources of the Flow Control Object. For example, the user will not be able to edit or save data in a worksheet, or execute scripts or data flows.

*Note! A Worksheet can only be associated to a single Flow Control Object in the entire Solution.*

