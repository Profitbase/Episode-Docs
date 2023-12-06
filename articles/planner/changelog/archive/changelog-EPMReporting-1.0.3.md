# Changelog EPM Reporting 1.0.3

**Changes**

- Finance Reports: Trial balance drilldown shows source accounts #1088


- Finance reports: new dimensions introduced as columns and filters (Supplier and Counterpart) #1084 (closed)


- Report Setup: new options added to the Financial Reporting Matrix configuration. Columns IsCost and Optional. #1083 (closed)


- Finance Reports: label "Data last updated" available for all datasets #1061 (closed)


- Optimized Report Line processing and caching #1045


- Dimensions - Import external data menu option allowing for import of dimension data from external sources. Note that this requires underlying import operations to be configured with respect to connection information, etc. to the appropriate source.

**Bug fixes**

- ReportLineAdditionalDimMappingExpanded store missing from solution #1051 (closed)


- Invalid column name 'ReportLineID' when loading the Trend report(s) in finance reports #1053 (closed)


- Finance Reports: Report lines appear empty for data that does not have values for optional dimensions Dim1,.. Dim4 #1058 (closed)

- In Finance Reports this errors shows profit/loss data having and opening Balance. Total Year and YTD show number including OB. Reports Year and Month and Trial Balance #1092 (closed)

- ReportLineByMonthCache - indexes failed with error: Partition functions #1091 (closed)

- Report setup: Not posible to chose values in format drop down list #1068 (closed)

- Finance Reports: Error message: Cannot insert NULL in WorkProcessVersion_ID table ...ReportLineByMonthCacheRegister... #891 (closed)

