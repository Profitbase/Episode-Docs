# PdfTree

Represents the structure of a PDF document returned from the [Extract content from PDF as document tree](../extract-content-from-pdf-as-object-tree.md) action

## Implements
[IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;[PdfDocumentElement](./pdf-document-element.md)&gt;  

The PdfTree implements [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;T&gt;, which means that you can query the PDF object structure using standard LINQ methods, like shown in the examples below.

## Methods
| Name                             | Description                           |
|----------------------------------|---------------------------------------|
| FindOrDefault(string id)         | Returns the [PdfDocumentElement](./pdf-document-element.md) with the specified id. |
| Contains(string id)              | Returns `true` if the tree contains an element with the specified id, otherwise `false`.  |
| Traverse(bool keepChildOrder = false) | Returns an [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;[PdfDocumentElement](./pdf-document-element.md)&gt; |
| ToJson()                         | Serializes the PdfTree as a JSON string. Useful for debugging purposes to explore how the PDF document is structured in a text editor. |
| [System.Linq.Enumerable extension methods](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable) | |

## Example 

This example shows how to extract the `Total Amount` from the sample invoice below.

![img](/images/flow/snowflake-sample-invoice.png)

```csharp
// PdfTree pdfTree = ...from an "Extract content from PDF as document tree" action
var totalAmountLabel = pdfTree.FirstOrDefault(element => element.Page == 0 && element.Value == "Total Amount");
if(totalAmountLabel is null)
{
    return 0;
}

// Move up to the table row TD-> TR (Parent -> Parent), then access the second row of the TR (Children[1]) and then get the value of the object in the TD cell (Children[0].Value)
var totalAmountText = totalAmountLabel.Parent.Parent.Children[1].Children[0].Value;

// The amount is on the following format: $24.91 USD
var totalAmount = double.Parse(totalAmountText.Replace("USD", ""), System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
```