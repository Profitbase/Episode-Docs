# Workbook Menu

The Workbook Menu enables users to quickly explore and navigate between the different [Workbooks](workbooks.md) that they have access to. Workbooks belonging to [Work Processes](workprocess.md) are automatically grouped by the Work Process and version they belong to.

The system comes with a default menu, but you can create additional menus if you want to separate different work processes or business solutions. For example, if you are a manager of a production facility, you will have both operational and administrative responsibilities.

If you have a large custom solution for production management, you might or might not want all the Workbooks from your production management app in the same menu as your financial planning app. With the option to create multiple Workbook menus, customers get the option to decide how they want their [identities](accesscontrol/identities.md) to be able to navigate between all the Workbooks they have access to. Some would like to have everything available on the same menu, while others like to keep things focused.
<br/>

## Structuring

A menu can be structured with folders, Workbooks, and Work Processes using the InVision Designer.
<br/>

**Folders** are typically used for grouping Workbooks that logically belong together. Folders can have any type of children, so you can use folders to create menu hierarchies as deep as you want (although we don't recommend creating it more than a few levels deep).

Workbooks can be placed at the root level of a menu, or as children of a folder. Workbooks cannot have children of their own. 

> [!NOTE]
> Workbook can only belong to a single menu.
<br/>

**Work Processes** can be placed in a menu using either the InVision Designer or the Work Process configuration screen in a Workbook. Work Processes can be placed at the root level or in folders. Versions and Workbooks that belong to a Work Process is automatically displayed in the menu.

Work Processes should always be added to the **default system menu**. When using the InVision Designer you can place Work Processes in custom menus, but when using the web interface, all Work Processes will automatically be placed in the system menu.

<br/>

A Workbook will appear in a menu if the following holds true:

- The current user has been granted access to the Workbook
- The Workbook has been explicitly added to a menu, or the Workbook belongs to a Work Process with a Version that is either in the Deployed, Open or Closed state
- While a Work Process Version is in the Deployed state, only Work Process administrators will have access to the Workbook

<br/>

**Example**

Placing a Workbook in a menu using the InVision Designer:

1. In the InVision Designer, from the application menu, choose **Workbook Menu** -> **Workbook Menu Designer**,
2. Choose the **System Menu** (or create a custom menu),
3. Click **Add Workbook** or right click a folder to add a Workbook,
4. If you want to reposition the Workbook, drag and drop it to the new location.

<br/>

![WbMenu](https://profitbasedocs.blob.core.windows.net/images/WBmenu1.png)

<br/>

**Example**

Placing a Work Process in the menu using the Work Process configuration screen:

1. Open the Work Process management Workbook,
2. Find the Work Process and choose Configuration,
3. Click the Position in the menu link,
4. In the popup, drag and drop the Work Process to the desired position.

<br/>

![WbMenu](https://profitbasedocs.blob.core.windows.net/images/WBmenu2.png)

<br/>

## Videos

- [Workbook Menu](../videos/workbookmenu.md)
- [Basics](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20Menu.mp4)

<br/>
