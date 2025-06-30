# Extract content from PDF as document tree

Extracts content from a PDF file and returns it as a tree of elements.
Use this action if you need to query the contents of a PDF document in a structured way to extract information, such as invoice details or product information. 
The action returns a [PdfTree](./apis/pdf-tree.md) that you can use in a [Function](../built-in/function.md) action to programatically read the contents of the PDF document.

![img](/images/flow/adobe-extract-pdf-content-as-document-tree.png)  

**Example** ![img](../../../../images/strz.jpg)  
The example above shows a Flow that automatically processes incoming emails with invoice attachments, extracts the invoice details, and registers them in Dynamics 365 Business Central.

<br/>

## Properties

| Name                 | Type        | Description             |
|----------------------|-------------|-------------------------|
| Connection           | Required    | The [connection](./adobe-connection.md) for your Adobe PDF Services account.  |
| File contents        | Required    | A stream or byte array containing the PDF file contents. |
| Result variable name | Required    | The name of the variable containing the [PdfTree](./apis/pdf-tree.md) that you can use in a Function to extract the information you want from the PDF document.  |

<br/>

## Returns
This action returns a [PdfTree](./apis/pdf-tree.md) that you can use in a Function to extract the information you want from the PDF document.

<br/>

## Example - Extract the Total amount from an invoice

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