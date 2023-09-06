---
title: "Command Line"
metaKeys: "Scheduled execution, parameterized, Data Flows, scheduler, command line,  SQL Server Agent, "
pageIndex: 1
---


### Execution of Data Flows using dfcmdutil.exe

**dfcmdutil.exe** is a command-line util which lets you execute Data Flows. It is a standalone application that can be run from any server having internet or intranet access to call the InVision Data Flow Exection API *dfcmdutil.exe* will start a Data Flow and wait for its completion.

**Syntax**

*dfcmdutil -run < data Flow Id > -url < api base url > -apikey < api key >*

**Example**

```
dfcmdutil -run d5d7bf89-5a14-4746-a41a-ab2aa6ffa14b -url http://domain.com/InVision -apikey dd63a1ad-60eb-4066-8d71-1721007437b4
```

### Videos

* [Data Flow](../../../videos/dataflows.md)
* [Execute Using dfcmdutil Command Line Tool](https://profitbasedocs.blob.core.windows.net/videos/Data%20Flow%20-%20Execute%20using%20dfcmdutil%20command%20line%20tool.mp4)
