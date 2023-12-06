# Changelog EPM Datamart 5.2.5
**Changes:**

- Data Import / Export - Copy Ruleset function (#1177)
- Data Import from SQL - Moving data to temp table ignores WHERE clause (#1184)
- Data Import - Column mapping button only activates after importing new data to sql temp table (#1179)
- Data Import - beta version of faster import from CSV, available for Profitbase hosted instances
- Data Import - Optimized import to temp table by applying the "WHERE" filter to this step also (previously, only applied between temp table and final destination)


**Bug fixes and GitLab reference list**

- File import decimals (#1159)
- Data Export to SQL - ExportName is ignored if not added to column mapping. (#1168)
- Data Export - Preview fails when switching source and "ExportName" is no longer a column (#1172)


