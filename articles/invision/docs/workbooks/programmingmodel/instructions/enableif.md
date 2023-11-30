# EnableIf(...)

<br/>


```
EnableIf(expression : boolean | Eaze expression)
```

EnableIf is used for conditionally enabling or disabling a UI element, for example a button. The function compares the left and right operand using the specified operator. EnableIf can be invoked in ExecuteExpression Actions on the object to enable or disable.
<br/>

**Parameter**  
``EAZE expression``	
>An Eaze expression returning a boolean value. You can use Workbook state variables, event context variables and filter references in the expression.

<br/>

**Example**

This example shows how to enable a button if the selected value of a filter exists at the leaf level. If it does not exist at the leaf level, the butto is disabled.
The expression is invoked in the ExecuteExpression Action of the button.

```
EnableIf(Filter("Filters","Department").SelectedValue.IsLeaf);
```

```
EnableIf(Filter("Filters", "Department").SelectedValue.Level >= 2 && _accountId == "A3000");
```

