---
title: "Cell Adapter"
metaKeys: "Cell Adapter, Distributer, Spawner, Ruleset"
folderOnly: "false"
pageIndex: 1
---

The Cell Adapter component assigns values from the Cell Adapter [Ruleset](celladapter/ruleset.md) table to each row matching the filter criteria of the row(s) being processed in the pipeline. 

The Cell Adapter will generate one row for each matched Ruleset row. The Cell Adapter runs as the last component of a Transaction Pipeline process, so if any transactions are produced by the Distributer of Spawner components, the Cell Adapter will not execute at all. 

Both the Distributer and Spawner components support setting up cell adaption rules, so the Cell Adapter should be used when the features provided by the Distributer and Spawner are not required.
<br/>


**Ruleset**

Specifies the Setting table acting as the Cell Adapter Ruleset.

<br/>

### See Also

* [Input Configuration](celladapter/inputconfig.md)

* [Ruleset](celladapter/ruleset.md)

* [Output](celladapter/output.md)