---
title: "LoadMinMaxValues"
metaKeys: "LoadMinMaxValues"
folderOnly: "false"
pageIndex: 15
---

### LoadMinMaxValues

<br/>

```
LoadMinMaxValues(conditions : boolean);
```

<br/>

LoadMinMaxValues(…) is used for specifying whether min and max values should be (re)loaded during a LoadData Action for Form Elements supporting range constraint, for example, the Date Picker Form Element.
<br/>

#### Example 
>
```
LoadMinMaxValues(); // evaluates to true
LoadMinMaxValues(ItemID == "X-300"); // evaluates to true if ItemID equals X-300
```

