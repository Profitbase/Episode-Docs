# Unescape unicode characters

Unescapes Unicode characters in a string, so that for example `Europa s\u00f8r` becomes `Europa sør`.

A typical use case for this action is when processing raw JSON returned from HTTP APIs, where the JSON string may contain unicode escaped characters.

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