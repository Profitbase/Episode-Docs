---
title: "Var"
metaKeys: "Var"
folderOnly: "false"
pageIndex: 38
---

### Variable

<br/>

**@Var[Variable_name]**

We use **@Var[…]** for reading and writing to variables in the Workbook whose name contains whitespace characters, such as Data Flow and Script components. 

The variable is automatically created the first time a value is assigned to it. 

**Note!**
>
>*You shouldn't use **@Var** for user-defined variables but standard (Eaze) variables instead. The main purpose of @Var is to read state information about Data Flows, Form Elements, and Scripts, because their names may contain whitespaces, so InVision wraps them in a @Var[…] statement.*

<br/>

### Setting a variable

<br/>


```
@Var[variable name] = <expression or value>
```

A variable can only be set during the exectution of an Execute Expression action. 
<br/>

**Example**
>
>To create or assign a value to the variable «Factor», use the following syntax: 

```
@Var[My Factor] = 12.4;
```


You can assign values to variables from other sources such as context variables when handling expressions or by calling the [Filter(…)](filter.md) function.
<br/>

**Example**
>
>This example shows how to store the row that was right clicked when a custom context menu item was clicked in a Worksheet or Report. The statement is run in the Execute Expression action of the Workbook. 

```
@Var[Last Row Clicked] = @Event.Data;
```
<br/>

>You can also assign values to variables by dot’ing (.) into a context variables.

```
@Var[Last Row Clicked].ProductID = @Event.Data.ProduktID;
```

<br/>

### Reading a variable

<br/>

Reading a variable is done by referencing the variable in an expression.
<br/>

**Example**
>
>This example shows how to dereference a variable in the Text property of a Label, so that the Label displays a text such as «The selected product is Spoon"…of course, there is no spoon.

```
CONCAT("The selected product is",  @Var[Last Row Clicked].ProductName);
```
<br/>


**Example**
>
>This example shows how to open a browser window to display an appendix for a row that was right clicked. The instructions are executed by an Execute Expression action when a CellActionLinkTapped event is raised. 


```
OpenBrowserWindow(CONCAT("http://api.company.com/appendix/", @Event.Data.ProsjektID));
```
<br/>

### Nullify a variable

<br/>

To nullify a variable, assign null to the variable. 

```
@Var[Name] = null;
```
<br/>

### Assign a unique value to a variable 

<br/>

To assign a unique value to a variable, use the NEWID() function. 

```
Var[Name] = NEWID();
```


