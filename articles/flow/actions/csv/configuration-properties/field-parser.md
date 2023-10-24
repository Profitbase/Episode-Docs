# Field parser

Use the Field parser to modify the value of a field being imported from a CSV row. The field parser function returns the text value that gets imported. If the field is mapped to a column having a non-string data type, the returned text must be convertible to the target column data type as defined in [Column mappings](column-mapping.md).

The Field parser function has the following signature:

```csharp
public static string? ParseFieldValue(string? text, int fieldIndex, FieldParserContext context)
{
    // TODO: Implement your custom parser logic    
    return text;
}
```

### Parameters

| Name         | Data type     | Description                                                                                |
|--------------|---------------|--------------------------------------------------------------------------------------------|
| text         | string        | The value of the field from the CSV row. As the signature implies, the value may be null.  |
| fieldIndex   | int           | The index of the field in the record. Note that the index is 1-based, so the first field has index 1.|
| context      | FieldParserContext | Provides access to additional APIs that can be used during parsing of a field value.  |


#### FieldParserContext properties

| Name         | Data type              | Description                                                                         |
|--------------|------------------------|-------------------------------------------------------------------------------------|
| Record       | string []              | All fields in the record reprsented as an array of strings.                         |
| Diagnostics  | IDiagnosticsServices   | Provides access to the diagnostics API, which can be used for logging an debugging. |

##### Example

This example shows two different use cases for the field parser.  

1) Our CSV file contains fields with the value "..", which we need to interpret as `null` in our example.  
2) We need to combine the values in field 8 and 11 to a new value when the CSV file is imported.  

```csharp
public static string? ParseFieldValue(string? text, int fieldIndex, FieldParserContext context)
{
    if(text == "..")
    {
        return null;
    }

    // Our Column mapping does not include field index 11, so we don't have to handle that case.
    if(fieldIndex == 8) 
    {
        // context.Record is a string array. 
        // Array indexes are always 0-based, so the 8th field is at index 7 and the 11th field is at index 10 in the array.
        return string.Concat(context.Record[7], "_", context.Record[10]);
    }
    
    return text;
}
```
