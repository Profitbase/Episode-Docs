# Data import options

## General

| Name                  | Description                                                          |
|-----------------------|----------------------------------------------------------------------|
| File encoding         | The encoding that the file was generated with. The default is UTF 8. Note that if the encoding is incorrect, the file will appear empty. No data will be imported, and no errors will be raised.  |
| Delimiter             | The delimiter that separates the fields on each row. By default, the delimiter will be auto detected, but you can specify the delimiter explicitly if we fail to detect the correct delimiter.  |
| Quote character       | The character used to quote fields. The default value is " (double quote).   |
| Validate data types   | When this property is enabled, the field values from the file is validated against the data types specified in the [Column mappings](column-mapping.md). If the validation fails, and error handling is set to **Log and continue**, the record will be stored in the [BadData](../bad-data.md) collection. If you only import string (text) values, enabling this property has no effect because all fields values are text by default. |
| Empty records         | Specifies whether or not empty records in the file are skipped.      |


## Error handling

| Name                  | Description                                             |
|-----------------------|---------------------------------------------------------|
| Bad data              | Specifies what happens when bad data is detected. <br/> **Fail import**: Execution of the action fails by throwing an exception. <br/>  **Log and continue**: The field(s) with bad data is added to the [BadData](../bad-data.md) collection and the row is skipped.  |
| Missing fields        | Specifies what happens when a row with missing fields are detected. <br/> **Fail import**: Execution of the action fails by throwing an exception. <br/>  **Log and continue**: The field(s) with bad data is added to the [BadData](../bad-data.md) collection and the row is skipped.  |