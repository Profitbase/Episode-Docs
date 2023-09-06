---
title: "Workflow Access Groups"
metaKeys: "Workflow Access Group, layer, grouping, standard, identities, Objects,  "
folderOnly: "false"
pageIndex: 6
---



A Workflow [Access Group](../accesscontrol/accessgroups.md) contains the [identities](../accesscontrol/identities.md) and/or access groups that can participate in a [Workflow](../workflow.md).

Workflow Access Groups provides a layer for grouping standard InVision identities and access groups into business process access groups having different responsibilities in the Workflow.

For example, an organization may have department managers, region managers, and VPs as participants in one or more stages of a workflow. Given this example, you would create a Workflow Access Group for each of these roles and assign them to different activities of the workflow. 

When a Workflow Access Group is assigned to a workflow activity, the identities of the WF Access Group have access to providing input or performing actions on the resources attached to the Flow Control Objects managed by the activity. 

identities of Workflow Access Groups not assigned to the activity are still allowed to view data and track progress, but they will not be able to edit or perform any actions until the workflow enters a state granting them read-write access.
