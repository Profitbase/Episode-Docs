# Additional dim. mapping - Edit selection

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2 or later.

## Overview

This page allows you to define the mapping between additional dimensions (to account) to the selected report line.

Note that an explicit mapping is required, i.e. all members of all additional dimensions that make up the mapping to the selected report line must be selected (i.e. the mapping is a strict include and no exclude).

To make the mapping as dynamic as possible, it is recommended to select aggregate nodes and to create appropriate aggregate nodes if needed. In the example shown below, the Product dimension serves as the additional dimension and the aggregate node Produkter is selected for selected report line Driftsinntekter:

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/AdditionalDimMapping2.JPG)

In the leftmost filtersection, available dimensions are displayed. Select appropriate dimension and browse.

Note that multi-select is supported.

Available dimensions and their names are defined in the Options page.

When selcting a node other than the all-level, the New selection and Current selection grids display data.

The New selection grid display the leaf nodes of the currently selected nodes. To make these overwrite the Current selection, click the Use new selection button.

To discard, simply select another dimension or exit the pop-up.

When satisfied with the changes made, click the Save button. This will take you back to the main additional dimension mapping page.

