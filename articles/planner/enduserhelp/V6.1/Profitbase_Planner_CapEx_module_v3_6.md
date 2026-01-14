# CapEx module

Profitbase

09.09.2025

Version 3.6

---

## Abstract, intended audience and pre-requisites

The Profitbase Planner Configuration and Operation series consist of several documents dealing with the configuration and operation of individual Planner modules and functions.

The intended audience of this document is implementation partners configuring the solution initially and solution administrators responsible for operating it thereafter.

This document assumes that a Profitbase Planner solution has been deployed and that access to this solution is given to the reader.

The CapEx module is included as a standard Profitbase Planner module.

---

## Common functionality

Changes made to input sheets are not saved automatically. To save changes, click the “Save” button. The “Save” button will remain disabled until a change has been made.

To undo all unsaved changes, click the “Refresh” button.

To undo the last of a series of unsaved changes, click the Ctrl and Z keys simultaneously.

To insert new rows to an input sheet, right-click in the sheet and select one of the available options:

- Insert row  
- Insert row below  
- Insert copy of row  

To delete a row from an input sheet, right-click the row in question and select:

- Delete row  

Inserting and deleting rows can be controlled as part of the configuration, see Publish and name module, control row context right-click menu options.

Please note, that although the row is no longer visible in the input sheet, the change must be committed using the “Save” button or undone using the “Refresh” button.

In input sheets, editable fields are distinguished from non-editable fields by fill color, editable fields have by default a white fill color.

In setting tables, a so-called ranked input concept is often used for the dimensional context. Ranked input allows for a high-level selection of dimensional nodes and gives the opportunity to alter the rank or specificity between rows.

A ranked input cell can be set through the ranked input selector by clicking the cell value (cell will display 3 dots if no value is set):

[IMAGE PLACEHOLDER: ranked input selector cell]

The ranked input selector will display the dimensional hierarchy and allows for the selection of a high-level dimensional node. The selection of a high-level node implies that the setting applies to all sub-ordinate nodes.

Select node and click “OK”.

Click “Cancel” to leave the selector without selecting.

In a table containing multiple rows, the rank or specificity of individual rows can be altered by moving the row up (decrease specificity) or down (increase specificity) by right-click the row in question and selecting:

- Move up  
- Move down  

The less specific the setting is, row should be high up in the table. The more specific the setting is, the further down in the table the row should reside.

---

## Principle of operation

The CapEx module provides an input sheet for contributors to plan investments and based on it, it will generate depreciation cost and maintain the balance accounts associated with the investments.

### Plan by individual year

Investments are input by individual year by selecting the year in question from the filter dropdown list of years:

[IMAGE PLACEHOLDER: year selection filter]

For new years, it may be relevant to copy data from a previous year. This can be done by accessing the “Copy data…” button. This will reveal a popup in which year can be selected:

[IMAGE PLACEHOLDER: copy data popup]

Older data can be deleted in the “Setup” page by clicking the “Delete data…” button to reveal the following dialogue:

[IMAGE PLACEHOLDER: delete data dialog]

---

### Flexible organizational input level

Investments can be input from anywhere in the organizational dimension. Each investment must, however, be attached to a department.

If a department is selected when input is done, this department is automatically assumed to be the department for the investment.

If at a higher level, the legal entity and department columns are automatically visible and relevant values must be selected from the dropdown lists attached to the columns:

[IMAGE PLACEHOLDER: legal entity and department columns]

Click the icon to view the transactions generated from the row in question.

[IMAGE PLACEHOLDER: generated transactions view]

---

### Flexible input sheet

#### Input columns

Depending on the familiarity of contributors with investments, asset accounts, depreciation rates and so on, the input sheet may be configured differently.

By default, the depreciation rate and the start date for depreciation are input fields:

[IMAGE PLACEHOLDER: default depreciation input fields]

This can be changed so that the contributor selects from asset groups for which depreciation rates and accounts are automatically associated.

For details on defining input columns, please refer to Column setup for details.

For details on detailing settings per asset group, please refer to Settings for details.

---

### Dimensionality

The basic dimensionality of the CapEx module is department and individual.

Extra dimensionality may be added as needed, please refer to Dimension setup for details.

#### Change dimensionality of an input row

