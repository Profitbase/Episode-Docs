---
title: "Binding Source Columns to DS Columns"
metaKeys: "Binding source columns to Data Store columns, connection between, source, target, BindingType, Relationship, expression, ColName,  "
pageIndex: 1
---



Source columns are bound to [Data Store](../../datastores.md) columns by drag and drop them onto an existing Data Store column, an empty area in the Data Store column list or to the schema header. The designer will add a connection between the source and target column, which allows you to specify properties for the binding. This binding defines how data is imported from the source to the target column.
<br/>

### Properties:
<br/>

``BindingType``  

**Default**   
>For Fact sources, the default binding type is «Data". For Dimension sources, the default binding type is "Relationship" if there is a binding to a Fact column as well.  

**Relationship**  
>If there is no Fact binding to the column, you need to set the BindingType to «Relationship" for dimension bindings. This information is required for generating the correct query for loading data to a Worksheet, enable Dropdown editors to be rendered for Worksheet Drop Dow columns and determining the Data Context for a Data Store when processing transactions.  

**Data**  
>Only applicable to dimension bindings. Indicates that data should be imported from the binding. The same behavior will be applied for dimension bindings that binds to Data Store Columns without fact bindings.

``Expression``  
>A SQL expression that represents the value you want to import. If you just want to import the data from the source column, leave this field empty. If you specify a value in this field, the resulting import statement will be similar to SELECT `<expression>` AS ColName …ect.

``From``  
>Specifies the name of the source column. If you want to fill a target column with data during import, but you do not want to get the data from a column in the source, you can leave this property empty and specify the value to import in the Expression property. 

``To``  
>(Read-only). Specifies the name of the target column.