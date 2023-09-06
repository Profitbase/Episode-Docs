---
title: "Ruleset"
metaKeys: "Override Setting, Factor Columns, Computation Source, Type Id Column, Distribution Key Column "
pageIndex: 2
---


The Ruleset table for the Distributer component contains the distribution keys and configuration used for distributing the values of Computation Source Columns to a Value-Transdate format over multiple rows. The table must have the following configuration:

*	**Distribution Key Column (Optional)**

 Specifies the column in the Ruleset that contains the distribution key identifier which extends the Relationship configuration for determining the distribution key used for distributing the value of a specific row. You should only use this option if you need to explicitly specify the distribution key to use in addition to the Relationship configuration.

*	**Type Id Column**

 Data type must be character based, for example nvarchar(50).

 A pipeline component iterates over the columns listed as **Computation Source Columns** in the component Input section and figures out which business rules to apply for generating output.

 Normally, every column in the list will have a separate rule set, and the TypeID column is used for specifying the rule set name. If you want to apply the same rule set to multiple Compuration Source Columns, you can use the same Type Id value for those columns.

 For example, if you want do distribute "YearTotal", and "NextYearTotal" the Type Id column of the Rulset would normally contain rows where the TypeId Column is "YearTotal" and "NextYearTotal" (in addition to any other Relationship keys). If, however, you wanted to use the same distribution key for both of the columns, you could just use a common value for both the "YearTotal" and "NextYearTotal" columns.

*	**Factor Columns**

 Specifies the columns of the Rulset that makes up the actual distribution key. As indicated, each value of a distribution key is a factor, so only the ratio between them matters, not the actual sum of the columns. (For example, the sum of the factor columns does not have to be 100 (%)). These columns must be **Time Frame Measure Columns** because they specify the date to use when date-value pairs are written to the target.

*	**Override Setting (Optional)**

 Specifies a Setting table that can contain distribution keys that overrides the master distribution keys. The table schema of the Override table must match the table schema of the master table, except for the Distribution Key Column that can be excluded.
