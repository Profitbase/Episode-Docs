# Track

Sends diagnostics to Azure Application Insights, including a message, custom properties, severity level, and an optional exception.

**Example**  
Add a Track action at key points in a Flow to record progress, warnings, or errors to Application Insights. For instance, after processing each record, track an informational message with relevant properties; on exceptions, attach the exception with `Severity = Error`.

## Properties

| Name                    | Type      | Description                                                                 |
|-------------------------|-----------|-----------------------------------------------------------------------------|
| Title                   | Optional  | A descriptive label for the action.                                         |
| Connection              | Required  | Azure Application Insights connection used to authenticate and connect.     |
| Message                 | Required  | The diagnostics message to log.                                             |
| Properties              | Optional  | Key-value telemetry properties to include with the message.                 |
| Include system properties | Optional | Include Flow/job/system context properties with the telemetry entry.        |
| Severity                | Optional  | Diagnostics severity (Verbose, Information, Warning, Error, Critical).      |
| Exception               | Optional  | An exception object to attach to the telemetry entry (if available).        |
| Description             | Optional  | Additional notes or comments about the action or configuration.             |