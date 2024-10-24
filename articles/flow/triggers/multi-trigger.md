# Multi-Trigger

Allows creating a trigger that is called from different sources. The sources are: HTTP, Flow and Schedule.

![img](/images/flow/multi-trigger.png)

## Returns

The return type is TriggerOutput, which has the following proeprties:

| Name           | Type     | Description                                      |
|----------------|----------|--------------------------------------------------|
| TriggerName    |  String  | Specifies the name of the trigger configuration that triggered the current run. |
| TriggerData    |  Object  | Specifies the data related to the trigger configuration. |


## Properties

| Name           | Type     | Description                                      |
|----------------|----------|--------------------------------------------------|
| Title          |  Optional | A descriptive label for the trigger configuration.|
| Trigger Configurations     | Required | Specifies the configurations included in the trigger. |
| Ouput variable name | Optional | Name of the variable where the trigger's output data will be stored. |
| Disabled			| Optional | Boolean value indicating whether the trigger is disabled (true/false). |
| Description    | Optional | Additional notes or comments about the trigger's purpose or configuration. |