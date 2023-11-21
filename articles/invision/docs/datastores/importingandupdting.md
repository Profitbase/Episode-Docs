
## Importing and Updating Data from Data Sources

Importing and updating data to a [Data Store](../datastores.md) can be set up as part of the star schema configuration, or you can write custom SQL scripts to do the job. Updating data to a Data Store from within InVision is usually done by executing one or more [Data Flows](../dataflows/index.md) that performs the update logic defined by the star schema, or runs your custom SQL script. 

Using the the data import / update part of the star schema configuration, you define properties for filtering data to import, transformations (pivot, unpivot, aggregate), conversions, calculations and data set compilation using the [Core Set](coreset.md) feature.

<br/>

#### See Also 

* [Binding Source Columns to DS Columns](importingandupdting/bindingsourcecoumns.md)

* [Customization Options](importingandupdting/customization.md)
  
* [Source](importingandupdting/source.md)
