## Comparison operators

| Operator  | Description                                                                                                                                                         |
| --------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| =         | Assignment operator. Assigns the value on the right hand side to the variable or cell on the left hand side.  Example  X = 10;  \@Amount[ItemID == "A"] = 25.6;     |
| \>        | Greater than operator. Checks if the value on the left side is greater than the value on the right side.  Example  20 \> 10 returns true.  10 \> 20 returns false.  |
| \>=       | Greater than or equal. Checks if the value on the left side is greater than, or equal to the value on the right side.                                               |
| \<        | Less than operator. Checks if the value on the left side is less than the value on the right side.  Example  20 \< 10 returns false.  10 \< 20 returns true.        |
| \<=       | Less than or equal operator. Checks if the value on the left side is less than, or equal to the value on the right side.                                            |
| ==        | Equals operator. Checks if the value on the left side is equal to the value on the right side.  Example  1 == 1 returns true.  1 == 2 returns false.                |
| !=        | Not equals operator. Checks if the value on the left side does not equal the value on the right side.  Example  1 != 1 returns false.  1 != 2 returns true.         |

## Logical operators

| Operator  | Description                                                                                                                                          |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- |
| &&        | Conditional AND operator. Performs a logical AND of its left and right operands.  The right operand is only evaluated if the left operand is true.   |
| \|\|      | Conditional OR operator. Performs a logical OR of its left and right operands.  The right operand is only evaluated if the left operand is false.    |

## Arithmetic operators

| Operator  | Description                                                                                                                                                                                                                      |
| --------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| \+        | Binary operator + for numeric types sums the operands.  Binary operator + also concatenates strings if one of the operands is a string. You can also use the CONCAT function to concatenate strings.  Example  1 + 2 returns 3.  |
| \-        | Binary operator – subtract the second operand from the first.  Example  2 – 1 returns 1                                                                                                                                          |
| \*        | The multiplication operator computes the product of its operands.  Example  2 \* 2 returns 4                                                                                                                                     |
| /         | The division operator divides its first operand by its second operand  Example  2 / 2 returns 1.                                                                                                                                 |
| %         | The modulus operator computes the remainder after dividing its first operand by its second operand.  Example  10 % 2 returns 0  

## Primary Operators

| Operator  | Description                                                                                                              |
| --------- | ------------------------------------------------------------------------------------------------------------------------ |
| . (x.y)   | Member access.  Example  "xyx".substring(…)                                                                              |
| X?.y      | Null conditional member access. Returns null if the left hand operand is null.  Example  X = null;  Y = X?.substring(…)  |

## Unary operators

| Operator  | Description                                              |
| --------- | -------------------------------------------------------- |
| \+ (+x)   | Returns the value of the operand                         |
| \- (-x)   | Numeric negation  Example  Y = -X;                       |
| ! (!x)    | Logical negation  Example  X = !true; (X becomes false)  |


## Other binary operators

| Operator  | Description                                                                                                                                                                                                                                                                                                                                                                                          |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| ??        | Null coalescing operator.  The ?? operator checks whether the value provided on the left side of the expression is null, and if so it returns an alternate value indicated by the right side of the expression.  If the value provided on the left side of the expression isn't null, then it returns the original value  Example:  null ?? "Hello" returns the string Hello.  0 ?? "Hello" returns 0  |
