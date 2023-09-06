---
title: "Rollover"
metaKeys: "Rollover, periodic input, Periodic input, Rollover configuration, Data Flow for executing a rollover, Time Frame Measure Columns "
pageIndex: 5
---

Data Stores and Settings configured for periodic input using [Time Frame](../timeframe.md) and [Time Frame Measure Columns](https://profitbasedocs.blob.core.windows.net/videos/Data%20Store%20-%20Time%20Frame%2C%20Time%20Frame%20Columns%20and%20Rolling%20Forecast.mp4) can be rolled over to a new period. The rollover is performed by executing a [Data Flow](../dataflows.md) running one or more rollover tasks. The rollover tasks expect the Settings, [Data Stores](../datastores.md) and/or Data Store Groups to roll forward and the number of periods to roll forward to be passed as arguments.

<br/>

**The following must be set up in order to perform a Data Store or Setting Rollover:**

*	[Time Frame](../timeframe.md)
*	[Periodic input](../datastores/periodicimput.md) 
*	[Rollover configuration](../datastores/rollover.md)

<br/>

### Videos

* [Time Frame, Time Frame Columns and Rolling Forecast](https://profitbasedocs.blob.core.windows.net/videos/Data%20Store%20-%20Time%20Frame%2C%20Time%20Frame%20Columns%20and%20Rolling%20Forecast.mp4)


