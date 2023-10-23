# Delete from table

Deletes data from an InVision table based on the data context passed in from InVision or another client.
If no Table or Parameter relationships are defined, all rows are deleted from the table.

##### Properties

| Name                    | Type         | Description                                                |
|-------------------------|--------------|------------------------------------------------------------|
| Connection              | Required     | A valid InVision Connection.                               |
| Delete from table       | Required     | The table to delete from                                   |
| Table relationships     | Optional     | The [Table relationship](table-relationship.md) is used to slice the data set being processed. <br/><br/>When a Calculation Flow is executed, the calling context (for example InVision) may pass in a [Data Context](data-context.md) which specifies the context of which the Flow is run. This is typically a selected filter item, for example a specific department or an account group, or a selection of items from multiple different filters.<br/><br/>Under the hoods, the [Table relationships](table-relationship.md) along with the [Data Context](data-context.md) creates a SQL JOIN that defines the data being processed.<br/><br/>If neither this nor the Parameter relationships property is defined, or the caller does not pass in a Data Context, all rows from the Source table is processed.               |
| Parameter relationships | Optional     | Just like the Table relationship, the [Parameter relationship](parameter-relationship.md) is used to slice the data set being processed.<br/><br/> The difference between the [Table relationship](table-relationship.md) and the [Parameter relationship](parameter-relationship.md) is that parameters are a set of _standalone_ values that can be used to slice the data set being processed.<br/><br/>Under the hoods, the Parameters relationships along with the Data Context creates a WHERE clause to slice the data being processed. If both Table and Parameter relationships are defined, and the Data Context contains data for both table and parameter contexts, both features are used to slice the data set being processed (SQL JOIN + WHERE clause).<br/><br/>If neither Parameter nor the Table relationships are defined, or the caller does not pass in a [Data Context](data-context.md), all rows from the Source table are processed.                                                  |
| Custom data context     | Optional     | If the caller does not pass in a [Data Context](data-context.md), you can create a Data Context programatically to slice the data set being processed. The example below demonstrates how to create a custom Data Context. |
| Command timeout         | Optional     | The timeout in seconds to complete the operation. The default timeout is infinite. |
| Batch side              | Optional     | The number of rows deleted pr batch. The defualt size is 5000.                     |

