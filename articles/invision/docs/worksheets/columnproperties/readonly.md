# Read Only

Specifies whether the column cannot be edited by the user.

## Read Only Expression

Specifies a C# expression that is evaluated on the server before the layout is loaded. The expression must return a Boolean value. If the returned value is true, the column is not editable, unless a Data Rule overrides this value.

This value overrides the **Read Only** property.

<br/>

**Example**

```
(bool)viewByYear==true
```

