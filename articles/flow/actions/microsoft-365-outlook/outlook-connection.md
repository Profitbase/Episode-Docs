# Microsoft 365 Outlook connection

You need a Microsoft 365 Outlook connection to perform actions such as send mails, read mails, and triggering Flows when mails arrive.

You create Microsoft 365 Outlook connections by clicking the `Connection` property in the Property panel of a selected Outlook action.

By creating a connection, you grant Profitbase Flow permissions to access Outlook `on behalf` of the user account you log in with.  
When you create the connection, you choose whether Profitbase Flow will get permissions to access `only shared mailboxes` on behalf of the user, or `any mailbox` the user has access to (including their personal mailbox).

> [!CAUTION]
> If you work in a Workspace shared with other people, we recommend granting access to only `shared mailboxes`, or log on using a company service account.

## Allow access to all mailboxes (personal and shared mailboxes)

When you choose this option (leave the `Allow access to shared mailboxes only` unchecked), you grant Profitbase Flow unrestricted access to perform any operation on mailboxes (including shared) on behalf of the user account that you log on with.

## Allow access to shared mailboxes only

When you choose this option, Profitbase Flow can only perform actions on shared mailboxes that the user has access to. Even though you log on using your personal account, Profitbase Flow will only have permissions to perform actions, such as send and read mails, from `shared mailboxes` that you have access to.

![img](/images/flow/microsoft-365-outlook-connection-shared-only.png)
