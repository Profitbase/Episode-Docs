# Get Data Store metadata

Gets metadata information about an InVision Data Store.

## Format

The action returns a .NET object with the following properties:  

```json
{
    "TimeFrame": {
        "ReferenceDate": System.DateTimeOffset
    },
    "ObjectId": System.String,
    "SolutionId": System.String
}
```

| Property             | Data type                                  | Description                                              |
|----------------------|--------------------------------------------|----------------------------------------------------------|
|TimeFrame.ReferenceDate | [System.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset?view=net-8.0) | The reference / base date of the Data Store. |
| ObjectId             | [System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string)                          | The id of the Data Store Solution object in InVision.    |
| SolutionId           | [System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string)                          | The id of the Solution that the Data Store belongs to.   |
  