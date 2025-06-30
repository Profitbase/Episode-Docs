# JsonDataReader

###### Namespace: Profitbase.Flow.Data.Analysis

Reads and flattens a JSON string as a sequence of rows. The JsonDataReader makes it easy to flatten and read JSON as a sequence of rows, or convert JSON to tables.  

Implements [IDataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) [IDataRecord](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatarecord)

#### Example 1 - Read JSON as a sequence of rows

This example shows how to read an array of JSON objects using the JsonDataReader, and get the value of each property using the `Get[Type](...)` methods.

```csharp
var json = """
[
    {
        "name": "John",
        "age": 30,
        "address": {
            "city": "New York",
            "street": "Broadway"
        }
    },
    {
        "name": "Jane",
        "age": 33,
        "address": {
            "city": "Los Angeles",
            "street": "Victory Boulevard"
        }
    }
]
""";

var jsonReader = new JsonDataReader(json);
while(jsonReader.Read())
{
    // Get values by property index
    string name = jsonReader.GetString(0);
    int age = jsonReader.GetInt32(1);

    // Get values by property name
    string city = jsonReader.GetString("address_city"); // Nested object properties are separated by underscores.
    string street = jsonReader.GetString("address_street");
}
```

#### Example 2 - Convert a JSON string to a DataTable

This example shows how to convert a JSON string to a DataTable using the JsonDataReader. 
The schema is automatically inferred based on the JSON string. 

```csharp
var json = """
[
    {
        "name": "John",
        "age": 30,
        "address": {
            "city": "New York",
            "street": "Broadway"
        }
    },
    {
        "name": "Jane",
        "age": 33,
        "address": {
            "city": "Los Angeles",
            "street": "Victory Boulevard"
        }
    }
]
""";

var jsonReader = new JsonDataReader(json);
DataTable dataTable = jsonReader.ToDataTable();
```

<br/>
<br/>

## Working with schemas and data types

JSON only supports the following primitive data types: `String`, `Boolean`, `Date`, and `Number`. This differs from most programming languages and databases, which use more granular data types. As a result, explicit data type mappings are often needed when interfacing JSON with other technologies.  
When loading JSON using the JsonDataReader, you have the option to _explicitly_ specify the schema and data types to use, or let JsonDataReader _infer_ the information based on the contents of the JSON document.

### Inferred schema (No schema defined)

#### Data types
If no schema is defined, JsonDataReader will make a best effort attempt to infer the data types of each property based on their values. Data types are inferred as follows:

- Boolean values: The only valid boolean values in JSON are `true` and `false`, so JsonDataReader will infer the data type for boolean properties automatically.
- Numeric values: Based on the size and whether or not the number has decimals, JsonDataReader infers the data type as an `Int32`, `Int64`, `double` or `decimal` - in that order. 
- Strings values: When JsonDataReader encounters a string property, it checks whether or not the string has a `date` format. If the string has a valid date format, the data type will be either `DateTime` of `DateTimeOffset` based on the precision of the date string. If the string does not have a valid date format, the data type will be `string`.
- Date / DateTime values: Same as for string values (above).

