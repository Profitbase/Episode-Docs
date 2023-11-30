
# SQL Scripts

You can add custom SQL Scripts to your Solution and execute them from the script editor, Data Flows, Workbooks, Web Functions or PowerShell.
<br/>

## Defining SQL Scripts

You can add SQL scripts to folders and Data Stores in your Solution. Any valid T-SQL Script can be executed from InVision, and you can also use [InVision Standard Directives](directives.md) to more easily address objects and properties in your Solution.
<br/>

## Executing SQL Scripts from Data Flows

Scripts are executed as Tasks in Data Flow Items hosted in Data Flows.

To add a Task for executing a SQL Script to a Data Flow Item, drag and drop the **"Execute SQL Script"** template from the **Script Tasks** node in the **Data Flow Item Templates** toolbox. (Available when the Tasks node of the Data Flow Item Explorer has focus.)

Next, you need to configure the new task by:

- Specifying the Script Id:

  - Using the Data Flow Item parameter @[ScriptId]. Specify the argument by using the `@Object[<script navn>].Id-directive` or hard coding the value. If you want to hard code the Script Id, you can find it by right-clicking the node in the Solution Explorer and select "Copy Id to Clipboard".

- Specifying a language code (optional):

  - It can be hardcoded or provided as an argument. You need to specify a language code if the script is using a directive that requires a language code execution context.

- Mapping any script parameters:

  - **Name** : Specifies the name of the parameter used in the script.
  - **DataType** : Specifies the data type of the parameter.
  - **Value** : Specifies the argument. The value can be a Data Flow Item parameter of a hardcoded value.

<br/>

## Executing SQL Scripts from Workbooks

To execute a SQL Script from a Workbook, you have 3 options:  

1) Add the SQL Script as a Workbook component and use its `Execute` action  
2) Use the `Execute SQL Script` Workbook action  
3) Run the SQL Script from a Web Function  

<br/>

## See Also

- [More about Scripts](../docs/workbooks/components/script.md)

<br/>

## Videos

- [SQL Scripts](../videos/sqlscripts.md)
