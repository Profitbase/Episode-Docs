# Get Sitemap

Gets the sitemap from a URL.

Use this action to obtain the sitemap structure for a website. 
This action retrieves the sitemap from a given URL and returns a structured list of sitemap entries, including metadata about each page.

![Sitemap Image](/images/flow/get-sitemap.png)


## Properties

| Name                 | Type      | Description |
|----------------------|----------|-------------|
| Title           | Optional | The name of the operation for retrieving the sitemap. Default: "Get sitemap". |
| Sitemap URL     | Required | The URL of the sitemap to be fetched. The user needs to provide a value. If the provided URL does not contain or end with an XML file containing the sitemap (e.g., `yourwebsite.com`), `"sitemap.xml"` is automatically appended. If the URL ends with `".xml"` (e.g., `yourwebsite.com/sitemap-file.xml), it is regarded as the sitemap.
 |
| Result variable name | Optional | The name of the variable where the retrieved sitemap will be stored. Default: "sitemap". |
| Description     | Optional | A field for adding additional details about the operation. |
| Authentication  | Optional | Specifies authentication details needed to access the sitemap, if applicable. |


## Returns

### `List<SitemapEntry>`

A list containing entries representing pages found in the sitemap.


### `SitemapEntry`
```csharp
SitemapEntry {
    Url: string,
    LastModified: DateTime,
    ChangeFrequency: ChangeFrequency
}
```

ChangeFrequency

Defines how frequently the content at the URL is likely to change.

```csharp

ChangeFrequency {
    Always,
    Hourly,
    Daily,
    Weekly,
    Monthly,
    Yearly,
    Never
}
```