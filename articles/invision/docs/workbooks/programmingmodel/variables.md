
# Variables


## Global variables

The [Workbook](../../workbooks.md) session maintains a set of variables accessible everywhere in the Workbook. Variables can be created or assigned to when an ExecuteExpression Action is called.

It is recommended to always use standard (Eaze) variables, however, @Var[…] instruction is supported for backward compatibility and it also allows you to use variables that contain whitespace characters.

## System Variables

The following variables are set by the system. System variables are globally available.

**SYS.CurrentUserName**

*	Returns the user name of the currently logged-in user.

**SYS.SYS_DataSetID** 

*	When the Workbook is under Workflow Control, returns the Data Set ID associated with the Workflow.

*	For backward compatibility reasons, SYS_DataSetID can also be accessed using @Var[SYS_DataSetID].

**SYS.SolutionId**

*	Returns the Solution Id that the Workbook belongs to.

**SYS.WorkbookId**

*	Returns the Id of the Workbook.

**QSP.< query string parameter >**

*	Any query string parameters from the url can be accessed through the QSP system variable.  
For example, if the url contains the query string id=124, calling QSP.id will return "124".

*	For backward compatibility reasons, query string parameters can also be accessed using @Var[QSP::< param >], for example, @Var[QSP::id].


>**Example**
>
>This example shows how to display the name of the current user in a Label.  
>To display a dynamically evaluated text in a Label, you need to apply using the SetText – function to the Text property of the Label.
>
>To display the name of the current user, add the following expression to the Text property of a Label.
>
        SetText("The current user is " + SYS.CurrentUserName);




