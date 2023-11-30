
# JSON Data API

The Data API lets you fetch data from InVision database objects (tables and views) using the HTTP protocol. The data is returned as an array of JSON objects. The main advantage of using the Data API instead of the OData API is better performance for large data sets and that you can use API Key authentication which may be easier for some clients. 

> [!NOTE]
> There is no row-level access control associated with an API Key, meaning once you have an API Key, you have read access to all the data in the database.

<br/>

## Getting an API Key

To use the Data API, you need to use API Key authentication. The API Key is sent as part of the request, so you should make sure that you are always using an https connection.

To get an API Key to use with the Data API, go to:  
**Application Menu** -> **API Management** -> **Manage API Keys**.  

In the Data tab, find an existing key or create a new. Use the API Key in the URL or header in the request (see the example below).

<br/>

## Table Data API

Use the Table Data API to fetch data from tables and views in the InVision database. The Table Data API has better performance for large data sets than the OData APIs, and provide a simpler to use authentication mechanism (API Key) for some clients.
<br/>

**URL**

``api/pub/v1/db/tables/<table name>/data``

**Method**

GET

**URL Params**

>*Required*
>
>api_key=[api key]
>
>> [!NOTE]
>  
>Optionally, you can provide the API key as a header named x-api-key
>
>*Optional*
>
>q={Eaze expression} 
>
>The filter is an optional Eaze expression for filtering rows. The filter is translated into parameterized SQL before execution, preventing SQL injection attacks.

**Success Response**

Code: 200 OK

Content: [{ "Column1" : Value, "Column2" : Value, ...},... ]

**Error Response**

Code: 500 Internal Server Error


>**Example**
>
```
https://mydomain.com/invision/api/pub/v1/db/tables/Store_PriceListStore_09202012134208/data?api_key=MyGuid&q={TransID == "10004"}
```


<br/>

## Object Data API

Use the Object Data API to fetch data from DB object type Solution Objects (Data Stores, Tables, Views, Facts, Dimensions) in the InVision database. The Object Data API has better performance for large data sets than the OData APIs and provides a simpler to use an authentication mechanism (API Key) for some clients. The Object Data API and Table Data API has the same performance characteristics and offer the same features, they just differ in how the objects are addressed (Solution Object Names vs materialized DB object names).
<br/>

**URL**

``api/pub/v1/db/objects/<object name>/data``

**Method**

GET

**URL Params**

>*Required*
>
>api_key=[api key]
>
>> [!NOTE]
>  
>Optionally, you can provide the API key as a header named x-api-key
>
>*Optional*
>
>q={Eaze expression} 
>
>The filter is an optional Eaze expression for filtering rows. The filter is translated into parameterized SQL before execution, preventing SQL injection attacks.

**Success Response**

Code: 200 OK

Content: [{ "Column1" : Value, "Column2" : Value, ...},... ]

**Error Response**

Code: 500 Internal Server Error

>**Example**
>
        https://mydomain.com/invision/api/pub/v1/db/objects/My Price List/data?api_key=MyGuid&q={TransID == "10004"} 


<br/>

## Videos

* [JSON Data API](../../videos/jsondataapi.md)