---
title: "Programmatically Change Global Parameters"
metaKeys: "Programmatically change Global Parameters, DefaultResources, Profitbase.AppFramework.Infinity.dll, C# script, change the Global Parameters and arguments during execution of a Data Flow, Dictionary<string,object>, Global Parameters, Define, Passing arguments using Global Parameters, Dataflow is executed from a Workbook, Dataflow Items  "
pageIndex: 2
---


Sometimes, you need to change the Global Parameters and arguments during execution of a Data Flow. By doing that, you change the global parameters and the arguments within the current execution scope of the Data Flow, meaning all following Data Flow Activities in the current Data Flow and nested Data Flows.
<br/>

**Step 1:** Create a C# script that returns the new arguments to the Global Parameters.

In a Data Flow Item, create a new C# Script under *Resource Sets / Local Resource Sets / DefaultResource* (if it does not exist, create it). You can name the script whatever you like.

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/glParam1.png)

<br/>

Next, add a method to the script that returns a ``Dictionary<string,object>``, where the keys are the names of the Global Parameters, and the values are the arguments. 

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/glParam2.png)

<br/>

**Step 2:** Add an assembly reference to Profitbase.AppFramework.Infinity.dll (Profitbase Runtime Functions).  
This will let you call a function to update the global parameters with the new values that you have produced in Step 1:

1.	Select the DefaultResources node in the Explorer,
2.	Choose the Assemblies tab in the Toolbox,
3.	Drag and drop the Profitbase.AppFramework.Infinity.dll into the Resources view.

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/glParam3.png)

<br/>

**Step 3:** Update the arguments to the Global Parameters.

1.	Select the Tasks folder in the Explorer,
2.	Then, select the Actions tab in the Toolbox,

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/glParam4.png)

<br/>

3. Locate your method (from Step 1) in the Actions Explorer and drag-drop it into the Tasks list. Press the Refresh button at the top of the Actions Explorer if you cannot find it,

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/glParam5.png)

<br/>

4.	Select the new task in the Explorer and change the Execution Phase to Phase 1,

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/glParam6.png)

<br/>

5.	Select the Tasks folder in the Explorer and pull in the SetGlobalArguments method from the Actions Toolbox. The SetGlobalArguments will completely overwrite the current global arguments. If your method produces only a subset of the new global arguments, use the UpdateGlobalArguments instead. It will overwrite an argument with the same key, and add new arguments, but it will not delete an argument. 
The GetGlobalArguments method returns a ``Dictionary<string,object>`` which can be passed into your C# script.


<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/glParam7.png)

<br/>

6.	 Select the new task in the Explorer and change the Execution Phase to Phase 1.

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/glParam8.png)

<br/>

The new arguments will be applied to all tasks at the current and descendant levels of the execution tree. They will not be applied to Data Flows higher in the execution tree if Data Flows are nested.

<br/>
