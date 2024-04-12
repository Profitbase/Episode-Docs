# DataReader chunker

Splits the records in a DataReader into multiple chunks.

Use this action when reading a large number of rows that needs to be split into batches for processing.  
For example, if you need to export millions of rows from a database to a CSV file in Azure Blob Storage, you might not be able to do this in a single operation due to limitation of available memory. In this case, you can use the chunker to split rows into batches of manageable sizes and use the [Append to Blob](../azure-blob-storage/append-to-blob.md) action to upload one chunk at a time.


