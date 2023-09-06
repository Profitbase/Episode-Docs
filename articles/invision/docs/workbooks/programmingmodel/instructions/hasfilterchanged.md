---
title: "HasFilterChanged"
metaKeys: "HasFilterChanged, "
folderOnly: "false"
pageIndex: 10
---

### HasFilterChanged(...)

<br/>


```
HasFilterChanged() : boolean
```

<br/>

Can be called in the context of a LoadData Action of a Worksheet, Setting or Report to determine if one or more of the bound filters have changed since the last time data was loaded. This function will also return true the first time it’s called when no filters has previously been selected.

<br/>

**Example**

This example shows how to specify whether or not to load data in a LoadData Action for a Worksheet by using the ExecuteIf-function.
LoadData will only execute if the page hosting the Worksheet is active, and if the filter has changed since the last time data was loaded.

```
ExecuteIf(IsHostPageActive() && HasFilterChanged());
```



