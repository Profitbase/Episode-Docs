```ColumnHeader()```  
Returns the caption of the column.

```RowHeader()```  
Returns the caption / text of the row. Can be used in an IF statement, or a Conditional field.

```RowLevel()```  
Returns the level of the row. Can be used in an IF statement, or a Conditional field. E.g. Apply a style to specific levels only.

```Row().formatString```
Returns the format string applied to the row. 

```Row().style```  
Returns the styles that are applied to each row. Can be used in formulas or conditional formatting.

Available styles to reference:
* stylesTotal
* stylesSubtotal
* stylesKPI
* overline
* underline
* custom1
* custom2
* custom3
* custom4
* custom5
* custom6
* bold
* hidden

## Extra flexibility by using JSON-strings:
By using a JSON-string, you can call all parts of the sting by using ```Row()."columnName"```


The default JSON-string consists of:
* id
* displayName
* formula
* style
* formatString
* signFactor



{
  ```"id"```: "L1Sum",
  ```"displayName"```: "1Sum - Reportline",
  ```"formula"```: "L10+L12",
  ```"style"```: "bold overline",
  ```"formatString"```: "#,0",
  ```"signFactor"```: 1
}


This could be extended with any columns you want, by adding a new column name and a value to the JSON-string:

{
  ```"id"```: "L1Sum",
  ```"displayName"```: "1Sum - Reportline",
  ```"formula"```: "L10+L12",
  ```"style"```: "bold overline",
  ```"formatString"```: "#,0",
  ```"signFactor"```: 1,
  **```"IsIncome"```**: 1,
}



That last column added to the string could be referenced using the formula ```Row().IsIncome```, and would return the value ```1```, which could be used in conditional formatting.


For example:
If value is greater than 0, and ```IsIncome == 1```, then apply a style with green font color.

