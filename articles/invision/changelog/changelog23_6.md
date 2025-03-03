
# InVision 2023.6 change log

<br/>

The October release of InVision is here! Read the news below.

<br/>

### New Features

<br/>

#### Component placeholder

Developers can now specify placeholders (also known as skeletons) for Workbook components. When specified, the placeholder will render as a preview of the actual component until it is loaded. We currently support two types of placeholders:

* Animating skeleton. This placeholder does what the name suggests – it displays an animating skeleton until the component has loaded.
* Static skeleton. This placeholder looks the same as the animating skeleton, but without animation.
You should use placeholders when a component is displayed on a page, but not immediately loaded. This will improve the user experience by providing early feedback that work is in progress.

Placeholders are currently supported by the following components:

* Worksheets
* Tables
* SQL Reports
* Forms

![filter](https://profitbasedocs.blob.core.windows.net/images/chlog236_1.png)

Select which placeholder to use for a Workbook component.

<br/>

![filter](https://profitbasedocs.blob.core.windows.net/images/chlog236_2.png)

Placeholders are displayed until the components have finished loading.

<br/>

#### Workbook Loaded event


We have added a new event which is raised when a Workbook has finished loading. The event runs after the Loading event has finished, and after all pages have finished loading. You should use this event for loading global resources or executing scripts / jobs that can wait until the initial render or the Workbook and all pages has completed.

![filter](https://profitbasedocs.blob.core.windows.net/images/chlog236_3.png)

Run actions when all pages has finished loading.

<br/>

#### Excel export from Table lists

You can now export to Excel from Tables in Table Lists.

<br/>

### Changes and bug fixes

#### Dimensions

- **Publish dimensions:** When you publish a dimension, we will **no longer copy the configuration** from the source dimension to the target dimension. Publishing a dimension will now only copy the dimension members and the permissions, if the user chooses that option. If the source and target dimension configurations differ by columns, properties, language settings, etc, only columns in the target matching by name will be updated with data from the source dimension. This makes it very easy to create custom solutions and reuse dimension data from other solutions (such as the Primary Dimensions), without having to use the exact same dimension configuration and dependencies.

- **Automatic regeneration of Composite dimension when Work Process Version is deployed:** We fixed a bug where Composite dimensions were not regenerated when a Work Process Version was deployed. This caused the dimension to contain data pointing to the original dimension.
[Gitlab issue: Composition dimention references dimensions in original solution (#371) · Issues · platform / InVision · GitLab (profitbase.com)](https://support.profitbase.com/platform/invision/-/issues/371)

<br/>

#### Access Control

- **Permissions invalid after restructuring of dimensions:** We fixed an issue where restructuring a dimension would invalidate all access permissions set for members below the members that were moved or added.

<br/>

#### Filters

- **Fixed vertical alignment issue with horizontal filters components:** We fixed an issue with how horizontal filters were laid out that made them difficult to align nicely with buttons or other components in the same grid track.

- **Option to disable loading default items:** We’ve added a property to the Workbook Filter components that enables you to disable loading default items for specific filters. You should use this option if you set the default filter value programmatically in a Workbook, and needs to ensure that default filter value settings from the Filter configuration or the Dimension access control configuration is ignored.

<br/>

#### Spreadsheets / tables

- **Fixed alignment issues in table and spreadsheet filter operators:** We fixed an issue with the alignment of items in the operator selection menu of table and spreadsheet components.

- **Incorrect summary details in spreadsheet status bar:** We fixed an issue where selecting cells multiple times, or selecting from right to left, caused the sum and average to be incorrect.

- **Flagging of “All” level in Ranked Input tables:** All cells in Ranked Input tables referring to the “All” level in dimensions are now prefixed with “*” to make it more clear to the user that an “includes everything” level has been selected.

<br/>

#### Package upgrade

- We fixed an issue where changes to the primary key of Data Stores and Tables did not trigger an update to the database table schema.

- We changed how Views and Compound Views are managed during Package upgrades so that invalid configurations will not cause an upgrade to fail.

<br/>

#### Dataflow

- **Execution stability:** We’ve fixed an issue that caused the Dataflow execution Worker process to randomly crash, leading to Dataflows appear as running forever.

- **Execution resiliency:** Previously, if the Worker process was terminated during Dataflow execution, the Dataflow would never reach the completed state. In 2023.6, the executing task is automatically resubmitted if the Worker process executing it terminates during execution. Normally, the resubmitted task should start executing within a minute.

- **Correct time zone handling when scheduling Dataflows from Workbook:** We now handle time zones correctly when scheduling Dataflow runs from the Workbook scheduler component. This issue affected users sitting in different time zones than the server running the task.

#### Theme changes

We’ve made the following changes to the default Workbook theme:

- Changed the color of the Workbook application bar to a darker blue color.

- All icons / images are now blue instead of gray. If you need a different color, create a custom theme and override the –icon-color css variable.

- Changed the background selected color of row and column headers in spreadsheets from light gray to light blue.

- Changed the background color of row and column headers in spreadsheets from light gray to white.

- Changed the font color of row and column headers in spreadsheets to a lighter black.

- Changed the color of all borders to a lighter gray color.

<br/>

### See Also
- [Change Log 2025.1](changelog25_1.md)
- [Change Log 2024.4](changelog24_4.md)
- [Change Log 2024.3](changelog24_3.md)
- [Change Log 2024.2](changelog24_2.md)
- [Change Log 2024.1](changelog24_1.md)
- [Change Log 2023.7](changelog23_7.md)
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
- [Change Log 2022.1](changelog22_1.md)
- [Change Log 5.2](changelog52.md)
- [Change Log 5.1](changelog51.md)
- [Change Log 5.0](changelog5.md)
- [Change Log 4.1](changelog41.md)
- [Change Log 4.0](changelog40.md)

<br/>
