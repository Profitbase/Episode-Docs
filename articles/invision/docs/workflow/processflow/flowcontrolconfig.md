
# Configuration

## Flow Control Object State Configuration

Flow Control Object State Configuration
The [Flow Control Object](../flowcontrolobj.md) configuration of a Workflow Activity or Connection contains a list of the Flow Control Objects defined in the Workflow.  When setting up the State Configuration for an Activity or Connection, you specify which states the Flow Control Object can hold at a specific phase of the Workflow. Depending on the type of activity, the states can be set by a user, a Data Flow or by the system. 

In order for a user to set states, you need to publish the Flow Control Object as a component to a Workbook. The Flow Control Object will be rendered as a dropdown editor, allowing the user to set the next state for the context. The states available to the user is determined based on which Workflow User Group he belongs to, and the current state of the Workflow.

**State**

Specifies the state of the Flow Control Object in the Workflow, for example «Started» or «Completed».
To configure states for a Flow Control Object, you need to enable it from the Flow Control Object list in the Activity or Connection and then make sure it’s selected to bring up the State Editor. Next, you simply add the states that can be set when the Workflow is in the phase governed by the activity or connection.


> [!NOTE]
> You should only create a single state for each Flow Control Object if you are setting up states for Action Activities, Wait Activities or Activity Connections. The Data Entry Activity is the only activity which allows multiple states for a Flow Control Object.

*	**Name**

 Specifies the name of the state. The value of this property is displayed in the Workflow State Report and in the Flow Control Object workbook component (dropdown list) unless it’s overridden by the Name Text Code.

*	**Name Text Code**

 Specifies the text code used for localization.

*	**Permission**

 Permission specifies how the user is allowd to interact with the resources associated to the Flow Control Object when the state is the currently active state.

 **1)**	ReadWrite – The user has permissions to edit data in Worksheets and Form Elements. Executing Data Flows and Scripts are allowed.

 **2)**	Readonly – The user does not have permission to edit data in Worksheets and Form Elements. Executing Data Flows and Scripts are disabled.

*	**Type**

 Possible values are Default and GoToOnFirstSave.

 **1)**	Default specifies that the state can be set manually by a user or by a process, for example a Data Flow.

 **2)**	GoToOnFirstSave specifies that this state should be set for the Flow Control Object the first time a user saves data for a resources. For this event to occur, a state can not have been previously set from a user action for the Flow Control Object given the current Data Context during the current Iteration.

 
> [!NOTE]
> When a state transitions **to** a state having Type **GoToOnFirstSave**, execution of Data Flows listed in state being left does not occur.

*	**State Color**

 State Color specifies the color for the state when it’s displayed in the user interface, for example in reports and Flow Control Object Workbook components. 

*	**Is Default State for new State Context Object Members**

 Specifies that this state is the state that will be assigned to new State Context Object (SCO) Members (for the current Flow Control Object) that are added to the SCO (usually a dimension) during a Workflow Iteration. If this option is not specified, new SCO Members will be assigned the state value of the first activity in the Workflow.

*	**Data Flows**

 Specifies a list of Data Flows to execute when the state changes. The Data Flows are run sequentially. The Data Flows execute when the states are left, not entered.

  
> [!NOTE]
> When a state transitions **to** a state having Type **GoToOnFirstSave**, this process does not execute.*