> [!NOTE]
> If a property value is `null`, JsonDataReader cannot infer the data type of a property. To handle this case, you can implement the [OnResolveType](#example---using-onresolvetype-for-data-type-inference-override) callback to specify the data type explicitly.

#### Column names
If no schema is defined, JsonDataReader will infer the column names based on the property names in the JSON document. Neste objects will be separated by underscores ("_").

The JSON 
```json
{"name": "John", "age": 35, "dateOfBirth": "1985-12-03"}
``` 
returns rows on the following format:  

| name    | age    | dateOfBirth    |
|---------|--------|----------------|
| John    | 35     | 1985-12-03     |

If you have a nested object, for example   

```json
{
    "name": "John", "age": 35, "dateOfBirth": "1985-12-03", 
    "address": {
        "city": "London",
        "street": "Brick Lane"
    }
}
```  
the output will be:  

| name    | age    | dateOfBirth    | address_city  | address_street  |
|---------|--------|----------------|---------------|-----------------|
| John    | 35     | 1985-12-03     | London        | Brick Lane      |

<br/>
<br/>

### Explicitly configured schema 

You can explicitly configure the schema for the JsonDataReader through the `Schema` property of a JsonDataReader instance. This lets you map each JSON property name to a column name, and also specify the data type for each column.
When the schema and data types are specified explicitly, JsonDataReader will automatically convert the property values to the correct data type when parsing the JSON document.

> [!NOTE]
> If you specify a schema using MapJsonProperty(...) as shown in the example below, JsonDataReader will ignore all other fields in the JSON document.

#### Example - Configure JsonDataReader schema

The following example shows how to configure the schema JsonDataReader should use. Note that the lower case JSON properties are mapped to Pascal-cased column names, and that the nested properties under `address` are mapped to `City` and `Street` respectively.  

```csharp
var json = """
{
    "name": "John",
    "age": 30,
    "address": {
        "city": "New York",
        "street": "Broadway"
    }
}
""";

var reader = new JsonDataReader(json);
reader.Schema
    .MapJsonProperty("name", "Name", typeof(string))
    .MapJsonProperty("age", "Age", typeof(int))
    .MapJsonProperty("address.city", "City", typeof(string))
    .MapJsonProperty("address.street", "Street", typeof(string));

DataTable table = reader.ToDataTable();

/*
Output table is
| Name         | Age         | City        | Street       |
|--------------|-------------|-------------|--------------|
| ...          | ...         | ...         | ...          |
*/
```

<br/>
<br/>

### Lazy / On-demand data type inference

If you are happy with how the JsonDataReader infers the schema, but simply needs to override how one (or more) data types are inferred, you can specify the OnResolveType callback and let JsonDataReader know which data type specific properties should have.

#### Example - Using OnResolveType for data type inference override

The example below shows how to override how JsonDataReader infers the data type of the `weight` property by specifying the OnResolveType callback.

```csharp

var json = """
    {
    "name": "John",
    "age": 30,
    "city": "New York",
    "isStudent": false,
    "dateOfBirth": "1990-01-01T00:00:00",
    "weight": 70
    }
    """;

var reader = new JsonDataReader(json);
reader.Schema.OnResolveType = (propertyName) =>
{
    return propertyName switch
    {   
        "weight" => typeof(double), // We want weight to always be a decimal number, even if the value in the JSON document has no decimals.
        _ => null // Let JsonDataReader infer the data type for the other properties.
    };            
};

var dataTable = reader.ToDataTable();
```

## Properties

| Name          | Type                                                | Description                             |
|---------------|-----------------------------------------------------|-----------------------------------------|
| Schema        | [JsonDataReaderSchema](json-data-reader-schema.md)  | Optional. Specifies the schema used by the JsonDataReader. |       
| FieldCount    | [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32) | Returns the number of fields in the reader. Note that Read() must be called first if Schema is not defined. | 

## Methods

| Name               | Description                                                         |
|--------------------|---------------------------------------------------------------------|
| ToDataTable()      |  Returns the JSON documents as rows and columns in a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable).  |
| GetName(int columnIndex)       | Gets the column name of the specified column index.       |
| GetOrdinal(string columnName)  | Gets the column index of the specified column name.       |
| GetBoolean(int columnIndex)    | Gets the value of the specified column as a Boolean.                |
| GetBoolean(string columnName)  | Gets the value of the specified column as a Boolean.                |
| GetByte(int columnIndex)       | Gets the value of the specified column as a byte.                   |
| GetByte(string columnName)     | Gets the value of the specified column as a byte.                   |
| GetInt32(int columnIndex)      | Gets the value of the specified column as a 32-bit signed integer.    |
| GetInt32(string columnName)    | Gets the value of the specified column as a 32-bit signed integer.    |
| GetInt64(int columnIndex)      | Gets the value of the specified column as a 64-bit signed integer.    |
| GetInt64(string columnName)    | Gets the value of the specified column as a 64-bit signed integer.    |
| GetDecimal(int columnIndex)      | Gets the value of the specified column as a [Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal). |
| GetDecimal(string columnName)    | Gets the value of the specified column as a Decimal.                |
| GetDouble(int columnIndex)      | Gets the value of the specified column as a [Double](https://learn.microsoft.com/en-us/dotnet/api/system.double). |
| GetDouble(string columnName)    | Gets the value of the specified column as a Double.                |
| GetDateTime(int columnIndex)    | Gets the value of the specified column as a [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime).              |
| GetDateTime(int columnName)     | Gets the value of the specified column as a DateTime.              |
| GetDateTimeOffset(int columnIndex)    | Gets the value of the specified column as a [DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset).              |
| GetDateTimeOffset(int columnName)     | Gets the value of the specified column as a DateTimeOffset.     |
| GetString(int columnIndex) | Gets the value of the specified column as a string.    |
| GetString(int columnName)  | Gets the value of the specified column as a string.    |
| GetValue(int columnIndex)  | Gets the value of the specified column in its native format.    |
| GetValue(string columnName)  | Gets the value of the specified column its native format.     |
| Read()                     | Advances the reader to the next result. Returns `false` when there is no more data to process. |
