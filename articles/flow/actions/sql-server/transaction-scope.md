# Transaction Scope

Sets a Transaction Scope ensuring all SQL operations either succeeds, or fails.


![img](https://profitbasedocs.blob.core.windows.net/flowimages/transaction-scope.png)


## Properties

| Name             | Type            | Description                                       |
|------------------|-----------------|---------------------------------------------------|
| Title            | Optional        | The descriptive title of the action.              |
| Timeout (sec)    | Optional        | The transaction scopes timeout in seconds.        |
| Isolation level  | Optional        | Specifies the transaction isolation level. The default is `Serializable`.  |
| Description      | Optional        |                                                   |