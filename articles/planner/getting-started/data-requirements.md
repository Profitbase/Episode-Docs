# Data Requirements

## Dimensions

All dimensions can either be created using the dimension editor inside the CFO Platform or imported from a source system. The default is to import dimensions in the Parent-Child format.

Please note that any non-visual characters such as as carriage return, line feed and so on should not be used for dimension member ids nor descriptions. For the ID's it is recommended to only use numbers and letters a-z. IDs are limited to 50 characters. Name columns 200 characters.

| Dimension    | Mandatory | Comment  |
| :---         | :---:    | :---     |
| [Account](#account-details)      | Mandatory | |
| [Currency](#currency-details)     | Mandatory | |
| [Department](#department-details)   | Mandatory | |
| [Legal Entity](#legal-entity-details) | Mandatory | |
| Activity     | Optional  | |
| Asset Group  | Optional | |
| Dim1         | Optional | |
| Dim2         | Optional | |
| Dim3         | Optional | |
| Dim4         | Optional | |
| Employee     | Optional | Mandatory if Personnel module is used.  |
| Market       | Optional | |
| Product      | Optional | |
| Project      | Optional | |
| Supplier     | Optional | |

## Facts / Transactions

| Fact    | Mandatory | Comment  |
| :---         | :---:    | :---     |
| Ledger Fact | Mandatory | |
| Personnel Fact | Optional | |
| Driver Based Fact | Optional | |
| Fixed Assets | Optional | |

## Other data

| Name    | Mandatory | Comment  |
| :---         | :---:    | :---     |
| Currency Exchange Rates | Mandatory | Should be the same as used by the ERP system. |
| Report Setup | Mandatory | |
| Time | Mandatory | Usually generated inside the solution.  |

## Account Details

This should be the common / corporate charter of accounts.

| Column Name    | Description | Mandatory  | Comment |
| :--- | :--- | :--- | :--- |
| ID | ID for the Account | Mandatory | Must be unique. |
| Name | Account Name | Mandatory | |
| ParentID | ID for the parent node | Optional | Must be a valid ID or NULL. Any ID with ParentID = NULL is placed at the root level. |
| SignFactor | Should be either 1 or -1. | Mandatory | Tells the sign for the transaction. For example expenses recorded as positive number gives SignFactor 1 while sales recorded as negative numbers gives SignFactor -1. |
| AccTypeID | Grouping for Profit & Loss and Balance accounts | Mandatory | Valid values are PL and BAL. |
| AllowInput | Marks the accounts that will be allowed plan input | Mandatory | Valid values are 1 and 0. |

## Currency Details

| Column Name    | Description | Mandatory  | Comment |
| :--- | :--- | :--- | :--- |
| ID | ID for the Currency | Mandatory | Must be unique. |
| Name | Usually the same as ID for currency | Mandatory | |

## Department Details

Please note that the LegalEntityIDs should be different from the DepartmentIDs. If such cases of equality exist, the best practice would be to prefix the source DepartmentIDs with LegalEntityID before making use of them in Planner. For example, if both a LegalEntityID and a DepartmentID equals ‘pro’, best practice would be to rename the DepartmentID to ‘pro.pro’ thus making it unique.

It is important that DepartmentIDs of the dimension corresponds to the IDs used for actual general ledger data.

| Column Name    | Description | Mandatory  | Comment |
| :--- | :--- | :--- | :--- |
| ID | ID for the Department | Mandatory | Must be unique. |
| Name | Name for the Department | Mandatory | |
| ParentID | ID for the parent node | Optional | Must be a valid ID or NULL. Any ID with ParentID = NULL is placed at the root level. |
| LegalEntityID | ID for the Legal Entity that the department belongs to. | Mandatory | All departments must be tagged with a valid LegalEntityID. |

## Legal Entity Details

| Column Name    | Description | Mandatory  | Comment |
| :--- | :--- | :--- | :--- |
| ID | ID for the Legal Entity | Mandatory | |
| Name | Name for the Legal Entity | Mandatory | |
| ParentID | ID for the parent node | Optional | Must be a valid ID or NULL. Any ID with ParentID = NULL is placed at the root level |
| FunctionalCurrencyID | Home currency for this Legal Entity | Mandatory | |
| OperationTypeID | Type of Legal Entity | Mandatory | Valid options are Main and Elimination. |
| DefaultDepartmentID | Default department for the Legal Entity | Mandatory | Used for situations where a department is not normally given, such as opening balances. |
