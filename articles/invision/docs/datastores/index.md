
### Data Stores

<br/>

Data Stores are the primary data repositories of your Solution. Data Stores should be used for storing the master data and processing results for your business modules, while Tables should contain configuration data for business rules and utility functions.

Data Stores are materialized as SQL Server tables and can be read and written to by any SQL script or process having the required permissions. Data is stored "as is", so you do not need to use an InVision API to read or write data to a Data Store. This makes it easy to integrate with other tools, such as Excel or a custom Web Service, to export and import data to and from InVision.

The table schema of a Data Store is configured by adding columns and setting up properties for each column. Constraints and data sources are defined by adding dimensions and fact to the setup, and binding columns from the (fact and dimension) data sources to the columns in the Data Store. By binding dimensions and facts to the table schema of a Data Store, you create a star schema.
<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/datastores.png)

<br/>

**You should consider binding dimensions to Data Stores when you want to make it easy to:**

1. Enable foreign key constraints

2. Create Worksheets with dropdown editors for selecting cell values (for example Accounts, Projects, Products, etc)

3. Create Worksheets where the data set presented to the end-user should be filtered by dimension.

4. Create Worksheets where you want to ensure identities only have access to data based on identity rights.

5. Use the Core Set function to (pre)populate the Data Store. 

6. Specify a mechanism used for resolving the Data Context when processing data using Data Flows in a Workflow context.

In addition to the core setup of the Data Store where you define the schema and how data is loaded and updated to the store, you can specify a range of features and behaviors which enable different kinds of applications of the Data Store. The features and behaviors include Rollover, Periodic Input, Core Set, and Transaction Pipeline.

<br/>

### See Also

- [How to's](./howto/index.md)

- [Creating Schema](./creatingschema.md)

- [Source Mapping](./sourcemapping.md)

- [Importing and Updating Data from Data Sources](./importingandupdting/index.md)

- [Data Update Configuration](./dataupdateconfig.md)

- [Exporting Data from InVision](./exportingdata.md)

- [Time Frame](./timeframe.md)

- [Core Set](./coreset.md)

- [Rollover](./rollover.md)

- [Periodic Input](./periodicimput.md)

- [Time Frame Measure Columns](./timeframemeasurecolumns.md)

- [Change Tracking](./changetracking.md)

- [Transaction Pipeline](./transactionpipeline.md)

- [Tracing Columns](./tracingcolumns.md)

<br/>

### Videos

- [Data Stores](../../videos/datastores.md)
