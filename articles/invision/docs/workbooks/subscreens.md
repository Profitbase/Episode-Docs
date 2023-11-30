
# Subscreens

![stepper](https://profitbasedocs.blob.core.windows.net/images/stepper.png)


**Subscreens have two functions:**

1.	Split your pages into smaller, more manageable components.
2.	Use them to create the contents of Tab Controls.

## Building Subscreens

You build and manage subscreens in the [Workbook](../workbooks.md) Designer. Like [Pages](pages.md), [Subscreens](howto/subscreens.md) consists of business logic (events and actions) and components such as Buttons, Filters, and Spreadsheets. Components are added to Subscreens by dragging and dropping items from the toolbox and organized in a grid layout (along rows and columns).

## Interaction Logic

Subscreen components (such as buttons), can invoke actions on another component in the Subscreen, but cannot invoke actions on components outside the Subscreen. 

**Raising events (outbound communication)**

To publish information from within a Subscreen to external components, you need to call the **Raise Custom Event** action of the Subscreen. You can pass along custom event data by calling the SetEventData(…) action instruction. If you do not call [SetEventData(…)](programmingmodel/instructions/seteventdata.md), the event data from the calling context (for example a spreadsheet cell click) is passed along.

>**Example**
>
>This example shows how to use the SetEventData(…) instruction to set the event data when executing the Raise Custom Event action.
>
>// Create an event data object with a property called “Message”, having the value “Hello World”
>
        SetEventData({"Message" : "Hello World"});
>
>In the event handler, you can get the message via **@Event.Data.Message**


**Custom Actions (inbound communication)**

You cannot directly invoke actions on components in Subscreens from outside the Subscreen itself. 
Instead, you need to create **Custom Actions** for the Subscreen and call these actions from the outside. Subscreen Custom Actions execute actions on components within the Subscreen, so they basically act as bridges between the outside and inside of Subscreens.

To create Custom Actions for a Subscreen, open the Subscreen in edit mode (click to focus) and click **Edit** in the **Properties** pane. This will bring up the Custom Actions editor, where you can create, edit, and delete custom actions. The custom actions of Subscreens will be available in the Event handler editor of all other components added to pages.

## Using Subscreens

Once a Subscreen has been created, it can be added to a Page or set as the content of a Tab Control Item. 

**To add a Subscreen to a page**, simply select the page in the Workbook Designer and drag-drop the Subscreen (from the Subscreen Toolbox) onto the page like any other component.

**To add a Subscreen to a Tab Control Item**, simply select it from the Content dropdown of a Tab Item.


> [!NOTE]
> Subscreen can only be used once pr Workbook. For example, you cannot put the same Subscreen in both a Tab Item and a Page.


<br/>

## Videos

* [Workbooks](../../videos/workbooks.md)
* [Subscreens in Tabs](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20-%20Sub%20Screens%20in%20Tabs.mp4)
* [Stepper](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20-%20Stepper.mp4)