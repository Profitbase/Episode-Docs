# Is Hidden

Specifies whether the column is hidden from the UI.

## Is Hidden Expression

A C# expression that is evaluated on the server before the layout is loaded. The expression must return a Boolean value. If the returned value is true, the column is hidden from the UI. 

This value overrides the **Is Hidden** property.
<br/>

**Example**

```
(bool)@viewByYear==true
```

