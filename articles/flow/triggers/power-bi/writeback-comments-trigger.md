# Writeback Comments trigger

The trigger defines the starting point of a Flow that stores comments from the [Writeback Comments Power BI](../../../PowerBI/writeback-comments/overview.md) visual.

To create a Flow that saves comments from the Writeback Comments visual, add this trigger. It starts the Flow when the user presses the `Save` button in the [Writeback Comments visual](../../../PowerBI/writeback-comments/overview.md), and outputs a [DeltaSet](../../api-reference/built-in-types/deltaset.md) containing the change made by the user. You then need to add an action for the specific target system that you want to save the comments to, for example [SQL Server / Azure SQL](../../actions/sql-server/save-deltaset.md), PostgreSQL or [Snowflake](../../actions/snowflake/save-deltaset.md).

<br/>

![img](/images/flow/powerbi-writeback-comments-trigger.png)

**Example**![img](/images/strz.jpg)  
This flow is triggered when users add or update comments in a Power BI Writeback Comments visual. The trigger captures the delta set of new or changed comments, and the Flow then saves this data into the designated database table by automatically applying updates or inserts based on what data is already stored in the target table. This ensures that user feedback or annotations from Power BI reports are stored centrally for later retrieval, reporting, or analysis.

<br/>

## Properties
| Name            | Type            | Description                               |
|-----------------|-----------------|-------------------------------------------|
| Test data       | Optional        | Use this property to define test data to save to a database, file or service. The test data is only used when you run the Flow manually from the Designer during development. The test data is NOT used when data is saved from the Power BI user interface. [See below](#test-data-format) for a description of the required format. | 
<br/>

## Returns
The trigger returns a [DeltaSet](../../api-reference/built-in-types/deltaset.md) containing the comments to save to a database, file, or service.  
The DeltaSet can be passed to an action that saves the changes to a database, file or service.  

The following actions currently supports saving DeltaSet changes:  
- **SQL Server / Azure SQL**: [Save DeltaSet to SQL Server](../../actions/sql-server/save-deltaset.md)  
- **Snowflake**: [Save DeltaSet to Snowflake](../../actions/snowflake/save-deltaset.md)

<br/>

### Test data format
This describes the format you can use to test saving changes from the Writeback Table before you have added it to a page in Power BI.
To manually run a Flow for testing purposes, press the `Run` button in the Flow Designer application toolbar.  

```json
{    
    "column": "columnName",
    "value": "string",
    "context": {"column1": "value1", "column2": "value2"}    
}
```

#### Example - Test data
The example below shows a test data JSON object that describes changes to January and February amounts of how much a sales representative is expected to sell for a specific product.
```json
{    
    "column": "Comments",
    "value": "This is my comment.",
    "context": {"ProductId": "100", "SalesRepId": "56-08-12"}
}
```