# Execute long running SQL Script

Execute a long running [SQL Script](/articles/invision/docs/sqlscripts.md) defined in an InVision Solution.


![img](../../../../../images/flow/execute-sql-script-returning-single-value.png) 

**Example** ![img](../../../../../images/strz.jpg)  
This flow executes a SQL query defined in an InVision Solution to retrieve a single value (productId), logs that value for debugging or auditing purposes, and then returns it as the output of the flow.


>[!NOTE]
> If your SQL Script may take longer than 5 minutes to execute, use the Long Running SQL Script action instead of the regular SQL Script action.

## Properties

| Name                 | Type     | Description |
|----------------------|----------|-------------|
| Title                | Optional | A descriptive label for the action displayed in the Flow editor. |
| Connection           | Required | Defines the InVision connection used to access the Profitbase InVision environment. The connection provides the credentials required to execute the SQL script. |
| SQL Script           | Required | The InVision SQL Script to execute. This script is typically created and stored in InVision and can contain long-running database operations. |
| Language             | Optional | Specifies the language used by the SQL script. This may be required depending on the script configuration. |
| Parameters           | Optional | Defines parameters that are passed to the SQL script during execution. These allow dynamic values to be injected into the script. |
| Result variable name | Optional | The name of the variable that will store the execution result returned by the SQL script. This variable can be used later in the flow. |
| Disabled             | Optional | If enabled, the action will be skipped during flow execution. This allows the step to remain in the flow without being executed. |
| Description          | Optional | Additional information describing the purpose of the action. This is only used for documentation within the Flow. |