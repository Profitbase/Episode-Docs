
# Caption Formatter

A JavaScript function expression or the name of a function defined in a Solution JavaScript which returns the caption for the column. The following arguments are passed to the function:

**Arguments:**

**colName**

The name of the column in the Data Set.

**colIndex**

The index of the column in the Data Set.

**rows**

All the rows in the Data Set.


>**Example**
>
>Using the following Caption Formatter receives a datetime string as the column name, and returns a formatted value to be displayed as the caption.
>
    function(colName, colIndex, rows){		
        return moment(colName).format('MM-YYYY');
    }


