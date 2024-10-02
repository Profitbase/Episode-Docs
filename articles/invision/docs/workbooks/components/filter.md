# Filters

Filters are components used for setting the data context for Settings, [Worksheets](../../worksheets.md), [Reports](reports.md), [Workflows](workflow.md), and [Data Flows](dataflow.md).

Once a [Filter](filter.md) is defined, it can be used by all data context-aware components in a Solution by binding the Filter to a property of the component.

A Filter is defined as a reference to table resource ([Dimension](../../dimensions/index.md), Fact, Setting, [Data Store](../../datastores.md), or a [View](../../views.md)) and by a configuration describing how to read data from the table resource.
<br/>

>Place the selected filter in the UI by dragging and dropping it from the Toolbox in Workbook designer.

![Filter](https://profitbasedocs.blob.core.windows.net/images/filtersinworkbook.png)



<br/>

>Set the properties of the filter. 

![Filter](https://profitbasedocs.blob.core.windows.net/images/filtersinworkbookproperties.png)
<br/>

>Make sure that your filter will load when you open your Solution. Open Workbook Events and drag and drop an Action from the Available Actions list.

![Filter](https://profitbasedocs.blob.core.windows.net/images/workbookaction.png)
<br/>

>Than set the [Events](../programmingmodel/interactionmodel/workbookevents.md), [Actions](../programmingmodel/interactionmodel/workbookactions.md) and [Instructions]() of the Filter. 

![Filter](https://profitbasedocs.blob.core.windows.net/images/filtersinworkbookevents.png)
<br/>



## Show and Hide Filters


>You can toggle the visibility of a filter in a Workbook on and off.

**Option 1:** 

Specify the **Is Hidden** or **Is Hidden Expression** property in the Filter property pane.
The **Is Hidden Expression** is a C# expression that must return true or false. If you specify an **Is Hidden Expression**, it will override the **Is Hidden** property.

Both of these properties are evaluated only once and sets the initial visibility of the filter. 

<br/>

![Filter](https://profitbasedocs.blob.core.windows.net/images/hideFilter2.png)
<br/>

**Option 2:**

Use the **Execute Expression** action of a filter to toggle its visibility on and off by using one of the following functions:

        Hide();
        HideIf(boolean expression);
        Show();
        ShowIf(boolean expression);

<br/>

![Filter](https://profitbasedocs.blob.core.windows.net/images/hideFilter3.png)

<br/>



## Filter headings

<br/>

**Option 1:**

Use the Header or the Header Expression property in the Filter property pane.
The Header property specifies the default heading of the filter.
The Header Expression property is a C# expression that must return a string. If you specify a Header Expression, it will override the Header property.

Both of these properties are evaluated on the server when the Workbook is loaded. This means that you cannot use any Workbook parameters in the Header Expression, and the Header Expression is evaluated only once.

<br/>

![fh](https://profitbasedocs.blob.core.windows.net/images/filterheadings1.png)

The most common use case for using the Header Expression is localization.  
If you want to heading of the filter to display in the language of the user, you must use the Localize(...) function in the Header Expression.
<br/>

**Example:**

Assuming that the text code "TXT_Currency" is a registered text code in the Localization system, the following expression will display the heading to the user in their language.

```
Localize("TXT_Currency");
```

<br/>

**Option 2:**

Use the Execute Expression action of a filter to dynamically change the heading by using **one** of the following instructions:

```
SetHeader(text: string); // Changes the header
SetHeaderSuffix(suffix: string); // Appends a suffix to the default header
ResetHeader(); // Resets the header back to the default value
```

<br/>

![fh](https://profitbasedocs.blob.core.windows.net/images/filterheadings2.png)



<br/>




## See Also
* [More about Filters](../../filters/index.md)
* [Filtering Tables](../../tables/filters.md)
* [Filtering Worksheets](../../worksheets/filters.md)

## Videos

* [Filters](../../../videos/filters.md)