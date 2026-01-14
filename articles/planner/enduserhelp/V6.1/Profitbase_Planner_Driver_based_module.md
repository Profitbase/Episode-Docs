# Driver based module

Profitbase

09.09.2025

Version 3.6

---

## Abstract, intended audience and pre-requisites

The Profitbase Planner Configuration and Operation series consists of several documents dealing with the configuration and operation of individual Planner modules and functions.

Planner modules are operational input modules that contributors to the plan processes use to prepare the Profit & Loss (P&L) of their respective areas of responsibility. Different modules will typically cover parts of the P&L such as sales, personnel, cost, etc.

The modules are accessed from the Plan overview workbook of a given version and the input provided by the contributors are transformed into P&L transactions and fed back to the Plan overview workbook resulting in a P&L work-in-progress overview.

The intended audience of this document is implementation partners configuring the solution initially and solution administrators responsible for operating it thereafter.

This document assumes that a Profitbase Planner solution has been deployed and that access to this solution is given to the reader.

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

Inserting and deleting rows can be controlled as part of the configuration, see Control row context menu options (right-click).

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

### Driver based models

The driver-based module uses as the name suggests a driver-based principle.

Multiple models consisting of measures may be defined. Common to all models is the definition of one of the measures as the driving measure for that model.

[IMAGE PLACEHOLDER: driver measure overview]

Examples of driving measures may be Sales quantity, Sales volume, FTE (Full Time Equivalents) and so on.

Click the icon to view the P&L transactions generated from the row in question.

Additional measures make up the detail model and may take direct input, be lookups to assumptions and calculations of other measures.

Click the icon for the row in question to view the detailed model.

Measures will render as rows of the model, for example:

[IMAGE PLACEHOLDER: model measures rows]

For details on how to set up a model, refer to Define models.

Measures to which a distribution function is associated is identified by the icon.

Note that it is possible to click the icon to view the distribution and any default distribution if it exists.

[IMAGE PLACEHOLDER: distribution icon popup]

A year-total input is automatically spread to the plan months of that particular year. The total is spread according to the monthly distribution function tied to the product and market as follows:

- If a specific monthly input has been made by the user, the distribution inherent in the monthly values is used as a distribution key.
- If not, then if a central distribution key is tied to the account, this distribution will be used.
- If none of the above applies, the total is spread evenly over the plan months.

Please refer to Distribution keys for details on distribution keys.

Measures that are lookup to assumptions are identified by the icon.

Note that it is possible to click the icon to view the assumption values and to override the assumption values and reset to the default if overridden if the model allows.

[IMAGE PLACEHOLDER: assumptions lookup]

An overridden assumption is marked by a blue left border indication.

Please refer to Assumptions for details on assumptions.

Measures that are calculations are identified by the icon.

Note that it is possible to click the icon to reveal the formula and a formula description if set:

[IMAGE PLACEHOLDER: calculation formula popup]

A formula that is not executed automatically but requires the click on the “Recalculate” button is marked with a red left border indication.

Please refer to Define calculations for details on calculations.

---

## Dimensionality

The basic dimensionality of the driver based module is department, product, and market.

Extra dimensionality may be added:

- Employee  
- Supplier  
- Project  
- Activity  
- Counterpart  
- Dimensions Dim1 to Dim4  

For details on defining dimensionality, refer to Define dimensionality.

---

## Historical references

The models are preset with the last 12 months of actuals.

In addition to the above, up to 5 historic reference columns may be added as needed.

For details on defining historical reference columns, refer to Define historical reference columns.

---

## Planning horizon

The planning time horizon is controlled in the Finance Settings workbook:

[IMAGE PLACEHOLDER: Finance Settings planning horizon]

This time horizon applies to all input modules.

Long-term planning allows for a year-total input only. When saving the plan, the long-term year-totals are automatically distributed to months using the distribution that is relevant to the next year’s plan for the corresponding dimensionality.

Note that there is also a period filter setting that you may want to consider if you change the plan horizon.

---

## Plan roll forward actions

The input module will be updated with source data when rolling forward.

Any new combinations that exist in the driver source fact data will automatically be processed into the input module and their last 12 months actuals updated.

---

## Model configuration

Driver based models are configured in the “Driver based modelling” workbook and the “Models” page.

