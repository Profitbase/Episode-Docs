
# Row Styling

You can style rows individually by creating CSS styles and assigning them to rows writing Eaze expressions. 

>**Example**
>
>Suppose you create a CSS class named "ImportantRowStyle" and want to apply the style to all rows where ProductID equals ‘XYZ’. To apply the style to the rows, use the following syntax:
>
    SETROWSTYLE(ProductID == "XYZ", "ImportantRowStyle");
>
>**Example**
>
>Suppose you have created a custom row, and want to apply a style, "CustomRowStyle", to the row. When you created the custom row, you had to specify the value for ObjectId property (for example -1). To apply a style to the custom row, use the ObjectId to address the custom row using the following syntax:
>
    SETROWSTYLE(ObjectId == -1, "CustomRowStyle");


## Styling the Summary Row

The summary row is a special row that is pinned to the bottom of the spreadsheet by InVision. In order to style this row, you can use SetRowStyle(…) just like with any other row in combination with the IsSummaryRow(row) and GetCallContextRow() functions for determining whether a row is the summary row.

>**Example**
>
    SetRowStyle(IsSummaryRow(GetCallContextRow()), "css class");

