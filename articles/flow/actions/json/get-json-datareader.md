# Get JSON DataReader

This action creates an [IDataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) that converts a JSON document to a tabular format (row and columns).
Typical use cases include inserting a JSON document into a relational database table as rows and columns, or converting JSON into other tabular formats such as Excel or Parquet files.

![img](/images/flow/json-get-json-datareader.png)

## Returns
[IDataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) providing a forward-only stream of rows and columns from a JSON document.

## Properties

| Name                     | Type                 | Description                                |
|--------------------------|----------------------|--------------------------------------------|
| JSON                     | Required             | A string or byte array containing data in a valid JSON format. |
| [Schema mapping](#schema-mapping)           | Optional             | Enables manually defining the mapping between JSON properties and column names, including data types. |
| DataReader variable name | Required             | The name of the DataReader that this action returns. You may change the name to better convey what data the DataReader contains, for example `customers` or `orders`. | 

<br/>

## Details

JSON (JavaScript Object Notation) is a lightweight data-interchange format. It is easy for humans to read and write, and it is easy for machines to parse and generate.  
JSON is built on two structures:
 - A collection of **name/value pairs** called `properties`. In various languages, this is realized as an object, record, struct, dictionary, hash table, keyed list, or associative array.
 - An ordered **list of values**. In most languages, this is realized as an array, vector, list, or sequence.

In addition, JSON has the following characteristic:
- JSON may contain **nested objects**
- JSON data **does not** include information about **data types**
- JSON can represent values as `string`, `numbers`, and `booleans` (true / false) and `null`. Dates are represented as strings.

When a JSON document is parsed by the DataReader, it converts `each collection of properties (name/value pairs)` to a `row`, where each property represents a column and value (cell).
The _data type_ of the value is inferred from the representation of the value in the JSON document (string, number, etc). If a value is `null`, the data type cannot be inferred. 

##### Example
The example below shows how a JSON document contining two objects in an array is converted to a table. 

```json
[{
   "customerId": 1234,
   "firstName": "Luke",
   "lastName": "Skywalker",
   "subscriptionStart": "2024-01-13T12:03:15",
   "balance": 555.30,
   "isActive": true,
   "securityCode": null
},
{
   "customerId": 5678,
   "firstName": "Darth",
   "lastName": "Vader",
   "subscriptionStart": "2021-02-14T18:00:00",
   "balance": -156.00,
   "isActive": true,
   "securityCode": null
}]
```

The JSON above is converted to the following table.   


| customerId         | firstName     | lastName      | subscriptionStart    | balance     | isActive   | securityCode     |
|--------------------|---------------|---------------|----------------------|-------------|------------|------------------| 
| 1234               | Luke          | Skywalker     | 2024-01-13T12:03:15  | 555.30      | true       | null             |
| 5678               | Darth         | Vader         | 2021-02-14T18:00:00  | -156.00     | true       | null             |

---

> [!NOTE]
> The JSON documents must have a value format, meaning it must be a singel object starting and ending with curly brackets (`{` and `}`), or a collection of objects, starting or ending with square brackets (`[` and `]`).

### Nested objects
JSON may contain nested objects, such as Person and Address. When the DataReader encounters a nested object, it flattens the structure, using underscores ('_') to delimit each level.

##### Example
The example below shows how a JSON document contining nested objects (`address`) are flattened to a table. 

```json
[{
   "customerId": 1234,
   "firstName": "Luke",
   "lastName": "Skywalker",   
   "address": {
    "country": "Norway",
    "city": "Stavanger",
    "zip": 4016
   }
},
{
   "customerId": 5678,
   "firstName": "Darth",
   "lastName": "Vader",   
   "address": {
    "country": "Norway",
    "city": "Sandnes",
    "zip": 4313
   }
}]
```

The JSON above is converted to the following table. Note that the nested object `address` is flattented.  

| customerId         | firstName     | lastName      | address_country      | address_city  | address_zip   | 
|--------------------|---------------|---------------|----------------------|---------------|---------------|
| 1234               | Luke          | Skywalker     | 2024-01-13T12:03:15  | 555.30        | true          |
| 5678               | Darth         | Vader         | 2021-02-14T18:00:00  | -156.00       | true          |

---

### Schema mapping

When the DataReader reads the JSON document, it infers the column names and performs a best-attempt to infer the data types for each property. If it cannot infer the data type, it will make a guess based on what the value can be converted to. However, because JSON does not separate between decimal and non-decimal numbers, and dates and strings, you may sometimes get an error when trying to send the data to a database or API because the data types does not match what's expected. 
If this happens, you must define the Schema mapping and specify the data type for each each property explicitly. 

You can also use the `Schema mapping` to override how a JSON property is mapped to a `column name`.  
For example, if you want to map the JSON property `lastName` to column name `Surname`, you can configure this in the Schema mapping.

![img](/images/flow/json-get-json-datareader-schema-mapping.png)

<br/>

##### Column mapping for nested objects
In a JSON document, relationships between nested objects are represented using a dot ('.'), for example `address.country`. By default, the DataReader converts this to `address_country` because using a `.` will fail when trying to save the data to most target systems. If you want to use a different column name for nested objects, you can configure a mapping for this like shown below.

| JSON path        | Column name     | Data type          |
|------------------|-----------------|--------------------|
| address.country  | Country         | string             |




