
# Stacked Column Headers

Stacked Column Headers enables multiple rows of headers by grouping and stacking them on top of eachother.  

Stacked Column Headers are configured from the Stacked Columns editor in the Worksheet or Report Table Designer.
<br/>

In addition to the grouping headers, the Stacked Column Headers configuration must contain all the baseline columns of the Worksheet or Report at the lowest level of the stack. If you modify the Worksheet or Report by removing, adding or renaming baseline columns, you must update the Stacked Column Headers configuration accordingly.
<br/>

To create a Stacked Column Headers configuration, start by creating a "New Configuration". This will add all the baseline columns from the Worksheet or Report to the configuration. 

To create a grouping column, press "Add Stack Root" and set values for the properties. You need to ensure that all Key properties within the stacking configuration is unique.  

To group the columns, move the baseline columns by dragging and dropping them to grouping columns.

<br/>

You can create multiple levels of grouping columns, but the baseline columns must always be at the lowest level of a branch.

![sc](https://profitbasedocs.blob.core.windows.net/images/stacked.png)