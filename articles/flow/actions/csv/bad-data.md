# Bad data

When importing data from a CSV format, you often get bad data in form of badly formatted values, missing fields, or simply unexpected values.
In a large data set, bad values may constitute a small amount of data, making them hard to track down. 
By enabling **Error handling** behaviors in the [Data import options](configuration-properties/data-import-options.md), you can record the bad data encountered during a CSV import and investigate which rows and fields prevent a successful import.

Bad data is stored in the **BadData** collection of a CSV DataReader or CSV DataTable, and can be read as an `IEnumerable<BadDataRecord>` or as an IDataReader. This makes it easy to dump the information to a database table or a file for review.

The BadDataRecord has the following properties:

| Name          | Data type        | Description                                         |
|---------------|------------------|-----------------------------------------------------|
| RecordIndex   | Int32            | The index of the record / row in the CSV data set.  |
| RecordData    | String           | The raw record / row in the CSV data set.           |
| DebugInfo     | String           | Descriptive information about what caused the data to fail validation. |

<br/>

#### Example
To dump bad data to a SQL Server table, do the following:

1) Create a table with the following schema (You can name it whatever you like). Use the table as the **Destination table** in step 2) below.

```sql
CREATE TABLE [dbo].[BadData](
	[RecordIndex] [int] NULL,
	[RecordData] [nvarchar](max) NULL, -- Choose a text data type that fits the size of a row from your CSV file
	[DebugInfo] [nvarchar](max) NULL -- This field may contain the row data in addition to debugging information, so choose a data type accordingly
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
```

2) Add an [Insert data](../sql-server/insert-data.md) action to the Flow and choose the BadData collection as the data source.

![img](/images/bad_data_to_sql_server_example.png)