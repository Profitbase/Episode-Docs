---
title: "Activity"
metaKeys: "activity, Connection, Workflow Access Groups, Data Entry, Wait, flow,Execute Manually"
pageIndex: 1
---

### Action Activity

Action Activities can execute one or more Data Flows sequentially. When the last Data Flow of an activity has completed, the outbound connections are evaluated to determine the status for Flow Control Objects, and which phase the Workflow should transition to. Statuses specified for Flow Control Objects in an activity are applied when the activity completes, before execution is moved forward. 
*Please note that you can only configure a single status pr Flow Control Object for Action Activities.*

When an Action Activity has completed all its tasks, the subsequent activity will be executed if it is an Action Activity, and the *Execute* *Manually* property is *not* set to True.

**Properties**

*	**Execute Manually**

 *If the Execute Manually Property is set to True, the following rules apply:*

    - The activity will never execute automatically, even if it’s the start activity of the Workflow

 If Execute Manually is set to False, the following rules apply:

    - When a new iteration is started, the activity will execute manually if it’s the start activity of the Workflow.
  
    - If the previous activity is an Action or Wait Activity, the activity will execute automatically.
  
**Workflow Access Groups**

The Workflow Access Groups of Action Activities specifies which identities have permissions to edit data and set status for Flow Control Objects when the activity has completed. This means that if a Data Entry Activity immediately follows an Action Activity, all identities that should have permissions to edit data must be added to both the Action and Data Entry activity.

**Data Flows**

Specifies which Data Flows to run when the activity is executed. When the Action Activity is the startup activity of the Workflow, you can specify whether a Data Flow should run:

*	Every time an iteration is started or restarted
*	Only when a new iteration is started
*	Only when an active iteration is restarted

### Wait Activity

Wait Activities pauses the Workflow, and must be executed manually (usually by a process administrator) to resume execution of the Workflow. A Wait Activity is the equivalent of an Action Activity without Data Flows or Flow Control Object configuration, having **Execute Manually** set to **True**.

### Data Entry Activity

Data Entry Activities represents the identity input phases of the Workflow. When setting up Data Entry Activities, you need to specify the Workflow Access Group(s) responsible for providing input, and which states are assignable to the Flow Control Objects at each phase.

**Workflow Access Groups**

The Workflow Access Groups of Data Entry Activities specifies which identities have permissions to edit data and set status for Flow Control Objects while the Workflow is in a phase.

### Activity Connection

Activity Connections specifies the logical flow of Workflows by connecting activities.
To enable transitioning from one Activity to the next, you need to set up Flow Control Object configurations for the connections. The states available for the identity to select from when advancing the Workflow, is a combination of the states defined in the current Activity (phase) and any outgoing connections from the Activity.
