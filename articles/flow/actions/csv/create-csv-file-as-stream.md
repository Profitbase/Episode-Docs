# Create CSV file as stream

Creates a CSV file from a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) or [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) and returns the result as a [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream).

![img](https://profitbasedocs.blob.core.windows.net/flowimages/create-csv-as-stream.png)

<br/>

## Properties

| Name                     | Type     | Description                 |
| ------------------------ | -------- | --------------------------- |
| Title                    |    Optional |  The title for the create action.  |
| Source                   | Required | Specifies the source of the data, which can either be a DataTable or DataReader. |
| Header row               | Default  | If true, the first row in the generated CSV file is a header row, containing column names. Default is true.             |
| Column delimiter         | Default  | The delimiter that separates the fields on each row. The default value is , (comma).           |
| Row delimiter            | Default  | The character or characters that separate rows in the data file. Default is \r\n (carriage return and line feed). This is commonly used to separate lines in Windows environments. Other options might include \n (newline), used in Unix/Linux environments, or \r, used in older Mac OS formats.          |
| Quote character          | Default  | The character used to quote fields. The default value is " (double quote). |
| Quote all fields         | Default  | Default is false. If true, all fields in the data set will be enclosed within the quote character, regardless of whether they contain special characters. If false, only fields with special characters (like delimiters or newline characters) will be quoted.           |
| Date format              | Default  | The format used for any date values in the data set. The default value is yyyy-MM-dd (e.g., 2024-01-31 for January 31, 2024). The format follows standard date formatting conventions where MM is the two-digit month, dd is the two-digit day, and yyyy is the four-digit year. You can customize this to other formats like MM/dd/yyyy based on your region or requirements.      |
| Number decimal separator | Default  | Defines the character used to separate the integer part from the fractional part of a decimal number. The default is . (period), commonly used in US English. Other locales might use , (comma) as the decimal separator, especially in European countries (e.g., 123,45).            |
| Result variable name     | Optional | The name of the variable you can use to reference the Stream in other actions.                        |
| Description              | Optional | Additional notes or comments about the action or configuration. |

<br/>

## Returns

[Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream)
<br/>

[!INCLUDE [](__videos.md)]