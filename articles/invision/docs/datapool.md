---
title: "Data Pool"
metaKeys: "Data pool, Compound views, Synonyms, Browse Data, Join, Refresh, View Information,  Leave, SQL Server tables, processing, fact, dimension, create star schema, Create Worksheets, integrate, script, dimensions, Enable foreign key constraints, set, function, Flow, core setup, Rollover, Periodic Input, Core Set, Transaction Pipeline"
folderOnly: "false"
pageIndex: 7
---

### Data Pool

<br/>
A data pool is a collection of tables and views that serves as a data integration point.

It contains all data that developers want to expose from solutions. 

It can be implemented through:

- Compound views
- Synonyms
<br/>

![dtp](https://profitbasedocs.blob.core.windows.net/images/datapool1.png)

<br/>

### Compound view

<br/>

Data Stores and Views can join a shared **Compound View** together with other **Stores**/**Views** across different **Solutions** or [Work Process Versions](workprocess.md).

To edit Compound View settings, select a [Data Store](datastores.md) or [View](views.md) and switch to the Data Pool tab.


The name of the Compound View can consist of characters from **a-z/A-Z**, numbers **0-9**, and **underscore**.

<br/>

**Commands**

- **Join**: joins the Store or View to the given Compound View.
- **Leave (dropdown under Join)**: removes the Store or View from named view.
- **Refresh (dropdown under Join)**: refresh the status shown below the name.
- **View Information (dropdown under Join)**: brings up a dialog displaying details for the view.
- **Browse Data**: brings up a browser to view data in the Compound View.

<br/>

**Note**

> A Store or View can only be a member in one Compound View.

<br/>

### Synonym

A synonym can be applied to [Data Store](datastores.md), [Dimensions](dimensions.md) (linked and local.md), [Tables](tables.md), and [View](views.md).

Synonyms are using the Microsoft SQL Server synonym functionality with some additions.

To edit Synonyms, select one of the supported content types, and select the Data Pool tab.


The name of the Synonym can consist of characters from **a-z/A-Z**, numbers **0-9** and **underscore**.

<br/>

**Commands**

- **Take:** take the synonym for the given object.
- **Remove (dropdown under Take):** removes the object from named view.
- **Refresh (dropdown under Take):** refresh the status shown below the name.
- **Synonym Information (dropdown under Take):** brings up a dialog displaying details for the synonym.
- **Browse Data:** brings up a browser to view data for the synonym.

**Data Flow task for taking Synonym ownership**

To take Synonyms from a [Data Flow](dataflows.md), add the Take Synonym Ownership task to a Data Flow Item and add it to a Data Flow.

The argument is an identity to an object in a solution. This can be set to a parent node (folder, package, solution), and then Synonyms will be taken for all descendants.

<br/> 