[IMAGE PLACEHOLDER: Driver based modelling workbook]

Multiple input models can be created and published to users.

---

## Input models

### Create a new input model

To create a new model, click the “New …” button.

In the dialogue, enter a model id and a model default name.

[IMAGE PLACEHOLDER: new model dialog]

If relevant, select an existing model to copy from and select whether to copy only the model and settings or the input data as well.

Click “Confirm”.

---

### Process an input model

Processing a model will re-generate any P&L transactions from the model.

Processing is done by clicking the “Process” button.

---

### Delete an existing input model

An input model can be deleted by clicking the “Delete …” button.

Options include:

- Delete data  
- Delete model and settings  

---

### Publish an input model

To publish a model, check the “Published” checkbox and click the “Save” button.

A model that is not published will not be editable by users.

---

### Edit input model properties

The input models are defined in the following table:

| Column | Description |
|------|-------------|
| Measure | MeasureID. Mandatory. |
| Description | Default description. |
| Driver | Measure is the driver. |
| Input | Open for input. |
| Lookup | Lookup assumption. |
| Calc | Calculated measure. |
| Calc. order | Calculation order override. |
| Set | Calculation setup link. |
| Total across periods | Sum or Average. |
| Rollup | Sum or Average. |
| Format | Number display format. |
| Style | Row style. |
| Sorting | Display and calc order. |
| Excl. from trans. | Exclude from transactions. |

---

## Define calculations

Two types of calculations exist:

- Cell-calculations  
- Button-click calculations  

Button-click calculations require the “Recalculate” button.

[IMAGE PLACEHOLDER: calculation dialog]

---

## Define dimensionality

The dimensionality of a model is defined in the following table:

| Column | Description |
|------|-------------|
| DimensionColumn | Dimension column id. |
| Visible | Visible in input sheet. |
| Mandatory | Mandatory selection. |
| Visible as filter | Visible as slicer. |
| Default filter value | Default value. |
| Group source data | Group source data. |
| Sorting | Optional sorting. |
| Comment | Optional comment. |

---

## Define attributes

Up to two attributes can be used in any one driver based model.

Attributes are not part of the uniqueness of an input row.

[IMAGE PLACEHOLDER: attributes setup]

---

## Define historical reference columns

The historic reference columns of a model is defined in the following table:

| Column | Description |
|------|-------------|
| Column Name | Historic1–Historic5 |
| DatasetID | Dataset origin |
| From Date | Start date |
| To Date | End date |
| Use relative dates | Relative dates |
| Description | Default name |
| Visible | Visible in input |

---

## Define deviation columns

Deviation columns are defined in the following table:

| Column | Description |
|------|-------------|
| Column Name | Deviation1, Deviation2 |
| Formula | Calculation formula |
| Visible drivers | Visible in drivers |
| Visible details | Visible in details |

---

## Select / unselect optional columns

Optional columns related to actuals and plan periods can be selected per model.

---

## Translations

Translations are added in the Translations tab of the Input Settings and Administration workbook.

---

## Define measures

Measures are defined in the “Measure” page.

[IMAGE PLACEHOLDER: measures table]

---

## Attach module to input report

The module can be attached to one or more report lines in the Plan Overview report.

---

## Period filters

Period filters are configured in the Input Settings and Administration workbook.

---

## Control row context menu options

Row context menu options such as New, Delete and Change dimensionality can be controlled.

---

## Multi-department input

Allows input at higher-level department nodes.

---

## Auto submit data

Controls whether Save automatically submits data.

---

## Settings

### Assumptions

Assumptions are lookup values maintained in the Assumptions tab.

---

### Distribution keys

Distribution keys are maintained in the Output tab.

---

### Measure to account mapping

Measures that generate P&L transactions must be mapped to accounts.

---

### Auto transactions

Auto-transactions trigger additional transactions based on user input.

---

## Advanced – engine interface

Advanced mapping of measures to transaction columns.

---

## Exclude measures from engine

Measures can be excluded from financial engines.

---

## Advanced – linked models

Models can be linked so that one model triggers processing of another.

---

## Data management

### Dimensions

Dimensions are maintained in the Dimensions workbook.

---

### Source fact data

Historical data is maintained in the Source fact data workbook.

---

### Using Personnel fact source

Personnel fact source may be used for plan proposals.

---

