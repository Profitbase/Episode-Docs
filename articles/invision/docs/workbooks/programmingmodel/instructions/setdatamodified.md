---
title: "SetDataModified"
metaKeys: "SetDataModified"
folderOnly: "false"
pageIndex: 26
---

### SetDataModified

<br/>

```
SetDataModified(condition : boolean);
```

<br/>

**SetDataModified(…)** can be called in Recalc actions for Worksheets and Settings. 

By calling **SetDataModified(true)** from Recal actions, you can set the modified state of the spreadsheet component to true manually. 

This is useful if you modify the data of a spreadsheet from outside the spreadsheet itself, and you want the changes to be saved to the database.