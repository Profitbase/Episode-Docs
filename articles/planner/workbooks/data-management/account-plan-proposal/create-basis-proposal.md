---
title: "1. Create basis proposal"
metaKeys: ""
folderOnly: "false"
pageIndex: 1
---


## Overview

This is the main screen for defining the basis proposal. A quick guide to the process is shown in the workbook itself.

<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/account-plan-proposal-create-basis.JPG)

Although there are many options, the only mandatory step is to define which source dataset(s) constitute the proposal. 

This is done in the "Map source datasets to plan" table.

Once, the "map source datasets to plan" table is set up, consider the other options described further down.

To finish off the basis proposal section, click the "Create basis proposal" button. This will produce the basis proposal that will be found on the following page [2. Adjust basis proposal and import](adjust-basis-proposal-and-import.md) and can be further detailed and finally imported there.

## Map source datasets to plan

This screen defines how the plan will be pre-filled with data from the source dataset(s). In its simplest form, the plan is filled from a specific source dataset, for example using the source dataset constituted by last year's actuals:

<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/map-source-datasets-to-plan.JPG)


Now, in more complex situations, different parts of the plan (as in different parts of the organization and/or different time periods within the plan's total time frame) may take their proposal from different source datasets.

This can be achieved by detailing the "Map source datasets to plan" table with multiple rows defining specific source datasets to be used for specific parts of the plan, for example letting the proposal for legal entity "Profitways Focus AS" be sourced from this year's Budget in stead: 

<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/map-source-datasets-to-plan2.JPG)


#### Columns

- **Plan - Legal Entity**<br/>
The part of the organization that this source dataset mapping applies to. Note that a hierarchical selection (ranked input) applies. Please refer to the general description of ranked input selection [Common functionality](../../../getting-started/common-functionality.md) 
- **Plan - From date**<br/>
The (plan) date from which this source dataset mapping applies to. Note that the from date should be within the plan's time frame and will normally equal the start of the plan.
- **Source - From date**<br/>
The (source) date from which the proposal is drawn.
- **Source - Dataset**<br/>
The (source) dataset from which the proposal is drawn. Select from the drop down that will include standard datasets such as Actuals as well as plan versions that are made available for use. 

### Options

#### Limit data from source

In most cases, the use of the account module is limited to operational expenses as other more specific modules such as driver based and personnel are used for sales, payroll and so on. 

In such cases, it is highly recommended to limit the proposal data drawn from the source so that data only corresponding to the input report lines that corresponds to the use of the account module is included in the proposal. 

This can be done by clicking the "Limit data from source" button.

Refer to [Limit data from source](limit-data-from-source.md)

#### Account - dimensions

When creating the proposal, it is recommended to review the account module dimensions settings for the current version. Specifically, the level of details used, i.e. which optional dimensions are visible, and more specifically whether or not details for any of those optional dimensions should be drawn from the source. 

Keep in mind that using one or optional dimensions and grouping source data on those optional dimensions will create a potentially very detailed proposal with potentially large amounts of data. 

It is highly recommended to limit the level of detail as much as possible.

This can be achieved in the "Account - dimensions" screen by:

1. Un-checking any optional dimensions that are not required.
2. Un-checking the "Group source data" option for any optional dimensions that must be included but where it is not absolutely required to detail the proposal on those dimensions from the source. For example, even though the project dimension may be required for input in the plan, it may not be required to group source data by projects. If Group source data is unchecked, the proposal is aggregated, i.e. not grouped by the dimension in question, resulting in a less detailed proposal with less amounts of data.

![](https://profitbasedocs.blob.core.windows.net/plannerimages/account-dimensions.JPG)

#### Override dataset mapping

Although the "Map source datasets to plan" definition outlined above will normally suffice, cases may exist where it is necessary to override this mapping for certain parts of the organization, for example for a new department for which no source data exists and where the source of the proposal may in fact be taken from another, comparable, department. Such overrides may be set by clicking the "Override dataset mapping" button.

Refer to [Override dataset mapping](override-dataset-selection.md)

#### Set adjustment factors

By default, a 1:1 relationship is made between the amounts in the source datasets and what will constitute the proposed amounts. In some cases, however, it may be required to adjust those amounts, for example accounting for general changes in consumption prices or expectations for the future. Such factors can be set, by clicking the "Set factor adjustments" button.

Refer to [Set adjustment factors](set-factor-adjustment.md)

