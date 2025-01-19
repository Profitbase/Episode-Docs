# While (loop)

Runs a loop while its condition evaluates to `true`.

When the condition no longer evaluates to `true`, execution continues from the `Continue` port.

![image](../../../../images/flow/while.png)

| Name                            | Data Type   | Description                                           |
|---------------------------------|-------------|-------------------------------------------------------|
| Title                 | Optional    | Name of the loop.                       |
| Condition                  | Required    | Specifies the condition that must be satisfied in order to keep the loop running. The condition must evaluate to either a boolean `true` or `false`. When the condition no longer evaluates to true, the loop terminates.     |
| Maximum number of iterations                  | Optional    | Sets a limit on the number of iterations the loop can perform before termination. The default value is 10 000. If set to 0 or blank, the loop will have no hard limit and runs until the `Condition` evaluates to `false`. You can use this property as a safeguard to prevent the loop from running forever. |
| Description              | Optional    | Additional notes or comments about the action or configuration.    |

#### Maximum number of iterations

This property prevents the loop from running indefinitely.  Setting a reasonable maximum is recommended to avoid potential infinite loops.

![img](../../../../images/flow/max-While-Iteration.png)