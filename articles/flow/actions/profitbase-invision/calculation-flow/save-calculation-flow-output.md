# Save Calculation Flow Output to database

Saves the result of a Calculation Flow to the target table.

<br/>

## Properties

| Name              | Type      | Description                                                |
|-------------------|-----------|------------------------------------------------------------|
| Title             | Optional  | Custom title for the action.                               |
| Batch size        | Optional  | Number of rows to write per batch.                         |
| Timeout (seconds) | Optional  | Number of seconds for the operation to complete.           |
| Disabled          | Optional  | Disables the action when checked.                          |
| Description       | Optional  | Additional information or notes about the action.          |

<br/>

>[!NOTE]
>The output should be written to the database only after all input records have been processed and all calculations are complete. To achieve this, the Db Output action must be configured correctly and connected in the proper sequence.

