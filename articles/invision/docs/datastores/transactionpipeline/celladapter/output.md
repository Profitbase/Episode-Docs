---
title: "Output"
metaKeys: "Output, data, format, Cell Adapter, component, row, Ruleset, Properties, Target, Value Column, Trans Date, Computation, Source Name, Additional, mapping, Routed"
pageIndex: 3
---


The Output specifies the data and output format of the Cell Adapter component. The Cell Adapter component will create one output row for each matched Ruleset row.
<br/>

### Properties:

*	**Target** 

 The Data Store or Setting table where the output is saved.

*	**Value Column**

 The column in the Target where the values of the Computation Source Columns are saved.

*	**Trans Date Column**

 The column in the Target where the Date represented by the Computation Source Column (of type Time Frame Measure Column) is saved.

*	**Source Name (Optional)**

 The column in the Target where the name of the data source is saved.

*	**Source Column**

 The column in the Target where the name of the Computation Source Column is saved.

*	**Additional Output**

 Specifies the mapping between source columns from the source data set to include in the output in addition to the standard values listed above. The source columns in this list must be members of the Relationship or Additional columns lists.
 If the Target contains **Data Context Delegation** columns (columns with a _DCD postfix) for any of the columns listed in this section, the system will automatically add a mapping to the Data Context Delegation columns if such mapping is not already specified.

*	**Routed Values**

 Specifies the mapping between any columns in the Ruleset to include in the output in addition to the values from the data source.
