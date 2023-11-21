
## Exporting data from InVision

Because [Data Store](../datastores.md) are the primary data repositories, you would normally set up one or more Data Stores as the external facing endpoints to allow other systems, such as Excel or a Data Warehouse, to read data from InVision. The [Data Store](../datastores.md) are materialized as plain SQL tables which makes them easy to connect to and extract data from. Optionally, you can use [Views](../views.md) to consolidate multiple data repositories into a single endpoint.
