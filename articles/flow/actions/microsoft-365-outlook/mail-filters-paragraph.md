Use filters to restrict which mail messages are returned.

<!--prettier-ignore-->
| Filter        | Description                                    |
|---------------|------------------------------------------------|
| From          | Specify one or more email addresses to accept messages from. To filter on multiple adresses, use semicolon as separator, for example `luke.skywalker@rebellion.com;leia@rebellion.com`. You can also specify partial addresses such as `@outlook.com` to only accept emails sent from an Outlook.com account |
| Subject       | A text contained in the subject to receive. For example, using `budget version` as subject filter will accept messages with the subject `Final budget version 2024`, while messages with subject `Final version 2024` will not be accepted. |
| Only with attachments | Whether or not to only accept messages with attachments. |
| Custom filter  | Lets the user specify a custom filter, for example `startswith(subject, 'Hello') and isRead eq true`. [Read more about filters here](https://learn.microsoft.com/en-us/graph/filter-query-parameter). Note! You should not include `filter=` in the expression.  |
| Search        | Allows you to further restrict which messages are returned. [Read more about using search here](https://learn.microsoft.com/en-us/graph/search-query-parameter).  |
