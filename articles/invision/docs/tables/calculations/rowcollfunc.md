
# Row Collection Functions


``ADDROWFIRST(JSON object)``

>Adds a row at the beginning of the data set bound to the grid. 
>
>**Example** 
```
ADDROWFIRST({"ObjectId" :-1, "AccountID"  
:"F100", "ProductID" :"P-001" ,"Total" :0,"P01" :-3000})
```

``ADDROWLAST(JSON object)``

>Adds a row at the end of the data set bound to the grid. 
>
>**Example** 
```
ADDROWLAST({"ObjectId" :-1, "AccountID"  
:"F100", "ProductID" :"P-001", "Total" :0, "P01" :-3000})
```

``ADDROWAFTER(address expression, JSON object)``

>Adds a row after the first row matching the address expression. 
>
>**Example** 
>
>This example shows how to add a row after the first row where AccountID equals A3000. 
```
ADDROWAFTER(AccountID == "A3000",  
{"ObjectId" :-1,"AccountID" :"F100", "ProductID" :"P-001", "Total" :0, "P01" :-3000})
```

``ADDROWBEFORE(address expression, JSON object)``

>Adds a row before the first row matching the address expression. 
>
>**Example** 
>
>This example shows how to add a row before the first row where AccountID equals A3000 and Amount > 5000 
```
ADDROWBEFORE(AccountID == "A3000" && Amount > 5000,  
{"ObjectId" :-1,"AccountID" :"F100","ProductID" :"P-001","Total" :0,"P01" :-3000})
```

``IsSummaryRow(…)``
>Returns true if the row in the current call context is a summary row. 
>
>**Example** 
>
```
IsSummaryRow(GetCallContextRow()) 
```
>Returns true if the row currently being evaluated by the Eaze runtime is a summary row.

``IsRowLocked(…)``
>Returns true if a row is locked. 
>
>**Example** 
```
IsRowLocked(GetCallContextRow())
```