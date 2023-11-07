---
title: "Group Account Mapping"
metaKeys: ""
folderOnly: "false"
pageIndex: 2
---
# Overview
Profitbase EPM makes use of a common account dimension, common across all legal entities.

Group Account Mapping allows you to map company-specific source accounts to the group accounts used in Profitbase EPM.

When external ledger data is imported to Profitbase EPM, this mapping is used. At the same time, the transaction is tagged with the source account for reference purposes.

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/GroupAccountMapping.JPG)

## Column Descriptions

- **Legal Entity**<br/>
The Legal entity to which the local or source account belongs. Mandatory. Select from the drop down list.
- **Src. Acc. ID**<br/>
The local or source account ID that is to be mapped to a group account. Mandatory. Type in the local or source account ID.
- **Source Account Name**<br/>
The name of the local or source account. Optional. Type in the name of the local source account.
- **Account**<br/>
The group account to which the local or source account is to be mapped. Mandatory. Select from the drop down list.
- **Message from input validation**<br/>
Field is not editable but may contain a status message resulting from validating the input given.
