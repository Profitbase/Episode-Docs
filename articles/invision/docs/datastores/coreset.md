
# Core Set

The Core Set feature is used for generating rows based on the content of dimensions or fact type data sources specified as Core Set members, which does not already exist in the [Data Store](../datastores.md). The Core Set basically defines which rows should always be present in the [Data Store](../datastores.md), regardless of whether it exists in the fact source(s) or not. 

When the Core Set has more than one member, the data set produced by the Core Set feature is the Cartesian product of the rows from all the Core Set members.

The Core Set feature runs after a reload or update, so rows produced by the Core Set will only be added to the Data Store if they have not been added during previous steps. The Core Set feature uses the relationship bindings of the Data Store to determine whether a row should be added or not.

For example, suppose you have the following 2 rows in the [Data Store](../datastores.md). The rows were originally imported from a fact source, meaning the fact source only contains two rows.
<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/coreSet.png)

<br/>


| AccountID 	| ProductID 	| Amount 	| Deviation 	|
|---------------	|-----------	|--------	|-----------	|
| 3000          	| PY-9983   	| 1000   	| -250      	|
| 3000          	| PY-9975   	| 5000   	| 150       	|

<br/>


Next, you set up the Core Set feature to include the Account and Product [dimensions](../dimensions/index.md). The Account Dimension contains accounts 3000 and 3001, while the Product Dimension contains products PY-9983, PY-9975, and PY-9900.

After running a data update (or reload), the Data Store will contain the following rows:
<br/>


| AccountID	| ProductID 	| Amount 	| Deviation 	|
|---------------	|-----------	|--------	|-----------	|
| 3000          	| PY-9983   	| 1000   	| -250      	|
| 3000          	| PY-9975   	| 5000   	| 150       	|
| 3000          	| PY-9900   	| NULL   	| NULL      	|
| 3001          	| PY-9983   	| NULL   	| NULL      	|
| 3001          	| PY-9975   	| NULL   	| NULL      	|

<br/>


The Core Set feature adds rows to the Data Store by combining the content of the Core Set dimensions and then adds the missing rows to the Data Store.
<br/>

## Core Set Members

The Core Set Members are the table resources used for producing the Cartesian product of rows that makes up the core data set of the [Data Store](../datastores.md) which is the rows that should always be present in the repository. 
> [!NOTE]
> Enabling the Core Set does not prevent the rows from being deleted after they have been added, it just ensures that the rows are thereafter a data reload or update operation.
