# Changelog 2024.3

<br/>

The 2024.3 release adds support for more Flow integrations, improvements to the TableView, Tab control, and Filter components, and adds the Spinner control to Form Schemas.

## Flow integration

#### Publish dimension
You can now define Flows to run after a dimension has been published. Going forward, prefer using Flow instead of Dataflow for running custom business logic after a dimension has been published or published to. Dataflow is still supported, but will be removed in the future.

![Publish Dimension Image](https://profitbasedocs.blob.core.windows.net/images/publish-dim-sept.png)

#### Work Process Version Deployment
You can now define Flows to run after a Work Process Version has been deployed, opened, closed, and before delete. This is now the preferred way of running custom business logic when a Work Process Version changes state. Dataflow is still supported, but will be removed in the future.

![Work Process Version Deployment Image](https://profitbasedocs.blob.core.windows.net/images/work-process-sept.png)

#### Package Deployment
Like with Work Process Version and Dimensions, you can now run Flows after a Package has been deployed or upgraded. Prefer using Flows instead of Dataflows, as Dataflows will be deprecated in the future.

## Workbook enhancements and new features

#### Tab control – API for changing active tabs
You can now programmatically change the active tab of Tab Control components so users can be directed to relevant content based on actions or state in the Workbook.

```html
<Function>
     this.controls.myTabControl.activateTab('Customers')
</Function>
```
#### Filter – fixed issue with Search filter
We’ve fixed an issue with the Search filter that caused an error if the “Load Data” action was not run before it was used.

#### Forms – Added Spinner control
Developers can now display Spinners in Forms to indicate long-running processes, for example while running Flows directly from Form components.

#### TableView – multiple enhancements
- The Selection column can now be configured to have 3 visibility options:
  - Never
  - On hover – Checkboxes are visible when the user hovers over a row
  - Always (New) – Checkboxes are always visible
- **Wrap filters to a new row**: If you have a large number of filters, they will now wrap to a new row in the table header instead of breaking out of the control bounds.
- **Conditionally enable context menu items**: Developers can now specify conditions for whether custom context menu items are enabled or not.

![Package Deployment Image](https://profitbasedocs.blob.core.windows.net/images/table-view-sept.png)

#### Workbook Page – show and hide
You can now show and hide Workbook pages conditionally using one of the following methods:
- **Is Hidden Expression**: Use the new Is Hidden Expression (C#) on the Workbook Page to perform a server-side evaluation of whether the page is default hidden or not.
- **Show and Hide page actions**: Execute the new Show and Hide actions in the Action Tree to dynamically show and hide pages.
- **JavaScript API for hiding and showing pages**: Use the JavaScript API in Action instructions of Forms to dynamically show and hide pages.

![Package Deployment Image](https://profitbasedocs.blob.core.windows.net/images/wb-page-sept.png)

## Access Control and Permissions

#### Support for membership of more than 200 Microsoft Entra groups
We now support users being members of more than 200 Microsoft Entra user groups. 

## See Also
- [Change Log 2025.2](changelog25_2.md)
- [Change Log 2025.1](changelog25_1.md)
- [Change Log 2024.4](changelog24_4.md)
- [Change Log 2024.2](changelog24_2.md)
- [Change Log 2024.1](changelog24_1.md)
- [Change Log 2023.7](changelog23_7.md)
- [Change Log 2023.6](changelog23_6.md)
- [Change Log 2023.5](changelog23_5.md)
- [Change Log 2023.4](changelog23_4.md)
- [Change Log 2023.3](changelog23_3.md)
- [Change Log 2023.2](changelog23_2.md)
- [Change Log 2023.1](changelog23_1.md)
- [Change Log 2022.5](changelog22_5.md)
- [Change Log 2022.4](changelog22_4.md)
- [Change Log 2022.3 pt 2](changelog22_3_2.md)
- [Change Log 2022.3 pt 1](changelog22_3_1.md)
- [Change Log 2022.2](changelog22_2.md)
- [Change Log 5.2](changelog52.md)
- [Change Log 5.1](changelog51.md)
- [Change Log 5.0](changelog5.md)
- [Change Log 4.1](changelog41.md)
- [Change Log 4.0](changelog40.md)
