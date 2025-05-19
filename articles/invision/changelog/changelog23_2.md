
# InVision 2023.2 change log

<br/>

This is a minor release with a few improvements to the Package upgrade experience.

<br/>

### Package upgrade

- Before a Package upgrade is allowed to continue, we now validate that all Views in target Solutions have valid configurations. If any View definitions are invalid, the Package upgrade is aborted immediately.
- After a Package has been upgraded, the access control list is automatically applied. This ensures that new Workbooks are available to users without manual steps.
- We will prevent users from starting a Package upgrade if any Dataflows are running in the target Solutions.
- All scheduled Dataflows in target Solutions are automatically suspended while a Package is upgrading.

<br/>

### Misc

**Display Status bar for Worksheets, Tables and SQL Reports.**  
Worksheets, Tables and SQL Table Reports can now display a status bar at the bottom of the spreadsheet that displays the Sum, Count and Average of selected cells in the sheets. To turn this on, enable the **“Display Status Bar”** property for individual Worksheets, Tables and SQL Reports in the Designer.

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/chlog223_5.png)

When enabled, the status bar will display the sum, count, and average of the selected cells. To copy a value to the clipboard, simply click on it.

<br/>

### See Also

- [Change Log 2025.2](changelog25_2.md)
- [Change Log 2025.1](changelog25_1.md)
- [Change Log 2024.4](changelog24_4.md)
- [Change Log 2024.3](changelog24_3.md)
- [Change Log 2024.2](changelog24_2.md)
- [Change Log 2024.1](changelog24_1.md)
- [Change Log 2023.7](changelog23_7.md)
- [Change Log 2023.6](changelog23_6.md)
- [Change Log 2023.5](changelog23_5.md)
- [Change Log 2023.4](changelog23_4.md)
- [Change Log 2023.3](changelog23_3.md)
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
