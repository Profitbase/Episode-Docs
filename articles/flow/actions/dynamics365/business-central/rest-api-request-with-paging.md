# REST API Request with paging

The REST API Request action enables you to call [Dynamics 365 Business Central v2 APIs](https://learn.microsoft.com/en-us/dynamics365/business-central/dev-itpro/api-reference/v2.0/) to connect apps. A typical use case is to create data integrations for pulling data from Dynamics 365 Business Central into a datawarehouse / data platform.

## Response paging

The `REST API Request with paging` action handles paging automatically for you, by returning one page at a time until the Dynamics 365 Business Central API returns no more pages. Note that this action also works for APIs that does not return paged responses, in which case the response will contain only a single page.

## API limits

The Dynamics 365 Business Central API has the following limits: [API limits](https://learn.microsoft.com/en-us/dynamics365/business-central/dev-itpro/api-reference/v2.0/dynamics-current-limits).

The `REST API Request with paging` action handles the following API limits interally:

- `429 - Too many request` : Flow will attempt to handle this limit by retrying the request using a retry policy. If the retry attempt(s) fail, an error is raised. This error can be handled in the On Error execution out port, for example by using the [Wait](../../built-in/wait.md) action to perform a manual retry.

## Properties

| Name          | Type     | Description                                                                                                                                                                         |
| ------------- | -------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Connection    | Required | The [Dynamics 365 Business Central connection](./dynamics365-business-central-api-v2-connection.md) used to make an authenticated request to the Dynamics 365 Business Central API. |
| Configuration | Required |                                                                                                                                                                                     |

## Returns

The return type is defined when configuring the action.
