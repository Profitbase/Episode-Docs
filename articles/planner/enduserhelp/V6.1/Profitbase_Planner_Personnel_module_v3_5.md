# Personnel module

Profitbase

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

The Personnel module provides an input sheet for contributors to plan their FTEs (Full Time Equivalents) and HCs (Headcounts) and associated cost and from it creates P&L transactions for payroll related expenses including associated social cost such as vacation pay, employer tax, pension cost and so on.

---

### Driver-based

The Personnel module uses a driver-based principle in which FTEs (Full Time Equivalents) or HCs (Headcount) are the drivers subject to the configuration used.

The FTE/HC is maintained in the FTE or HC pages respectively:

[IMAGE PLACEHOLDER: FTE and HC pages]

Any user input is thus provided per FTE/HC per month.

This further implies that periodic spread keys are used (as opposed to distribution keys) to lay out the per-FTE/HC-per-month input values over time:

[IMAGE PLACEHOLDER: periodic spread keys]

An input value translates to a Profit & Loss amount for a given month as:

[Input amount] * [FTE/HC for the month] * [Periodic spread key for month]

In the case of April 2020 for employee Lisa:

4000 * 1 * 1 = 4000

Click the icon to view the P&L transactions generated from the row in question.

[IMAGE PLACEHOLDER: P&L transactions icon]

---

### Plan by individual and/or groups

The planning dimensionality used comprise of the Department and Employee dimensions and optionally dimensions as outlined in Select additional dimensionality.

Note that the Employee dimension may be set up with individuals or groups or a combination of the two:

[IMAGE PLACEHOLDER: employee hierarchy]

As Personnel-related settings are differentiated by the Employee dimension hierarchy, it is advisable to use appropriate group levels in the dimensional hierarchy.

For details on dimension maintenance and personnel source data, please refer to Data management.

---

### Salary calculation and distribution

Salary is always driven by FTE.

Specific to the salary calculation, is the annual salary increase and for which month in the year it occurs.

The Base monthly salary is the (average) monthly salary at the start of the plan and will be automatically updated when rolling over to a new year.

The salary raise – percentage and raise month - may be set centrally with the option of local adjustment or not:

[IMAGE PLACEHOLDER: salary raise settings]

These settings may be differentiated using more specific Department levels (and optionally employee).

The input Base monthly salary is spread, taking into account the raise settings, based on the Annual Salary spread key:

[IMAGE PLACEHOLDER: annual salary spread key]

If vacation pay is relevant, the Annual Salary key should reflect this by setting the key for the vacation pay month(s) to a value between 0 and 1.

For situations in which the vacation does not reflect exactly one month, the “Reduction vac. Pay factor” in the “General Settings” may be used.

Salary for vacation months is calculated as:

[FTE July] * [Base Mth. Salary] * (100 + [Raise 2020])/100 * [1- Annual Salary Spread key July 2020] * [Reduction vac. Pay factor] * -1

Example employee Lisa:

1 * 30000 * ((100 + 2)/100) * (1 – 0) * 0.1363 * -1 = -4171

---

### Dimensionality

The basic dimensionality of the personnel module is department and employee.

Extra dimensionality, Project, Activity, Counterpart and 4 free dimensions Dim1, Dim2, Dim3 or Dim4 may be added as needed.

Please refer to Select additional dimensionality for details.

---

### Attributes

Attributes define additional information associated with a row such as employment type.

Attributes are optional. Up to two attributes may be defined.

Please refer to Select and name input columns, set the driver for details.

---

### Change dimensionality of an input row

The current dimensionality of an existing input row may be changed by right-clicking the row in one of the dimensional columns and selecting “Change dimensionality”.

[IMAGE PLACEHOLDER: change dimensionality popup]

---

### Planning horizon

The planning time horizon is controlled in the Finance Settings workbook:

[IMAGE PLACEHOLDER: Finance Settings planning horizon]

This time horizon applies to all input modules.

Long-term planning allows for a year-total input only.

---

### Long-term planning

For long-term planning, input is done at department level:

- FTE for given year  
- Expected annual salary raise for given year  

The detailed plan for next year is used as a basis for scaling the long-term plan.

---

### Plan roll forward actions

The input module will be updated with source data when rolling forward.

New dimensional combinations will automatically be processed into the input module.

---

### Source data

Personnel source fact data must be kept current.

[IMAGE PLACEHOLDER: source fact data]

---

### Calculations

For rollover during a year, FTE and HC values are carried forward.

For rollover to new year:

- Base monthly salary is updated  
- Raise values are shifted  
- Long-term values are adjusted  

---

## Module configuration

### Publish and name module, control row context right-click menu options

[IMAGE PLACEHOLDER: input modules setup]

| Column | Description |
|------|-------------|
| Input module | Name of input module |
| Published | Published or not |
| Description | Default name |
| New | Allow insert |
| Delete | Allow delete |
| Delete (act. = 0) | Delete only if no actuals |
| Ch. dim. | Allow change dimensionality |
| Ch. dim. (act. = 0) | Change dim only if no actuals |
| Multi-dept. input | Allow higher-level input |
| Input row limit | Max row limit |
| Auto load on filter chg. | Auto load data |
| Auto submit data | Auto submit |

---

## Select additional dimensionality

[IMAGE PLACEHOLDER: select additional dimensionality table]

---

## Select and name input columns, set the driver

[IMAGE PLACEHOLDER: input column setup]

---

## Translations

Translations are added in the Translations tab.

---

## Attach module to input report

[IMAGE PLACEHOLDER: attach module to report]

---

## Define input column to account mapping

[IMAGE PLACEHOLDER: account mapping]

---

## Period filters

[IMAGE PLACEHOLDER: period filters table]

---

## Settings

### Payroll settings

[IMAGE PLACEHOLDER: payroll settings]

---

### Personnel: Accounts

| Column | Description |
|------|-------------|
| Legal entity | Ranked input |
| Dataset | Ranked input |
| Account | Ranked input |
| Employee | Ranked input |
| EP Tax | Target account |
| Pension | Target account |
| Vacation Pay | Target account |
| EPTOnVPay | Target account |
| Comments | Optional |

---

### Employer Payroll Tax %

[IMAGE PLACEHOLDER: employer tax table]

---

### Vacation Pay %

[IMAGE PLACEHOLDER: vacation pay table]

---

### Pension Employer %

[IMAGE PLACEHOLDER: pension employer table]

---

### Pension Employee %

[IMAGE PLACEHOLDER: pension employee table]

---

### Spread keys

[IMAGE PLACEHOLDER: spread keys table]

---

### General settings

[IMAGE PLACEHOLDER: general settings]

---

### Auto transactions (optional)

[IMAGE PLACEHOLDER: auto transactions table]

---

## Data management

### Employee dimension

[IMAGE PLACEHOLDER: employee dimension]

---

### Fact source data

[IMAGE PLACEHOLDER: personnel fact source]

---

