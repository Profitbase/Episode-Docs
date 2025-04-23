# Workbooks

Workbooks are the end-user interfaces of InVision. A Workbook consists of one or multiple pages, and each page contains one or more [components](workbooks/components.md), for example, [Worksheets](worksheets.md), [Reports](workbooks/components/reports.md), [Filters](filters/index.md), [Buttons](workbooks/components/uielements/button.md), [Labels](workbooks/components/uielements/label.md), etc.

A Workbook also has left, top, and right sections which can be used for hosting components that interact with components across many pages, for example, a Save-button or global filters.

<br/>

## Start page
You can configure a Workbook to be the landing page of InVision instead of the default system [home page](homepage.md). This enables you to create a tailored and interactive landing page for users, taking them straight to the work at hand.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/homePage.png)

<br/>

## Workbook Properties

| Name                    | Description                  |
|-------------------------|------------------------------|    
| App Leave Behavior      | Specify whether the user is prompted to save unsaved changes when closing the browser tab. By default, the user will be prompted if there are unsaved changes. |
| Page title casing       | Specifies whether to transform all page titles to upper case or use the casing specified in the title.  |
| Title Expression        | Enables dynamic page titles. The most common use case is to use the Localize()-function to display the page title in the language of the user. |
| Interaction tracing     | Used for debugging during development. Specifies whether interaction tracing (for example variable assignment) is written to the browser console. |
| Icon                    | The icon displayed for the Workbook in the Workbook Menu | 
| Hide Header             | Specifies whether the Workbook header is hidden. Typically used if you want to embed the Workbook in another web app using an iframe. |
| Hide NavBar             | Specifies whether the page navigation bar is hidden. Typically used if you want to embed the Workbook in another web app using an iframe. |

<br/>

## See Also

- [How to's](workbooks/howto.md)
- [Programming Model](workbooks/programmingmodel.md)
- [Pages](workbooks/pages.md)
- [Subscreens](workbooks/subscreens.md)
- [Components](workbooks/components.md)
- [Themes and Styles](workbooks/themesandstyles.md)
- [Workbook Menu](workbookmenu.md)

## Videos

- [Workbooks](../videos/workbooks.md)
- [Basics - Creating Pages, Adding Parts and The Layout System](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20-%20Basics%20-%20creating%20pages%2C%20adding%20parts%2C%20the%20layout%20system.mp4)
- [Workbook as a Home Page](https://profitbasedocs.blob.core.windows.net/videos/Workbooks%20-%20Workbook%20as%20a%20Homepage.mp4)
