# Get report data

Gets the raw data for a Hypergene Porfolio report in the specified supported format (JSON, CSV, XML or HTML).

> [!NOTE]
> Note that if you specify a format not supported by the report, data will be returned in the default format supported by the report. For example, if you ask for data in CSV format, but the report only supports returning data in JSON, you will get back data in a JSON format.

![img](/images/flow/portfolio-get-report-data.png)
**Example** ![img](../../../../images/strz.jpg)  
The example above illustrates how to import data from a Hypergene Portfolio report into a SQL Server table. It first fetches data in **CSV format** using the `Get report data` action, then converts it to a DataTable using the [Read CSV file as DataTable](../csv/read-csv-file-as-datatable.md) action and finally stores the data to SQL Server using the [Insert rows](../sql-server/insert-data.md) action. The Portfolio API returns data as a string, so we must do the DataTable conversion manually to get the data to a tabular format that SQL Server understands.

<br/>

## Returns
Returns data as a [string](https://learn.microsoft.com/en-us/dotnet/api/system.string) on the specified format (JSON, CSV, XML or HTML). Note that if you specify a format not supported by the report, data will be returned in the default format supported by the report. 

## Properties
| Name              |  Type             | Description                      |
|-------------------|-------------------|----------------------------------|
| Connection        | Required          | The [connection](./connection.md) to the Hypergene Portfolio subscription. |
| Report ID         | Required          | The id of the report to get data for. |
| Format            | Optional          | The preferred format you want data returned in. Options are `JSON`, `CSV`, `HTML` and `XML`, but all formats may not supported by all reports. You can select from a list of available formats when configuring this property. If you specify a format not supported by the report (for example using a variable), you will get data back in the default format supported by the report. |