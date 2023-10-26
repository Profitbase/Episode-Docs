Enable the **Column subtotals** option to add a **Total column** from the data model for each **Value column**. You will typically use this if you display periodic Values by month and need a **Year total** (e.g. Actual and Budget).

![Column subtotals](https://profitbasedocs.blob.core.windows.net/pbireportingmatrix/ColSubtotals.png)

### Column captions when you have multiple Value columns
If you have multiple Value columns, you get one Total column for each of them. For example, if you have added "Actual" and "Budget" to the Values bucket, you get one total for Actual and one total for Budget.  

To control the caption of each total column, you can use the **Value total label** field to specify the text that you want to display as the caption.  
You get the name of the Value column (for example "Budget") by using the **{{Value}}** token in the text. When a Value total column is rendered, the {{Value}} token will be replaced by the actual name of the Value field.

For example, suppose the Values bucket contains "Actual" and "Budget". By specifying ```{{Value}} total``` as the **Value total label**, the captions for the totals will be "Actual total" and "Budget total".

![Value total label](https://profitbasedocs.blob.core.windows.net/pbireportingmatrix/ColumnTotals_ValueTotalLabels.PNG)

***

### New in v6:

## Column subtotal placement 
Select if you want to show the total as the last column, or as the first column:
![image](https://user-images.githubusercontent.com/82056309/168269774-09d8cec2-1fdf-46ba-b255-8855643d75be.png)

![image](https://user-images.githubusercontent.com/82056309/168269801-6efae877-df0c-4eb1-ab2d-a60cd49ac1bc.png)
