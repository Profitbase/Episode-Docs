# PdfDocumentElement

Represents an element in a [PdfTree](pdf-tree.md) returned from the [Extract content from PDF as document tree](../extract-content-from-pdf-as-object-tree.md) action.

## Properties
| Name            | Type              | Description                    |
|-----------------|-------------------|--------------------------------|
| ElementType     | string            | The type of element in the document, for example `Table`, `TR`, `TD`, `P`. |
| Value           | string            | The value of the element.  | 
| Page            | int               | The page that the element belongs to. |
| Children        | List&lt;PdfDocumentElement&gt; | The children of this element (if any). |
| Parent          | PdfDocumentElement| The parent PdfDocumentElement of this element. This property is null for the root (Document) element. |


## Methods
| Name                                                                 | Description                            |
|----------------------------------------------------------------------|-----------------------------------------|
| FindFirstAncestor(Func&lt;PdfDocumentElement, bool&gt; predicate)    | Returns the first ancestor that satisfies the predicate condition. |
| TraverseUp()                                                         | Returns an [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;[PdfDocumentElement](pdf-document-element.md)&gt; of elements from this element to the root.  |
| TraverseDown()                                                       | Returns an [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;[PdfDocumentElement](pdf-document-element.md)&gt; of elements from this element and down to all leaf nodes. | 
