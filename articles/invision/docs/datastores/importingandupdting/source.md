
## Source

A Data Store can have multiple data sources. Valid data sources are Facts, Dimensions, Settings, Views and other Data Stores. By default, all data sources except dimensions are considered fact sources unless specified otherwise by the **UsageOption** property of the data source.

By default, transactions are imported from the fact source(s). Having multiple fact sources, data will be imported using a UNION select combining data from all facts. If dimensions are bound to your Data Store, JOIN statements are produced so that the dimensions filters the transaction set being imported from the fact sources. In addition, custom filters can be applied to all sources. Dimensions can also be used for "padding" data imported from the facts sources. Padding data from fact sources means that you can fill the data store with rows containing data from both the fact sources and the dimensions. The Core Set feature also lets you do a type of padding by adding rows to the Data Store by creating rows based on the contents of dimensions.
<br/>

### See Also

* [Data Source Properties](source/datasourceproperties.md)

* [Transforms](source/transforms.md)