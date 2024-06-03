# API Keys

API keys are used to authenticate and authorize API calls to Profitbase Flow. It is required in order to [execute Flows from 3rd party applications](../flows/running-flows/from-third-party-app.md) or make metadata API calls. API keys are only valid for the tenant in which they are defined.

![img](../../../images/flow/api-keys.png)

### Policy types

The policy type determines whether the API key grants permissions to `execute a Flow` or `make metadata API calls`.  

- The `Execute` policy type grants permissions to execute a Flow.
- The `Configuration` policy grants permissions to make metadata API calls to Flow.

When making an API call to Flow, the API key must be included in [the query string or in the request header](../api-reference/execute-flow/run.md). 