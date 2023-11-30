
# Parameterization

Parameterization of Data Flows enables you to provide input to the steps and control flow logic during execution.
<br/>

## Parameterized execution

To pass arguments to a Data Flow being executed from a Workbook, you need to edit the Arguments property of the Data Flow part from the Workbook designer.

The editor shows a list of all activities and their respective parameters hosted by the Data Flow. When selecting the activity, you get a list of the parameters and any default arguments. 

To override the default values, you can use variables, the Filter(…) function, or hard coded values. InVision resolves the arguments by evaluating all values as Eaze expressions.

<br/>

**Example**
>
>This example shows how to specify the arguments passed to a Data Flow Activity.  
>The values listed in the Default Value column is used unless a value is provided in the Override Value column. The values in the Override Value column must be valid Eaze expressions, meaning they can contain references to variables.
>
>In this example, a variable x = "FOO" exists. (We’re referencing it in the myAbbrev argument expression, by only getting the first 2 letters).
>
>| Argument name 	| Default Value 	| Override Value                                   	|
|---------------	|---------------	|--------------------------------------------------	|
| myInt         	| 1             	| 1                                                	|
| myString      	| Hello         	| "Hello"                                          	|
| myDate        	| 1900.01.01    	| DATE(1900,1,1)                                   	|
| myDec         	| 22.4          	| 11.6                                             	|
| myDepartment  	|               	| Filter("Filters", "Department").SelectedValue.Id 	|
| myAbbrev      	|               	| SUBSTRING(x, 0, 2)                               	|



<br/>

## See Also
* [Global Parameters](parametrization/globalparameters.md)
* [Programmatically change Global Parameters](parametrization/programmatically-set-glob-param.md)
<br/>

## Videos

* [Data Flows](../../videos/dataflows.md)
* [Introduction to Parameterization](https://profitbasedocs.blob.core.windows.net/videos/Data%20Flow%20-%20Introduction%20to%20parameterization.mp4)