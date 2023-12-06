# 1. Create basis proposal
## Overview

This is the main screen for defining the basis proposal. A quick guide to the process is shown in the workbook itself

<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/driver-based-proposal-create-basis.JPG)

Although there are many options, the only mandatory step is to define which source dataset(s) constitute the proposal. 

This is done in the "Map source datasets to plan" table.

Once, the "map source datasets to plan" table is set up, consider the other options described further down.

To finish off the basis proposal section, click the "Create basis proposal" button. This will produce the basis proposal that will be found on the following page [2. Adjust basis proposal and import](adjust-basis-proposal-and-import.md) and can be further detailed and finally imported there.

## Map source datasets to plan

This screen defines how the plan will be pre-filled with data from the source dataset(s). In its simplest form, the proposal is made from a specific source dataset, for example using the source dataset constituted by last year's actuals:

<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/driver-based-proposal-map-source-dataset.JPG)


Now, in more complex situations, different parts of the plan (as in different parts of the organization and/or different time periods within the plan's total time frame) may take their proposal from different source datasets and also different source measures.

This can be achieved by detailing the "Map source datasets to plan" table with multiple rows defining specific source datasets to be used for specific parts of the plan, for example letting the proposal for legal entity "Profitways Focus AS" be sourced from this year's Budget in stead: 

<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/driver-based-proposal-map-source-dataset2.JPG)


## Columns

- **Plan - Legal Entity**<br/>
The part of the organization that this source dataset mapping applies to. Note that a hierarchical selection (ranked input) applies. Please refer to the general description of ranked input selection [Common functionality](../../../getting-started/common-functionality.md) 
- **Plan - From date**<br/>
The (plan) date from which this source dataset mapping applies to. Note that the from date should be within the plan's time frame and will normally equal the start of the plan.
- **Source - From date**<br/>
The (source) date from which the proposal is drawn.
- **Source - Dataset**<br/>
The (source) dataset from which the proposal is drawn. Select from the drop down that will include standard datasets such as Actuals as well as plan versions that are made available for use. 
- **Source - Measure**<br/>
The (source) measure will normally be the same as the measure that you are currently creating a plan proposal for but in some cases this may not be the case and a different source measure may be used. 

## Options

## Override dataset mapping

Although the "Map source datasets to plan" definition outlined above will normally suffice, cases may exist where it is necessary to override this mapping for certain parts of the organization, for example for a new department for which no source data exists and where the source of the proposal may in fact be taken from another, comparable, department. Such overrides may be set by clicking the "Override dataset mapping" button.

Refer to [Override dataset mapping](override-dataset-selection.md)

## Set adjustment factors

By default, a 1:1 relationship is made between the values in the source datasets and what will constitute the proposed values. The values may be amounts, quantities or similar depending on the nature of the measure. In some cases, however, it may be required to adjust those values, for example accounting for general changes in expectations for the future. Such factors can be set, by clicking the "Set factor adjustments" button.

Refer to [Set adjustment factors](set-factor-adjustment.md)

