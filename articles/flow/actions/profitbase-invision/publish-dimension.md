# Publish Dimension

Publishes a Dimension in an InVision Solution.

<!--![Publish Dimension](https://profitbasedocs.blob.core.windows.net/flowimages/deploy-stored-procedure.png)-->


## Returns

Boolean value (true or false).

## Properties 

| Name                 | Type     | Description                                      |
|----------------------|----------|--------------------------------------------------|
| Title                |          |                               |
| Connection           | Required | InVision connection.                             |
| Dimension            | Required | Select or enter the ID of the Dimension you want to publish.         |
| Result variable name | Optional | Name of the result variable containing the result (e.g., `isSuccess`). |
| Description          | Optional | Additional notes or comments about the action or configuration. |
