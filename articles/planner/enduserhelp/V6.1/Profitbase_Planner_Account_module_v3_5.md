# Account module

**Profitbase**

26.05.2025  
Version 3.5

---

## Abstract, intended audience and pre-requisites

The Profitbase Planner Configuration and Operation series consist of several documents dealing with the configuration and operation of individual Planner modules and functions.

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

Inserting and deleting rows can be controlled as part of the configuration, see *Publish and name module, control row context right-click menu options*.

Please note, that although the row is no longer visible in the input sheet, the change must be committed using the “Save” button or undone using the “Refresh” button.

In input sheets, editable fields are distinguished from non-editable fields by fill color, editable fields have by default a white fill color.

In setting tables, a so-called ranked input concept is often used for the dimensional context. Ranked input allows for a high-level selection of dimensional nodes and gives the opportunity to alter the rank or specificity between rows.

A ranked input cell can be set through the ranked input selector by clicking the cell value (cell will display 3 dots if no value is set):

`[IMAGE PLACEHOLDER: ranked input selector cell]`

The ranked input selector will display the dimensional hierarchy and allows for the selection of a high-level dimensional node. The selection of a high-level node implies that the setting applies to all sub-ordinate nodes.

Select node and click “OK”.

Click “Cancel” to leave the selector without selecting.

In a table containing multiple rows, the rank or specificity of individual rows can be altered by moving the row up (decrease specificity) or down (increase specificity) by right-click the row in question and selecting:

- Move up  
- Move down  

The less specific the setting is, row should be high up in the table. The more specific the setting is, the further down in the table the row should reside.

---

## Principle of operation

### Plan by year-totals or by month

The plan can be input as year-totals or as monthly values. This is controlled by the “Periods” button that toggles the input mode correspondingly:

`[IMAGE PLACEHOLDER: Periods button toggle]`

A year-total input is automatically spread to the plan months of that particular year. The total is spread according to the monthly distribution function tied to the account as follows:

- If a specific monthly input has been made by the user, the distribution inherent in the monthly values is used as a distribution key.
- If not, then if a central distribution key is tied to the account, this distribution will be used

The existence of a central distribution key is indicated by the following symbol:

`[IMAGE PLACEHOLDER: distribution key symbol]`

Click on the symbol to view the distribution key.

Please refer to *Distribution keys* for details on how to set up central distribution keys.

If none of the above applies, the total is spread evenly over the plan months.

If monthly values are input directly, the individual monthly values in a year are summed and the distribution used thereafter for year-total input will be the distribution inherent in those individual monthly values as edited by the user.

Note that you can also see the distribution of any historical and plan sets, by clicking the symbol. The result is displayed in a pop-up where you can toggle between % and absolute numbers:

`[IMAGE PLACEHOLDER: distribution popup]`

Note that you can also restore the default distribution for any row or collection of rows by right clicking the following column and select “Restore default key”. This can either be done on a specific row or on the upper-most total-row to be able to select multiple rows:

`[IMAGE PLACEHOLDER: restore default key option]`

Selecting “Restore default key” on the upper-most total-row, presents a pop-up where a selection of rows can be done. Only the rows eligible for restoring the default key i.e., rows where the user has overridden the key, are shown:

`[IMAGE PLACEHOLDER: restore selection popup]`

---

## Dimensionality

The basic dimensionality of the account module is department and account.

Extra dimensionality, Project, Activity, Counterpart and 4 free dimensions Dim1, Dim2, Dim3 or Dim4 may be added as needed.

The account module can also be set up for planning in multiple currencies by enabling the Currency foreign dimension.

Please refer to *Select additional dimensionality* for details.

### Change dimensionality of an input row

The current dimensionality of an existing input row may be changed (subject to the configuration, see *Publish and name module, control row context right-click menu options*) by right-clicking the row in one of the dimensional columns and selecting “Change dimensionality”. This will reveal a pop-up in which a new dimensionality can be set:

`[IMAGE PLACEHOLDER: change dimensionality popup]`

---

## Historical references and deviation calculations

The Account module is preset with the last 12 months of actuals, except if the following base setting is set to FALSE:

`[IMAGE PLACEHOLDER: base setting AccountIgnoreActualsL12M]`

Base setting AccountIgnoreActualsL12M (TRUE | FALSE), default FALSE controls if actuals last 12 months are loaded or not to the account module.

In addition to the above, up to 5 historic reference columns (e.g. last year’s budget) may be added as needed.

Simple deviation calculations – columns that perform calculations between other columns present in the input sheet – may be added.

---

## Planning horizon

The planning time horizon is controlled in the Finance Settings workbook:

`[IMAGE PLACEHOLDER: Finance Settings planning horizon]`

This time horizon applies to all input modules.

Long-term planning allows for a year-total input only. When saving the plan, the long-term year-totals are automatically distributed to months using the distribution that is relevant to the next year’s plan for the corresponding dimensionality.

---

## Module configuration

### Publish and name module, control row context right-click menu options

Select the “Input Settings and Administration” workbook and go to the “Setup” page, and edit the “Input modules” table:

`[IMAGE PLACEHOLDER: Input modules setup table]`


---


