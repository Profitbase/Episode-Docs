# For each (loop)

Iterates over a list of items.


![img](../../../../images/flow/Get-share-items-info.png)

**Example** ![img](../../../../images/strz.jpg)  
Example above retrieves all files from a share [Get Share Items Info](../azure-files/get-share-items-info.md), iterates over each file (For each), and removes each file ([Delete file](../azure-files/delete-file.md)).
(If conditions are applied within the iteration, they should be defined explicitly inside the For each loop.)

The example retrieves all files from a share using the **Get Share Items Info** action. It then iterates over each item using a Foreach loop. Each file is passed to the Delete file from a share action.  
**Note:** The filtering logic is implemented inside the Foreach action, allowing only the relevant files to proceed to deletion.



## Properties

| Name            | Data Type | Description                                                   |
|-----------------|-----------|---------------------------------------------------------------|
| Title           | Optional  | The title or name of the action.                              |
| Items           | Required  | The collection of items to iterate over.                      |
| Loop Variable   | Optional  | The variable that holds the current item in each iteration.   |
| Description     | Optional  | Additional notes or comments about the action or configuration. |
