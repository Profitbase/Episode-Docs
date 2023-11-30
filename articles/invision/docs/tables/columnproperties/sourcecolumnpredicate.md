
# Source Column Predicate


A JavaScript function expression, the name of a function defined in a Solution JavaScript, or a regex which returns a boolean value indicating whether a (template) column should be rendered for the data set column or not.

*If the predicate is a JavaScript function, the following arguments are passed:*


**Arguments:**

**colName**

The name of the column in the Data Set.

**colIndex**

The index of the column in the Data Set.

**rows**

All the rows in the Data Set.


>**Example**
>
>Using the following Source Column Predicate, a column will be rendered for all Data Set columns that starts with the character P.
>
    function(colName, colIndex, rows){
        return colName[0] === 'P'; 
    }


If the predicate is a regex, it will be evaluated agains the column names of the Data Set.

