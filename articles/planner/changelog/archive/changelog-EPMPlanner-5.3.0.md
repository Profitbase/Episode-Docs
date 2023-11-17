---
title: "Changelog EPM Planner 5.3.0"
metaKeys: "Changelog"
pageIndex: 84
---

**Changes:**

- **Finance Reports workbook made available within individual Planner versions** and not only as a central reporting workbook. Version's dimensionality is used including version specific access control. Report setup is, however, always centralized and thus the same as that used in the central Finance Reports (#1157)
- Ability to **validate financial simulation from an input cell** in an input module. Right-click menu option "Validate financial simulation". Financial output, both P&L transactions (source transaction to financial engines) and complete transactions posted (output of financial engines) presented in report(s) in a separate pop-up (#1158)
- New workbook for **input directly on native financial engine format** (Sales, Purchase, Payroll and Expense). In certain situations, operationalized input modules such as driver based, payroll, etc. will not cover the complete need and it may be desirable to input directly to the relevant financial engine source. A new workbook "Finance advanced input" allows this. Multiple models may be created (#1167)
- Ability to **net input module's additional filters**. Netting implies that only the dimension members in the currently loaded data appear in the filter, making it easier to use the filter as its members are the relevant members only for the specific context (#1043)
- Driver based module: Correct averaging of historical reference data for measures that are percentages. A separate override (vertical) formula is available to be used in these cases (#1010)

**Bug fixes and GitLab reference list:**

- DefaultDepartment table must be synchronized on publishing LegalEntity dimension (#1199)
- Export dimension views - associated CPV view may infer incorrect datatype (#1193)
- CurrencyFunctionalID overrides functional currency from dimension (#1185)
- On before delete - continue on failure (#1176)
- Scheduled system operations should have compile (import from primary dimension) as last step (#1166)
- Personnel - missing long term auto transactions when target department is blank (self) (#1164)
- Wrong currencyconversion in Planoverview report (#1163)
- Reports using Scenario will not show balances correctly due to lacking OB for Best and Worst (#1160)
- Historical columns in Plan overview report is wrong when you are using Project or Activity dimension (#1151)
- Input modules - Validation fails if row context set before new row is added (#1148)