The current dimensionality of an existing input row may be changed (subject to the configuration, see Publish and name module, control row context right-click menu options by right-clicking the row in one of the dimensional columns and selecting “Change dimensionality”. This will reveal a pop-up in which a new dimensionality can be set:

[IMAGE PLACEHOLDER: change dimensionality popup]

---

### Investment status

An investment status table can be defined with behaviors such as include in plan which determines whether investments of a certain status is to be included in the plan or not.

Please refer to Investment status for details.

---

## Module configuration

### Publish and name module, control row context right-click menu options

Select the “Input Settings and Administration” workbook and go to the “Setup” page, and edit the “Input modules” table:

[IMAGE PLACEHOLDER: input modules table]

| Column | Description |
|------|-------------|
| Input module | The name of the input module. |
| Published | Indicates that the input module is Published or not. |
| Description | The module’s default name. |
| New | Insert new row and Insert copy of row allowed or not. |
| Delete | Delete row allowed or not. |
| Delete (act. = 0) | Delete row allowed only if row contains no actuals. |
| Ch. dim. | Change dimensionality allowed or not. |
| Ch. dim. (act. = 0) | Change dimensionality only if row contains no actuals. |
| Multi-dept. input | Always true for this module. |
| Input row limit | Max. row limit returned that allows input. |
| Auto load on filter chg. | Data loaded automatically on filter change. |
| Auto submit data | Always true for this module. |

---

### Setup of the CapEx module

The CapEx module is configured in the “Setup” page of the “CapEx” workbook. In the “Setup” page, select the “Input model” tab:

[IMAGE PLACEHOLDER: CapEx setup input model tab]

The module can be published by checking the “Published” checkbox and clicking the “Save” button. Conversely, the module can be taken offline by unchecking the “Published” checkbox.

---

### Column setup

The module contains several input columns that may or may not be used depending on what kind of loan functionality is relevant by selecting and/or deselecting input columns.

The following columns are always present and thus not available for selection:

- **Text**: The investment name or description. Mandatory.  
- **Amounts (per month)**: The investment (acquisition) amount for the month in question. Mandatory.

The columns available for selection are selected in the “Column setup” table:

| Column | Description |
|------|-------------|
| Column Name | The internal column id. Preset. |
| Description | The column’s default heading. |
| Visible worksheet | Indicates whether the column is visible in the input sheet. |

AccountID: the asset account override, column is default not visible.  
DaysOfCredit: the number of days of credit for the investment, column is default not visible.  
DepreciationDateOvr: the date for start of depreciation, column is default visible.  
DepreciationPctOvr: the depreciation rate override, column is default visible.  
ExternalRefID: use when appropriate, column is by default not visible.  
InvestmentStatusID: Investment status dropdown, column is by default visible.  
VatPctOvr: the VAT rate override, column is by default not visible.

---

### Dimension setup

There is a pre-set number of dimensions to select and name.

Note the “Asset group” dimension.

| Column | Description |
|------|-------------|
| DimensionColumn | The dimension column id. |
| Visible | Indicates that the column is visible and editable. |
| Mandatory | Indicates that this dimension is mandatory. |
| Visible as filter | Indicates whether dimension is also an input filter. |
| Filter selection mandatory | Indicates whether filter value is mandatory. |
| Default filter value | Allows for a default filter value. |
| Group source data | Not relevant for this module. |

---

### Investment status

Investment statuses can be used to filter out certain investment.

| Column | Description |
|------|-------------|
| InvestmentStatusID | The investment status id. |
| Description | The column’s default heading. |
| Initial value | Default status when added. |
| Include in plan | Indicates inclusion in plan. |

---

### Translations

Translations are added in the Translations tab in the Input Settings and Administration workbook.

Select CapEx as the Input module and the language of choice.

Edit the Lang Text column of an item or add an item.

---

## Settings

The investment settings are defined in the “Setup” page of the “CapEx” workbook. Select the “Settings” tab:

[IMAGE PLACEHOLDER: CapEx settings tab]

### Investment Depreciation

This setting table defines the rules for looking up depreciation rates and associated accounts.

| Column | Description |
|------|-------------|
| Legal entity | Mandatory. Ranked input. |
| Asset group | Mandatory. Ranked input. |
| From date | Mandatory. |
| Depr % | Mandatory. Numeric. |
| Declining | Declining balance or straight line. |
| Y1 = full year | Full year depreciation in Y1 or not. |
| Residual value | Residual value. |
| Account | Depreciation account. |
| CAccount | Counter account. |
| Comments | Optional comment. |

---

### Investment Accounts

| Column | Description |
|------|-------------|
| Legal entity | Mandatory. Ranked input. |
| Asset group | Mandatory. Ranked input. |
| Fixed asset | Asset account. |
| AP | Accounts payable account. |
| AgioDis | Optional agio / disagio account. |
| Comments | Optional comment. |

---

### Declining Balance StopValue

DecliningBalanceStopValue is setting the current lowest residual value of fixed assets.

| Column | Description |
|------|-------------|
| Legal entity | Mandatory. Ranked input. |
| From date | Mandatory. |
| Stop value | Mandatory. Numeric. |
| Comments | Optional comment. |

---

