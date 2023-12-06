# Changelog EPM Planner 5.2.4

**Changes:**

- Multi department input - ability to provide input at higher levels of the department dimension. Applies to all input modules. (#1139). Functionality includes
1. Configurable multi department input per module (and driver based model). When multi department input is used, a mandatory input row limit is mandatory.
2. Configurable behavior with respect to auto loading on filter change. Default is auto load on change. It is recommended to consider setting auto load on change off when multi department input is used. This would enable the user to set all filters before data is loaded.
3. Configurable behavior with respect to which filters are mandatory (per module/model). Default is that no filters other than department are mandatory.
4. Introduction of an account filter in the account module.

**Note** that there is a **breaking change** for any customizations related to the use of Pre and Post transaction pipeline scripts. A changed script interface will have to be implemented.

- Account details report (used in input modules and plan overview) - pre-aggregation of historical reference data in order to improve performance (#1140)
- Auto transactions (modules Account, Personnel, Driver based) - ability to split similar rulesets by target account and/or target department (#1147)
- Loan, Investments, Fixed assets - take into account start dates that precedes the actual start of the plan (#1114)

**Bug fixes and GitLab reference list:**

- Account Plan Proposal - may return error on import if foreign currency is used (#1146)
- Heaps that has fragmentation issues (#1142)
- Plan overview - re-support of alternative actuals dataset (Plan overview and input modules) (#1141)
- Right-click menu options in Plan overview (#1117)
- Plan overview - historical data missing for legal entities that have functional currency that is not one of the reporting currencies (#1116)
