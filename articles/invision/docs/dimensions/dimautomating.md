# Dimension automating


<br/>


>[!NOTE]
> A faster way to import data into a dimension is by using the Flow Action: [Import Data to Dimension](../../../flow/actions/profitbase-invision/import-data-to-dimension.md). This method allows direct importing from an IDataReader or DataTable, which typically originates from a database table or a file (Excel, Parquet, CSV). It bypasses the need for staging tables and Dataflows, streamlining the process by enabling direct data imports, saving time and reducing complexity.

## Automating import of data to dimensions

You can import data to dimensions through Dataflows and staging tables. 

1. Create a table containing the columns you want to import into the dimension. **The columns in the staging table must match the dimension table columns by name and data type**. 
> [!NOTE]
> That the staging table does not need to contain all the columns in the dimension. It only needs to contain the columns that you want to import. To view which columns the dimension table contains, press “Browse P/C table” in the dimension editor in the Designer.

2. Create a Dataflow Item and add the **Import dimension members** task from the **Dimension Tasks** in the toolbox. Specify the name of the staging table and the name of the dimension. You can also specify whether to overwrite changes made by the user and whether blank cells should be ignored during the import.

<br/>

![Dimension](https://profitbasedocs.blob.core.windows.net/images/DimNy9.png)

<br/>

3. Create a Dataflow and run the Dataflow Item from step 2.

<br/>

## Automating Import of the Primary Dimension

You can pull in a dimension definition (including data) from a different solution. You can do that by using dataflows. This means that you can automatically copy the data and configuration of a Primary Dimension into another Solution (usually a versioned Solution).
1. Create a Dataflow and Dataflow Item in the target solution. The primary dimension is imported into the target.
2. Add the Import Primary Dimension task from the Dimension Tasks in the toolbox.

<br/>

![Dimension](https://profitbasedocs.blob.core.windows.net/images/DimNy10.png)

<br/>

3. Specify the name of the primary dimension and optionally the name of the target dimension. If no target dimension is specified, it is assumed to equal the name of the primary dimension. 
4. Run the Dataflow Item in a Dataflow.

<br/>

