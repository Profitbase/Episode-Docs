
# Custom Rows

## How to add a Custom Row
We can add custom rows to the contents of the data grid by specifying the location relative to the actual rows loaded from the data source.  To create a custom row, you need to specify the ObjectId manually.   

The ObjectId must be unique for every custom row in the grid, and it must be a negative value starting at -1. 

The row data is specified as a JSON object.
Use the **ADDROWFIRST**, **ADDROWLAST**, **ADDROWBEFORE**, and **ADDROWAFTER** functions to add custom rows relative to the original rows of the data set.

<br/>


>**Example**
>
>Add a custom row as the last row of the grid which will show the sum of the column Amount:
>
>The data grid has two visible columns, "ProductName" and "Amount"
>
>**1)**	Define the custom row:
>
    AddRowLast({"ObjectId":-1, "ProductName":"Sum" });
>
>**2)**	Add a formula to calculate the sum of Amount (excluding the Sum cell):
>
    @Amount[ObjectId == -1] = SUM(@Amount[ObjectId != -1]);

<br/>

## Videos

* [Worksheet](../../videos/worksheet.md)
* [Custom Row](https://profitbasedocs.blob.core.windows.net/videos/Worksheet%20-%20Custom%20Row.mp4)