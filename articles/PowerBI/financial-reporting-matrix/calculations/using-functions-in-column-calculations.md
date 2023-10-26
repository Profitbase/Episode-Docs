All column calculations support using functions to perform it. A function can take one or more inputs (arguments). An argument can be a hardcoded value, for example, a number, a string (text), or an argument can be a cell value.

Function arguments are separated by **commas**. This differs from Excel, where semicolons are argument separators.

As an example, we’ll use the **CAGR** function to compute growth.
The CAGR function takes 3 arguments. The beginning and ending value + the number of years, so it will look like this:

```
CAGR(beginningValue, endingValue, numOfYears)
```

1.	In edit mode, create a custom column or override a column calculation. 
2.	In the formula editor, type **CAGR(**.
3.	Click a cell to specify the beginning value column. The column name will be automatically added to the formula in the editor.
4.	Type a comma **(,)** in the editor after the beginning value column, to spit the first and second argument.
5.	Click a cell to specify the ending value column.
6.	Type a comma in the editor after the ending value column to split the second and third arguments.
7.	Enter the number of years as the third argument, for example, 2.
8.	Type “)” to close the function. It should look something like this 
CAGR([Actual_2018], [Actual_2020], 2)
