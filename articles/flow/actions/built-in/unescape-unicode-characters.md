# Unescape unicode characters

Unescapes unicode characters in a string, so that for example `Europa s\u00f8r` becomes `Europa sør`.

A typical use case for this action is when processing raw JSON returned from HTTP APIs, and the returned JSON string may contain unicode escaped characters.

![img](/images/flow/unescape-unicode-characters.png)

## Returns
[String](https://learn.microsoft.com/en-us/dotnet/api/system.string) containing unescaped unicode characters.  
Note that if the original string does not contain escaped unicode characters, the original string is returned. 

## Properties
| Name                 | Type      | Description                                           |
|--------------------- |-----------|-------------------------------------------------------|
| String to unescape   | Required  | A string that may contain escaped unicode characters. If the string is null / empty, or does not contain escaped unicode characters, no operation is performed. |
| Output variable name | Required  | The name of the variable containing the unescaped string. |

<br/>

#### Example
The example below shows a JSON string before and after unicode characters have been unescaped.  

**Before**  
```json
{
    "code": "EU-S",
    "displayName":"Europa s\u00f8r"
}
```

**After**  
```json
{
    "code": "EU-S",
    "displayName":"Europa sør"
}
```