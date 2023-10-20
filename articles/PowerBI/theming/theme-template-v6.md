The JSON definition below shows all properties of the Financial Reporting Matrix that can be themed, along with all valid values for each property.

A few things to note:

<empty> means empty string "" (two double quotes with no whitespace)
All colors are specified using the hex color format #XXXXXX. For example #000000 is black. #someColor = use a hex color.
If you import the visual from your Organizational store (not AppSource), you must change the visual id in the visualStyles section below to "financialreportingmatrixD8A502553641450F8EAEB9BA40B2166E_OrgStore"


```json

{
  "name": "My Theme",
  "dataColors": [
    "#00338D",
    "#00CCDD",
    "#00EEFF"
  ],
  "visualStyles": {
    "financialreportingmatrixD8A502553641450F8EAEB9BA40B2166E": {
      "*": {
        "customColumns": [{ "width": 100 }, { "columnSeparator": "left | right | both | <empty>" }],
        "grid": [
          { "verticalGrid": false },
          { "verticalGridThickness": 1 },
          { "verticalGridColor": { "solid": { "color": "#someColor" } } },
          { "horizontalGrid": false },
          { "horizontalGridThickness": 1 },
          { "horizontalColor": { "solid": { "color": "#someColor" } } },
          { "rowPadding": 2 },
          { "outlineColor": { "solid": { "color": "#someColor" } } },
          { "outlineWeight": 1 }
        ],
        "columnFormatting": [
          { "width": 100 },
          { "isHidden": false },
          { "width": 100 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "backgroundColor": { "solid": { "color": "#someColor" } } },
          { "columnSeparatorColor": { "solid": { "color": "#someColor" } } },
          { "separator": "<empty> | left | right | both" },
          { "formatString": "<empty> | <Power BI format string> | custom" },
          { "customFormatString": "<Power BI format string>" }
        ],
        "columnHeaders": [
          { "fontColor": { "solid": { "color": "#someColor" } } },
          { "backgroundColor": { "solid": { "color": "#someColor" } } },
          { "fontWeightBold": true },
          { "fontStyleItalic": false },
          { "outline": "<empty> | bottom | bottom double | top | top bottom | top bottom double | left | right | left right | top bottom left right"},
          { "textSize": 9 },
          { "groupAlignment": "left | center | right" },
          { "alignment": "left | center | right" },
          { "wordWrap": true }
        ],
        "rowHeaders": [
          { "defaultExpandRows": false },
          { "expandToLevel": 1 },
          { "fontColor": { "solid": { "color": "#someColor" } } },
          { "backgroundColor": { "solid": { "color": "#someColor" } } },
          { "outline": "<empty> | bottom | bottom double | top | top bottom | top bottom double | left | right | left right | top bottom left right"},
          { "textSize": 8 },
          { "wordWrap": true }
        ],
        "values": [
          { "scalingValues": "none | thousands | millions | billions | trillions"},
          { "negativeValueFormatting": "minus | parentheses" },
          { "zeroValueFormatting": "dash | empty | zero" },
          { "formatString": "<empty> | <Power BI format string> | custom" },
          { "customFormatString": "<Power BI format string>" },
          { "fontColor": { "solid": { "color": "#someColor" } } },
          { "backgroundColor": { "solid": { "color": "#someColor" } } },
          { "outline": "none | bottom | top | left | right | top bottom | left right | top bottom left right"},
          { "textSize": 8 },
          { "wordWrap": false }
        ],
        "subTotals": [
          { "rowGrandTotal": false },
          { "rowGrandTotalLabel": "Your label" },
          { "rowGrandTotalStyle": "\"\"| bold | overline | underline | custom1 | custom2 | custom3 | custom4 | stylesSubtotal | stylesKPI"},
          { "columnSubotals": false },
          { "columnTotalsLabel": "Total" },
          { "columnTotalsStyle": "\"\"| bold | overline | underline | custom1 | custom2 | custom3 | custom4 | stylesTotal"}
        ],
        "rowExpansion": [
          { "storeExpansionState": true },
          { "indentSize": 10 },
          { "showExpandCollapseIcon": true },
          { "upwardsExpansion": false },
          { "useRowExpansionStyling": false },
          { "bold": true },
          { "fontStyleItalic": true },
          { "fontSize": 8 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#someColor" } } },
          { "outline": "\"\" | bottom | bottom double | top | top bottom | top bottom double"},
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#someColor" } } }
        ],
        "stylesTotal": [
          { "bold": true },
          { "fontStyleItalic": false },
          { "fontSize": 8 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#someColor" } } },
          { "outline": "top bottom"},
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#someColor" } } },
          { "marginTop": 0 },
          { "marginBottom": 0 }
        ],
        "stylesSubtotal": [
          { "bold": true },
          { "fontStyleItalic": false },
          { "fontSize": 8  },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#someColor" } } },
          { "outline": "bottom" },
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#someColor" } } },
          { "marginTop": 0 },
          { "marginBottom": 0 }
        ],
        "stylesKPI": [
          { "bold": false },
          { "fontStyleItalic": true },
          { "fontSize": 8 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#someColor" } } },
          { "outline": "top bottom"},
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#someColor" } } },
          { "marginTop": 0 },
          { "marginBottom": 0 }
        ],
        "stylesCustom1": [
          { "bold": true },
          { "fontStyleItalic": true },
          { "fontSize": 8 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#someColor" } } },
          { "outline": "\"\" | bottom | bottom double | top | top bottom | top bottom double | left | right | left right | top bottom left right"},
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#someColor" } } },
          { "marginTop": 0 },
          { "marginBottom": 0 }
        ],
        "stylesCustom2": [
          { "bold": true },
          { "fontStyleItalic": false },
          { "fontSize": 8 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#AAD2E9" } } },
          {"outline": "bottom"},
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#07366B" } } },
          { "marginTop": 5 },
          { "marginBottom": 5 }
        ],
        "stylesCustom3": [
          { "bold": true },
          { "fontStyleItalic": false },
          { "fontSize": 8 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#AAD2E9" } } },
          { "outline": "top bottom"},
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#07366B" } } },
          { "marginTop": 5 },
          { "marginBottom": 5 }
        ],
        "stylesCustom4": [
          { "bold": false },
          { "fontStyleItalic": false },
          { "fontSize": 8 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#someColor" } } },
          {"outline": "\"\" | bottom | bottom double | top | top bottom | top bottom double | left | right | left right | top bottom left right"},
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#someColor" } } },
          { "marginTop": 0 },
          { "marginBottom": 0 }
        ],
        "stylesCustom5": [
          { "bold": false },
          { "fontStyleItalic": false },
          { "fontSize": 8 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#someColor" } } },
          {"outline": "\"\" | bottom | bottom double | top | top bottom | top bottom double | left | right | left right | top bottom left right"},
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#someColor" } } },
          { "marginTop": 0 },
          { "marginBottom": 0 }
        ],
        "stylesCustom6": [
          { "bold": false },
          { "fontStyleItalic": false },
          { "fontSize": 8 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#someColor" } } },
          {"outline": "\"\" | bottom | bottom double | top | top bottom | top bottom double | left | right | left right | top bottom left right"},
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#someColor" } } },
          { "marginTop": 0 },
          { "marginBottom": 0 }
        ],
        "stylesBold": [
          { "bold": true },
          { "fontStyleItalic": false },
          { "fontSize": 8 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#someColor" } } },
          { "outline": "\"\" | bottom | bottom double | top | top bottom | top bottom double | left | right | left right | top bottom left right"},
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#someColor" } } },
          { "marginTop": 0 },
          { "marginBottom": 0 }
        ],
        "stylesOverline": [
          { "bold": false },
          { "fontStyleItalic": false },
          { "fontSize": 8 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#someColor" } } },
          { "outline": "\"\" | bottom | bottom double | top | top bottom | top bottom double | left | right | left right | top bottom left right"},
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#someColor" } } },
          { "marginTop": 0 },
          { "marginBottom": 0 }
        ],
        "stylesUnderline": [
          { "bold": false },
          { "fontStyleItalic": false },
          { "fontSize": 8 },
          { "color": { "solid": { "color": "#someColor" } } },
          { "background": { "solid": { "color": "#someColor" } } },
          { "outline": "\"\" | bottom | bottom double | top | top bottom | top bottom double | left | right | left right | top bottom left right"},
          { "outlineThickness": 1 },
          { "outlineColor": { "solid": { "color": "#someColor" } } },
          { "marginTop": 0 },
          { "marginBottom": 0 }
        ]
      }
    }
  }
}

```
