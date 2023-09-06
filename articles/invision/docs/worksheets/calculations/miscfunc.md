---
title: "Misc Functions"
metaKeys: "Misc Functions, LHS, LHSVALUE, prop name, tmpl_foreach_operand, formula, operand template "
pageIndex: 14
---


``LHS()``
>Returns the object on the left side of the = sign. 
>
>**Example** 
>
>**LHS().ProductID** returns the product id of the object on the left side of the = sign of the row currently being evaluated. 
>
>**Example** 
>
>The following example shows how to calculate the Amount by multiplying the Quantity by Price specified in a different spreadsheet, matching by ProductID. 

```
@Amount[]= @Qty[] * @Price list!Price[ProductID == LHS().ProductID]
```

``LHSVALUE(prop name)``
>Returns the value of the specified property of the object on the left side of the = sign 
>
>**Example** 
>
>**LHSVALUE(AccountID)** returns the account id of the object on the left side of the = sign of the row currencly being evaluated.

``tmpl_foreach_operand(formula, operand template :string)``

>Accepts a formula expression and an operand template, and returns an AST representing a valid spreadsheet formula. The AST can be evaluated by the EVAL function and returns a value.
 >
 >The **#LHSCOL** template token is replaced by the name of the column on the left hand side of the expression.  
 >The **#OP** template token is replaced by the current operand token from the formula parameter. 
>
>**Example**
>
> Formula = "L01 + L02" and left hand side column name is "Total", Given the expression: 
> ```
> tmpl_foreach_operand(Formula, "#LHSCOL[LineID == \"#OP\"]")
> ```
>  will return an AST equal to the AST of this formula: 
> ```
> @Total[] = @Total[LineID == "L01"] + @Total[LineID == "L02"] 
> ```
> 
> **Example** 
> 
> Formula = "L01 + L02": 
> ```
> @Total[LineID == "L03"] =EVAL(tmpl_foreach_operand(Formula, "#LHSCOL[LineID ==\"#OP\"]"));
> ```
> Will be translated into an AST and executed like a formula equivalent to:
> ```
> @Total[LineID == "L03"] = @Total[LineID == "L01"] + @Total[LineID == "L02"];
> ```