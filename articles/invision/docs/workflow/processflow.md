---
title: "Process Flow"
metaKeys: "Process Flow, "
folderOnly: "false"
pageIndex: 4
---

The [Workflow](workflowusergroups.md) is depicted as a sequence of connected activities. There has to be a single start activity, and a single end activity. The end activity cannot have an outgoing  [Activity Connection](processflow/activity.md). The flow sequence can contain branches, and connections can point to activities earlier in the workflow from a later phase. Connections pointing backwards to earlier phases of a Workflow is typically used for approval processes, for example by giving superiors an opportunity to reject proposals.

There are three types of activities: **Action Activity**, **Wait Activity** and **Data Entry Activity**.


* [Activity](processflow/activity.md)
* [Configuration](processflow/flowcontrolconfig.md)