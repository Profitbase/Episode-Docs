---
title: "Parameters "
metaKeys: "Parameters "
folderOnly: "false"
pageIndex: 3
---

To receive input for execution, use Powershell parameters (**param**).

Parameters must be added at the very top of the script.
<br/>

**Example**

```
param (
 [Parameter (MANDATORY = $TRUE)][string] $parameter1,
 [Parameter(MANDATORY = $FALSE)][string] $parameter2
)
```
<br/>

You will find more about the subject in PowerShell Documentation [here](https://docs.microsoft.com/en-us/powershell/).


<br/>

#### Videos

- [PowerShell](../../videos/powershell.md)