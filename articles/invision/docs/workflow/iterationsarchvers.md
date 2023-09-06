---
title: "Iterations, Archiving and Versioning"
metaKeys: "Iterations, archiving and versioning, "
pageIndex: 3
---


The execution of a Workflow is called an iteration, which has a start and an end. An iteration can be started from InVision Dev Studio, the Workflow Panel hosted in a Workbook, or from a (scheduled) Data Flow. The start and end activities can be of any type, but you would normally start and finish with Action Activities performing rollover and archiving respectively.


The Data Set Version is derived from the iteration, so archiving data for an iteration must occur before a new iteration is started. Archiving can be performed by a Data Flow in the last [Action Activity](processflow/activity.md) of a Workflow. 

A Data Flow for archiving workflow data can be created using the [built-in Archiving Data Flow Item](../dataflowitems/builtindfitems.md). Optionally, you can create a custom Data Flow Item by adding an [Archiving Task](../dataflowitems/tasktemplates.md) to it.
