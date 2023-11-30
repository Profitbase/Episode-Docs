
# Conditional Cell Read Only state

You can specify a column to be read only, but if you need the read only state of cells to be set individually based on the contents of the grid (or by hard coded values), you must configure Cell Read Only Rules. The Cell Read Only Rules use the formula syntax to address and evaluate the read only state of cells.

*	**Name**

 The name of the rule. This property is used for management purposes only.

*	**Disabled**

 Specifies whether the rule is enabled or disabled. Mainly used for temporarily disabling rules while debugging or configuring the grid.

*	**Target**

 The address of the cells to mark as read only if the Statement fails (returns false).
 Cells are addressed using standard Eaze syntax. 

*	**Statement**

 The Eaze expression used for evaluating the read only state.
 The statement must return true if the cell should become read only, otherwise false.

>**Example**
>
>Set Qty to read only if Amount is greater than 100
>
    Target: @Qty[]
    Statement :@Amount[] > 100
>
>
>**Example**
>
>Set Qty cell to read only for all rows which have been saved to the database at least once.
>
    Target: @Qty[]
    Statement : @PBRowIdentity[] != -1

