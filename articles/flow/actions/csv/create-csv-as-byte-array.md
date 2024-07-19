# Create CSV as byte array

Creates a CSV file from a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) or [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) and returns the result as a byte array.


<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/byteArray.png)

<br/>


## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title       |  Required |        |
| Source | Required  | Select the source for data. |
| Header row |  |  |
| Column delimiter | Default | Default is coma. |
| Row delimiter | Default | Default is \\r\\n.  |
| Quote character | Default | Default is double quote("). |
| Quote all fields |  |  |
| Date format | Default | Default is dd.MM.yyyy. |
| Number decimal separator | Default | Default is (.). |
| Result variable name | Optional |  |
| Description | Optional |  |