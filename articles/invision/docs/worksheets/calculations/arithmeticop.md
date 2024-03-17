
# Arithmetic Operators

``Operator +`` 

Binary operator + for numeric types sums the operands. Binary operator + also concatenates strings if one of the operands is a string. You can also use the CONCAT function to concatenate strings. 

**Example** 
```
1 + 2 returns 3.
```

``Operator -``	
Binary operator – subtract the second operand from the first. 

**Example** 
```
2 – 1 returns 1. 
```

``Operator *`` 

The multiplication operator computes the product of its operands. 

**Example**
```
2 * 2 returns 4.
```

``Operator / ``

The division operator divides its first operand by its second operand.  
 
**Example** 
```
2 / 2 returns 1.
``` 

``Operator %``

The modulus operator computes the remainder after dividing its first operand by its second operand. 

**Example** 
```
10 % 2 returns 0.
```


___

**Example 1**

This example shows how to calculate Amout for every row in the data grid by multiplying the Price and Qty properties on the row.

```
@Amount[] = Price * Qty;
```

**Example 2**

This example shows how to calculate Amount for a specific row in the data grid, where ProductID = XP-5000.

```
@Amount[ProductID == "XP-5000"] = @Price[ProductID == "XP-5000"] * @Qty[ProductID == "XP-5000"];
```
