---
title: "DB Web API"
metaKeys: "JavaScript, Download File, API Endpoints, Get Value from InVision Table, Request, Query string parameters, Db Web API, REST, query, Database, tables, data, get, Method"
folderOnly: "false"
pageIndex: 1
---


The Db Web API is a REST web API that lets you query InVision Database tables for data.
<br/>

### API Endpoints
<br/>

#### Get Value from InVision Table

Returns a single value from an InVision table object. You can specify search criteria and other options using query string parameters.
<br/>

#### Request
<br/>

**Method:**
<br/>

**GET**  
>``http(s)://[invision website]/api/db/objects/[object name]/[column]``  
Returns a single value from the **column** in the table object with the specified object name. **Object name** is the name of the table object as seen in the Solution Explorer.

**GET**  
>``http(s)://[invision web site]/api/db/tables/[db table name]/[column]``  
Returns a single value from the **column** in the InVision database table. **Db table name** is the name of the table (or view) in the Solution database.

<br/>

**Query string parameters:**
<br/>

**q**  
>``{eaze expression}``  (see the example below)  
Optional. Specifies search criteria. See Querying with the API example below. 


> [!NOTE]
> The search criteria must be enclosed in curly brackets.


**asFile**  
>``true/false``  
Optional.  If the value in *column* is a file name, but you want the actual file (not the file name) returned, set *asFile=true*.

**contentdisposition**  
>``attachment/inline``  
Optional. Enables you to explicitly set the content-disposition header of the response message. 


<br/>


#### Download File from InVision Table

Returns a file from an InVision table object. You can specify a search criteria and other options using query string parameters.

To use this API, the table must be a File Storage table, meaning it must at least contain the File Storage Columns : ResourceID nvarchar(100), ResourceName nvarchar(250), Data varbinary(max) and MediaType nvarchar(255).

 To create a valid File Storage table, you can create a regular Setting table and then press the “Add File Storage columns” button to add the required columns.

<br/>

#### Request
<br/>

**Method:**
<br/>

**GET**  
>``http(s)://[invision web site]/api/db/blob/objects/[object name]`` 
Returns a single value from the **Data** column in the (File Storage) table with the specified **object name**. **Object name** is the name of the table object as seen in the Solution Explorer.

**GET**  
>``http(s)://[invision web site]/api/db/blob/tables/[db table name]``  
Returns a single value from the **Data** column in the InVision database table. **Db table name** is the name of a table (or view) in the Solution database.

<br/> 


**Query string parameters:**
<br/>

**q**  
>``{eaze expression}`` (see the example below)  
Optional. Specifies search criteria. See the **Querying with the API** example below.  
**Note** that the search criteria must be enclosed in curly brackets.

**contentdisposition**  
>``attachment/inline``  
Optional. The default value is **attachment**. Enables you to explicitly set the content-disposition header of the response message.

<br/>

### Querying with the API

Use the q query string parameter to specify the filter to apply to the query. The filter has the following form ``q = {<eaze expression>}``.
<br/>

>**Example**
>
The following request will search the materialized SQL table of the "MyFileAssets" solution object and return the contents of the FileContents column where FileName equals "ReportExport.xlsx".
>
>```
https://mysite/invision/api/db/objects/MyFileAssets/FileContents?
q={FileName == "ReportExport.xlsx"}
```

