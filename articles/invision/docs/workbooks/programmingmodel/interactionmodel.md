# Interaction Model

When adding components to a section or page in a [Workbook](../../workbooks.md), such as [Worksheets](../../worksheets.md), you need to set up the interaction model for the component. The component does absolutely nothing until you tell it what to do, for example when and how to load data, save data, execute, etc. 

A component can raise events and handle actions. When raising events, other components in the Workbook can react to the events and take appropriate actions. When handling events raised by other components, the handler can execute one or more actions. Raising and handling events is called the interaction model, which needs to be set up for every component added to the Workbook.
<br/>

## See Also 
* [Sending Messages Between Workbooks](interactionmodel/sendingmsgbetween.md) 
* [Workbook Actions](interactionmodel/workbookactions.md)
* [Workbook Events](interactionmodel/workbookevents.md)
