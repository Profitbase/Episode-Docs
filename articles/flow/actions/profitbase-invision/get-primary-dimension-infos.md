# Get Primary Dimensions

Retrieves a list of Primary Dimension information from all InVision solutions.

![Example Flow](../../../../images/flow/invision-get-primary-dimensions.png)

**Example** ![img](../../../../images/strz.jpg)  
This action returns a list of dimension information items. The list is then iterated using a [For each](../built-in/foreach.md) loop, and each item is evaluated with an [If](../built-in/if.md) condition to determine whether it should be updated. When an update is required, the flow triggers an [update flow](../built-in/start-flow.md) action and passes the dimension data as arguments.
<br/>

## Properties

| Name | Type | Description |
|------|------|-------------|
| Title | Optional | Action title. |
| Connection | Required | InVision connection. |
| Result variable name | Required | Variable name that receives the list of Primary Dimension information. |
| Disabled | Optional | Whether the action is disabled (true/false). |
| Description | Optional | Additional details or notes about the action. |

<br/>

## Returns

List of Primary Dimension information:

| Property | Description |
|----------|-------------|
| DimensionId | The ID of the dimension. |
| DimensionName | The name of the dimension. |
| SolutionId | The ID of the solution containing the dimension. |
| SolutionName | The name of the solution containing the dimension. |
| ParentChildTableName | The name of the dimension's parent/child table. |
| WideTableName | The name of the dimension's wide table. |
