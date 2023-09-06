---
title: "ConfigureInvocation"
metaKeys: "ConfigureInvocation, "
folderOnly: "false"
pageIndex: 2
---

### ConfigureInvocation(...)

<br/>

```
ConfigureInvocation(componentName : string, actionGroupName : string, argument : any : Eaze expression)
```

ConfigureInvocation(…) is used in InvokeActionGroup actions to specify which Action Group to execute. Invoking an Action Group from multiple places allows you to reuse business logic, for example by executing an Action Group defined for a button from a context menu item.
componentName. The name of the component specified in the property editor for the component.

* For UI Elements (Buttons, Labels, etc), the component name is the Name property.
* For Workbook Pages, the component name is the Name of the Page (as displayed in the Title property and Solution Explorer)
* For the Workbook, the component name is the name of the Workbook (as displayed in the Solution Explorer)
<br/>

**Example**

This example shows how to execute an Action Group named ‘Update All’ defined by the button named ‘Btn_X’.

Suppose you have a button ‘Btn_Y’ that should perform the same actions as "Btn_X". You can use an InvokeActionGroup action (available as a Workbook action item) and then call ConfigureInvocation to specify the arguments:

```
ConfigureInvocation("Btn_X","Update All",null);
```

The 3rd parameter of ConfigureInvocation is the context argument. You can pass in a value or provide an EAZE expression that returns a value. At the receiving end, the value can be accessed using through the @Event.Data property.

```
ConfigureInvocation("Btn_X","Update All", MyVar);
```

The following example shows how to specify which action group of the Department filter to invoke.

```
ConfigureInvocation(Filter("Filters", "Department").FullName, "SelectionChanged");
```
