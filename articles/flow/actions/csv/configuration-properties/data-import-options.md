# Data import options

## General

| Name                  | Description                                                          |
|-----------------------|----------------------------------------------------------------------|
| File encoding         | The encoding that the file was generated with. The default is UTF 8. Note that if the encoding is incorrect, the file will appear empty. No data will be imported, and no errors will be raised.  |
| Delimiter             | The delimiter that separates the fields on each row. By default, the delimiter will be auto detected, but you can specify the delimiter explicitly if we fail to detect the correct delimiter.  |
| Quote character       | The character used to quote fields. The default value is " (double quote).   |
| Validate data types   | When this property is enabled, the field values from the file is validated against the data types specified in the [Column mappings](column-mapping.md). If the validation fails, and error handling is set to **Log and continue**, the record will be stored in the [BadData](../bad-data.md) collection. If you only import string (text) values, enabling this property has no effect because all fields values are text by default. |
| Empty records         | Specifies whether or not empty records in the file are skipped.      |

## Date and number formatting
| Name                  | Description                                                          |
|-----------------------|----------------------------------------------------------------------|
| Locale                | Specifies the default locale used for parsing dates and numbers (which means converting text to dates or numeric values). |
| Date / DateTime format | Specifies one or more format strings for parsing text to date or datetime. You can use this option to override the default datetime format string used by the selected Locale, or add additional datetime format strings using a semi-colon separated list, for example `yyyy.MM.dd; dd.MM.yyyy; yyyy.MM.ddThh:mm:ss`. <br/> The most commonly used format strings are: <br/> `yyyy-MM-dd`<br/>`yyyy.MM.dd`<br/> `yyyy/MM/dd` <br/> `dd.MM.yyyy`<br/>`yyyy-MM-ddThh:mm:ss` <br/>For more details and examples, please refer to the [.NET documentation for custom date and time format strings](https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings)  |
| Number decimal separator | Specifies the decimal separator. The default value is `.` (period) |
| Number group separator   | Specifies the number group separator. The default value is `,` (comma). Examples of numbers using whitespace or comma group separators are `100 000` and `100,000`.  |

## Error handling

| Name                  | Description                                             |
|-----------------------|---------------------------------------------------------|
| Bad data              | Specifies what happens when bad data is detected. <br/> **Fail import**: Execution of the action fails by throwing an exception. <br/>  **Log and continue**: The field(s) with bad data is added to the [BadData](../bad-data.md) collection and the row is skipped.  |
| Missing fields        | Specifies what happens when a row with missing fields are detected. <br/> **Fail import**: Execution of the action fails by throwing an exception. <br/>  **Log and continue**: The field(s) with bad data is added to the [BadData](../bad-data.md) collection and the row is skipped.  |