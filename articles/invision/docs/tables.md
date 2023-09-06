---
title: "Tables"
metaKeys: "While Data Stores are the primary data repositories of a Solution, Tables are primarily used as utilities and for storing configuration data for business rules, Data Stores, Tables, SQL Server, script, required permissions, InVision API, integrate, tools, Excel, Web Service, schema, properties, column, sources, foreign key, constraints, Time Frame,  Periodic Input, Rollover, Transaction Pipeline Processing, Time Frame, configuration, Cell Adapter Ruleset, Distributer, component, Spawner, On Save, Worksheet, end user client, data validation, modifying data, sending messages"
folderOnly: "false"
pageIndex: 22
---

### Tables

While [Data Stores](datastores.md) are the primary data repositories of a Solution, Tables are primarily used as utilities and for storing configuration data for business rules.

Like Data Stores, Tables are materialized as SQL Server tables and can be read and written to by any SQL script or process having the required permissions. Data is stored "as is", so you do not need to use an InVision API to read or write data to a Table. This makes it easy to integrate with other tools, such as Excel or a custom Web Service, to export and import data to and from InVision.

See how to create a table, configure the table schema in the video section [here](../videos/tables.md).

Unlike Data Stores, Tables do not have data sources and you cannot apply foreign key constraints to Tables.

<br/>

### Time Frame

To enable features such as [Periodic Input](datastores/periodicimput.md), [Rollover](datastores/rollover.md), and [Transaction Pipeline](datastores/transactionpipeline.md) Processing, you need to set up the [Time Frame](./timeframe.md) configuration for a Setting. The Time Frame is the feature that all date-related information for Settings and Data Stores are derived from, which makes it a very important part of most InVision solutions.
Read more about the Time Frame feature [here](./timeframe.md).

<br/>

### Cell Adapter Ruleset

The [Ruleset](./datastores/transactionpipeline/celladapter/ruleset.md) configuration for the Transaction Pipeline Cell Adapter component. Read about the required configuration [here](./datastores/transactionpipeline/celladapter/ruleset.md).

<br/>

### Distributer Ruleset

The Ruleset configuration for the Transaction Pipeline Distributer component. Read about the required configuration [here](./datastores/transactionpipeline/distributer/ruleset.md).

<br/>

### Spawner Ruleset

The Ruleset configuration for the Transaction Pipeline Spawner component. Read about the required configuration [here](./datastores/transactionpipeline/spawner/ruleset.md).

<br/>

### On Save

InVision provides a way to hook into the process of saving Worksheets and Setting data from the end-user client. The hook lets you execute custom business logic such as data validation, modifying data, sending messages, and so on.
Read more about the On Save feature [here](./worksheets/onsave.md).

<br/>

### See Also

- [How to's](tables/howto.md)
- [Filters](tables/filters.md)
- [Layout](tables/layout.md)
- [Ranked Input](tables/rankedinput.md)


<br/>

### Videos

- [Tables](../videos/tables.md)
- [Creating Table - Basics](https://profitbasedocs.blob.core.windows.net/videos/Tables%20-%20Intro%20-%20creating%2C%20editing%2C%20table%20schema%2C%20columns%20and%20their%20properties.mp4)
- [Data Modified and Item Added Events](https://profitbasedocs.blob.core.windows.net/videos/Table%20Events%20-%20Data%20Modified%20and%20Item%20Added%20Events.mp4)
- [Cell Action Link Tapped Event](https://profitbasedocs.blob.core.windows.net/videos/Table%20Events%20-%20Cell%20Action%20Link%20Tapped.mp4)
