---
title: "$PbRunContext"
metaKeys: "$PbRunContext, system variable, script execution, $PbRunContext.WorkDir, Profitbase.IO, $PbRunContext.SolutionId, [Profitbase.Data.SqlScript]::Execute, $PbRunContext.LogHandle, [Profitbase.PS.PsScript]::Execute, $PbRunContext.TaskId, [Profitbase.PS.PsScript]::Execute, non data flow execution,  "
pageIndex: 2
---

# $PbRunContext

<br/>

## $PbRunContext (system variable)

The ``$PbRunContext`` system variable is instantiated and set for each script execution. It contains useful information that can be utilized.

<br/>


> [!NOTE]
> Profitbase may change the content of the ``$PbRunContext`` at any time.


> [!NOTE]
> From InVision platform version 2022.3, the ``$pbRunContext`` is removed as argument in functions supplied by Profitbase. Remove this argument on upgrade and check the function name. Functions using this argument will not work after v.2022.4.

<br/>

**Internal use:**

- The ``$PbRunContext.WorkDir`` value is required when using ``Profitbase.IO`` functions.
  <br/>

- The ``$PbRunContext.SolutionId`` value is required when calling ``[Profitbase.Data.SqlScript]::Execute``.
  <br/>

- The ``$PbRunContext.LogHandle`` value is used when calling ``[Profitbase.PS.PsScript]::Execute`` from **Designer/WebApp** context.
  <br/>

- The ``$PbRunContext.TaskId`` value is used when calling ``[Profitbase.PS.PsScript]::Execute`` from **Data Flow/Worker** context.
  <br/>


**Example 1 non data flow execution:**

```
WorkDir           : C:\InVision\WebApp\Profitbase.Invision.WebApp\PwshTempFolders\cc1604bb-42c
SolutionId        : SHHealthChecksMmrJQlemljTJb9SZbiGC
UserId            : domainname\user
Language          : en-US
ConnectionString  : Data Source=dbsrv;Initial Catalog=pbInvision_Test;Integrated Security=True;
DataFlowExecution : False
LogHandle         : 84c01459-b754-4d2b-aafb-49c99dd08319
TaskId            : 
DataFlowId        : 
ParentLogItemId   : 
DataFlowStepId    : 
DataFlowItemId    :
```

<br/>

**Example 2 data flow execution:**

```
WorkDir           : C:\InVision\WebApp\Executables\Worker\PwshTempFolders\80b6d7f5-6abe-42d8
SolutionId        : SHHealthChecksMmrJQlemljTJb9SZbiGC
UserId            : domainname\user
Language          : en-US
ConnectionString  : Data Source=dbsrv;Initial Catalog=pbInvision_Test;Integrated Security=True;
DataFlowExecution : True
LogHandle         : 
TaskId            : fd371b0a-edff-47fb-b5cb-ed757222189d
DataFlowId        : 0b942eba-f035-48dc-bb38-d8655ebf452e
ParentLogItemId   : entry_1b98165d-35a2-4c0b-922e-7ac8a0cf2f25
DataFlowStepId    : 9bf09f3a-a239-46f9-9b87-957788c1d612
DataFlowItemId    : d21119b2-d73e-453c-828b-b8fe7df424f9
```