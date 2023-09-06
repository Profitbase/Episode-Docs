---
title: "Profitbase.PS.PsScript.Execute"
metaKeys: "Profitbase.PS.PsScript.Execute, [Profitbase.PS.PsScript]::Execute, $results = [Profitbase.PS.PsScript]::ExecuteByName($scriptName, $parameters), $results = [Profitbase.PS.PsScript]::ExecuteById($scriptId, $parameters), PSDataCollection<PSObject>, Executes the PowerShell Script defined in the solution, "
pageIndex: 5
---

These functions use Powershell Scripts stored in InVision (not on the disk). Scripts can be addressed by their Name or their Id (contentId). This feature meets the need to execute a script without requiring access to the disk.

The following functions are obsolete and must be changed before upgrading to platform version 2022.4:

`[Profitbase.PS.PsScript]::Execute`

The following functions are available from platform version 2022.3+:

`$results = [Profitbase.PS.PsScript]::ExecuteByName($scriptName, $parameters)`

`$results = [Profitbase.PS.PsScript]::ExecuteById($scriptId, $parameters)`

Executes the PowerShell Script defined in the solution. The result will be of type `PSDataCollection<PSObject>`.

**Example**

```powershell
[Profitbase.PS.PsScript]::ExecuteByName('posh script with 2 params',
'Continue', 'my special output message.')
```
