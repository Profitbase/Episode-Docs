
# AppVariables in Formulas

AppVariables enable you to use Workbook variables in spreadsheet formulas. This is useful if you have some constant or other value that is set outside the spreadsheet that you want to use in your formulas.

You can read the value of a Workbook variable by calling AppVariables.getValue("variable name") or reading the value directly as a property from the AppVariables object : AppVariables.TheVariable.

>**Example**
>
>Suppose you have assigned a value to the variable Factor in your workbook, you can get the value of Factor in your formula like this:
>
    @Amount[] = @TotalForce[] * AppVariables.getValue("Factor");
>
>or 
>
    @Amount[] = @TotalForce[] * AppVariables.Factor


**AppVariables.getValue("X") vs AppVariables.X**

You need use the getValue(…) function rather than accessing the property if your variable name contains white spaces.

For example, if your variable is called   @Var[My Variable], using AppVariables.@Var[My Variable] will not work because a property name cannot contain whitespace and [] characthers. Instead, you would need to use AppVariables.getValue("@Var[My Variable]");

**Executing formulas after an AppVariable has been changed**

If you modify an AppVariable outside of a Worksheet or Setting, (for example from a Form Element), and that AppVariable is used in a formula, you need to invoke the RecalcAction of the Worksheet of Setting.
For example, if you're entering some value into a Form element, and you want to trigger a recalc based on the new value, you need to execute the **RecalcAction** from the **SelectionChanged** event of the Form Element.
