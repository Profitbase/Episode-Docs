---
title: "Formatter"
metaKeys: "Editing column layout, Default Value, Name, Caption, Expression, Store Column Binding, Order By, Dropdown Selection, custom parameters, format, formatter"
pageIndex: 7
---

#### Formatter

A JavaScript function expression, or the name of a function defined in a solution JavaScript. The formatter returns the value to display in the cells of the column.
 
> [!NOTE]
> This only affects the displayed value, not the actual value of the cells, so for example copying data will copy the actual value and not the displayed value. 


>**Example**
>
>Column1 and Column2 in the following table has the Formatter property set to:  
>**Column1** : func::examples.customCellFormatters.stringFormatter.col1Formatter  
>**Column2** : func:: examples.customCellFormatters.stringFormatter.col2Formatter
>
>
>| Column1_Operation 	| Column1 	| Column2_Operation 	| Column2 	|
|-------------------	|-------------	|-------------------	|-----------	|
| ReverseText 	| Darth Vader 	| Enclose 	| Some text 	|
| ToUpper 	| Darth Vader 	| ToLower 	| Some text 	|
|  	| Darth Vader 	|  	| Some text 	|
>
>___
>
>*Formatters implementation*
>
    var examples;
    (function(examples){
        var customCellFormatters;
        (function(customCellFormatters){
            var stringFormatter = (function(){
                function stringFormatter(){                
                }
                stringFormatter.col1Formatter = function(evtArgs){
                    if(evtArgs.rowData.Column1_Operation === 'ReverseText'){
                        return !evtArgs.value ? null : evtArgs.value.split('').reverse().join('');
                    }else if(evtArgs.rowData.Column1_Operation === 'ToUpper'){
                        return !evtArgs.value ? null : evtArgs.value.toUpperCase();
                    }else{
                        evtArgs.handled = false;
                    }                
                };
                stringFormatter.col2Formatter = function(evtArgs){
                    if(evtArgs.rowData.Column2_Operation === 'Enclose'){				 
                        return '(' + evtArgs.value + ')';
                    }else if(evtArgs.rowData.Column2_Operation === 'ToLower'){
                        return !evtArgs.value ? null : evtArgs.value.toLowerCase();
                    }else{
                        evtArgs.handled = false;
                    }
                };
                return stringFormatter;
            })();
            customCellFormatters.stringFormatter = stringFormatter;
        })(customCellFormatters = examples.customCellFormatters 
        || (examples.customCellFormatters={}));
    })(examples || (examples = {}));
>
>Gives the following result
>
>| Column1_Operation 	| Column1 	| Column2_Operation 	| Column2 	|
|-------------------	|-------------	|-------------------	|-------------	|
| ReverseText 	| redaV htraD 	| Enclose 	| (Some text) 	|
| ToUpper 	| DARTH VADER 	| ToLower 	| some text 	|
|  	| Darth Vader 	|  	| Some text 	|


*Cell Formatter Event argument*

The event argument passed to the formatter function has the following properties (note the camel casing).

**Properties:**

**value**

The value of the cell.

**rowData**

The data row that the cell belongs to.

**handled**

Set this property to false if you want the standard formatting to apply.

**rowNum**

The visual row index.

**colNum**

The visual column index.

**prop**

The property name of the rowData object that the cell is data bound to. This is usually the column name of the data set, for example “Amount”.



