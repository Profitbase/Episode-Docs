
# InVision 2023.5 change log

<br/>


2023.5 includes a range of improvements and new features, ranging from UI to infrastructure enhancements.

<br/>

Before updating, please read the **upgrade notes** at the end.

<br/>

### Filter

We’ve added support for selecting multiple values in filters programmatically. In the _Set Filter Value_ action of a Filter, you can now call the new SetValues function and pass in an array item filter item ids.

![filter](https://profitbasedocs.blob.core.windows.net/images/chlog2351.png)

<br/>

### Forms

#### Support for DropdownTreeView control

We’ve added support for the DropdownTreeView control, which enables displaying a TreeView in a Dropdown control. It has support for single / multi-selection, custom rendering and an API to programmatically control the behavior of the control.

![filter](https://profitbasedocs.blob.core.windows.net/images/chlog2352.png)

<br/>

#### Extend API for the TreeView control

We’ve added APIs to enable developers to programmatically control the expansion state of a TreeView as highlighted in the image blow. The getExpandedNodIds also enables the developer get the current expansion state so it can be stored and re-applied later.

![filter](https://profitbasedocs.blob.core.windows.net/images/chlog2353.png)

<br/>

### Dimensions

- Fixed an issue where customers importing dimension data with cyclic references would cause dimension compilation to fail. Cyclic members will now become root members and needs to be moved to its proper location manually.

- Fixed an issue with dimension generation when new properties were added.

<br/>

### Permissions and Access Control

#### View which users have access to a Workbook

You can now easily see which users have access to a Workbook through group membership, both from the Designer and Web client.

<br/>

![filter](https://profitbasedocs.blob.core.windows.net/images/chlog2354.png)

<br/>

![filter](https://profitbasedocs.blob.core.windows.net/images/chlog2355.png)

<br/>

#### Copy users from Access Group

You can now easily copy users from one Access Group and paste to other Access Groups. If a user already exists, it will not be added to the target Access Group.

<br/>

![filter](https://profitbasedocs.blob.core.windows.net/images/chlog2356.png)

<br/>

![filter](https://profitbasedocs.blob.core.windows.net/images/chlog2357.png)

<br/>

### Performance improvements

- Workbooks loads faster.

- The Workbook Menu loads faster.

- Filters in Workbooks loads faster.

- Worksheets loads faster.

<br/>

### Developer Experience

We no longer display the stack trace of error messages. If you need the stack trace for debugging purposes during development, you need to enable this feature from the System Settings menu in the Designer by setting the **API Error Detail Level** to **Full**.

<br/>

![filter](https://profitbasedocs.blob.core.windows.net/images/chlog2358.png)

<br/>

### Upgrade notes

#### Update Profitbase Installation Manager

Before upgrading to InVision 2023.5, it is important to use **Profitbase Installation Manager 5.3.0.3**. Installing or upgrading to 2023.5 using a previous version of Profitbase Installation Manager will fail.

#### Change Azure Service Bus queues

We fixed an issue with Dataflows that caused Dataflows to not complete execution in certain situations. If you have an on-premise deployment, you need to change all Azure Service Bus queues as follows:

**Max delivery count**: 750  
**Message time to live**: 2 hours  
**Message lock duration**: 10 seconds

<br/>

![filter](https://profitbasedocs.blob.core.windows.net/images/chlog2359.png)

<br/>

### See Also

- [Change Log 2024.3](changelog24_3.md)
- [Change Log 2024.2](changelog24_2.md)
- [Change Log 2024.1](changelog24_1.md)
- [Change Log 2023.7](changelog23_7.md)
- [Change Log 2023.6](changelog23_6.md)
- [Change Log 2023.4](changelog23_4.md)
- [Change Log 2023.3](changelog23_3.md)
- [Change Log 2023.2](changelog23_2.md)
- [Change Log 2023.1](changelog23_1.md)
- [Change Log 2022.5](changelog22_5.md)
- [Change Log 2022.4](changelog22_4.md)
- [Change Log 2022.3 pt 2](changelog22_3_2.md)
- [Change Log 2022.3 pt 1](changelog22_3_1.md)
- [Change Log 2022.2](changelog22_2.md)
- [Change Log 2022.1](changelog22_1.md)
- [Change Log 5.2](changelog52.md)
- [Change Log 5.1](changelog51.md)
- [Change Log 5.0](changelog5.md)
- [Change Log 4.1](changelog41.md)
- [Change Log 4.0](changelog40.md)

<br/>
