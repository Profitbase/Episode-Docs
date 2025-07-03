# Extract content from PDF as JSON

Extracts content from a PDF file and returns it as a JSON string.

>[!NOTE]
>If you want to programatically query the document structure of a PDF document, consider using the [Extract content from PDF as document tree](./extract-content-from-pdf-as-object-tree.md) action instead.


## Properties

| Name            | Type     | Description                                                                 |
|-----------------|----------|-----------------------------------------------------------------------------|
| fileContent   | Required   | Byte array of the PDF file to be extracted.     |
| outputFormat  | Required   | Defines the structure of the extracted result. Options: `JSON_Raw`, `JSON_Simplified`, `JSON_Hierarchical`. |
| fileData      | Optional   | Name of the variable to store the extracted result. Defaults to `fileData`. |

<br/>

## Output format options

**JSON_Raw**
- Contains low-level layout and styling metadata such as bounding boxes, fonts, position coordinates, justification, line height, etc.
- Best for use cases where exact PDF layout reproduction or fine-grained analysis is needed.

**JSON_Simplified**
- Extracts only plain text, organized by page.
- Suitable for basic text search and lightweight parsing.

**JSON_Hierarchical**
- Outputs a tree structure reflecting logical document structure (`Document` -> `Page` -> `heading`, `paragraph`, `table`, etc.).
- Best choice for semantically meaningful documents like theses, reports, contracts.

### Examples

**JSON_Raw format**

```json
{
  "elements": [
    {
      "Bounds": [126.02, 315.34, 488.76, 358.76],
      "Font": {
        "family_name": "Times New Roman",
        "weight": 700
      },
      "Lang": "en",
      "page": 6,
      "path": "/Document/P[6]",
      "text": "Results: Results showed decrease in the intensity of the symptoms of Attention-Deficit/Hyperactivity Disorder...",
      "TextAlign": "Justify"
    }
  ]
}
```

**JSON_Simplified format**

```json
{
  "elements": [
    {
      "page": 6,
      "path": "/Document/P[6]",
      "text": "Results: Results showed decrease in the intensity of the symptoms of Attention-Deficit/Hyperactivity Disorder..."
    }
  ]
}
```

**JSON_Hierarchical format**

```json
{
  "elementType": "Document",
  "children": [    
    {
      "elementType": "Page",
      "page": 1,
      "children": [        
        {
          "elementType": "Sect",
          "page": 1,
          "children": [
            {
              "elementType": "H1",
              "value": "Competitive Analysis",
              "page": 1,
              "children": []
            },
            {
              "elementType": "P",
              "value": "Our company’s market share in the travel industry has been steadily increasing since the introduction of our company in 2011, and currently hovers around approximately 15% of US sales, 10% of European sales, and 7% of Asian sales. We do believe, however, that increased marketing efforts are needed to maintain this growth, due to ever-increasing competition from other travel brands.",
              "page": 1,
              "children": []
            },
            {
              "elementType": "Figure",
              "value": "15% 85% Market Share: US Our Company Combined Competitors 10% 90% Market Share: Europe Our Company Combined Competitors",
              "page": 1,
              "children": []
            },
            {
              "elementType": "Sect",
              "page": 1,
              "children": [
                {
                  "elementType": "H2",
                  "value": "Market Share: Asia",
                  "page": 1,
                  "children": []
                },
                {
                  "elementType": "Figure",
                  "value": "7% 93% Our Company Combined Competitors",
                  "page": 1,
                  "children": []
                }
              ]
            }
          ]
        }
      ]
    }    
  ]
}
```