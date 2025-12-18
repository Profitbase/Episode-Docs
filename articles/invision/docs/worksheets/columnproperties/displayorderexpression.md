# Display Order Expression

Specifies a C# expression that is evaluated on the server before the layout is loaded.
The expression must return an integer value, which determines the display order of the column.
Columns with a defined expression are displayed before columns without an expression.

This value overrides the default schema layout.  

The expression supports both parameters and Directives.

<br/>

**Examples**

```
return 1;
```

```
return (int)Directive("@Object[Options].Lookup[{ \"ColumnId\":\"AccountID\" }][DisplayOrder]");
```

