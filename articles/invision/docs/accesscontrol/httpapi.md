# Access Control APIs

InVision provides an HTTP API for managing Identities and Access Groups.
To manage Identities/Groups/Access Control through the API, you need to first configure an **API Key** (see below) in the Designer.


<br/>

## Create an API Key

To create an API Key to use with the Access Control Management API, go to **Application Menu -> API Management -> Edit**. In the **Access Control** tab, find an existing key or create a new one. Use the API Key in the **url** or **header** in the request (see examples below).

<br/>

## Define API key in designer

1. Click the Edit command under the API Management menu item.
2. Select the Access Control tab.
3. Click the Add button.

<br/>

![apimanagement](https://profitbasedocs.blob.core.windows.net/images/apimanagement.png)

<br/>
<br/>


## Authentication
To call any of the API endpoints, you need to provide the API key.  
You can include the API key it in the URL or as a header. For security reasons, we recommend using a header.   

#### API key as header  

| Header name   | Value      |
|---------------|------------|
| x-api-key     | MY_API_KEY |    


#### API key in the URL
https://request_address?api_key=MY_API_KEY  

**Example**  
`https://app.profitbase.biz/my-company/api/v1/accesscontrol/identities?api_key=2b206745-6fa6-40df-a0ea-0364c091bccb`

<br/>

## APIs

Below is a list of all available APIs for managing identities and groups in InVision.   
<br/>

#### Get Identities
---
**[GET]** `/api/v1/accesscontrol/identities`  
Lists the existing identities, such as Entra ID users or groups registered in the system.

**Success Response**: 200 OK  
**Error response**: 500 Internal Server Error
<br/>

```json
[
  {

    "id": "9cbf5b23-a9d3-4743-87d7-733e0c2bd08e",
    "name": "Anders Andersen",
    "type": 0,
    "email": "anan@mydomain.no",
    "description": "anan@mydomain.no"
  }
]
```

**Example**  
GET `https://app.profitbase.biz/my-company/api/v1/accesscontrol/identities`

<br/>

#### Get Identity
---
**[GET]** `/api/v1/accesscontrol/identities/<id>`  
Gets the properties of an existing Identity.  

**Success response**: 200 OK  
**Error response**: 500 Internal Server Error

<br/>

```json
  {
    "id": "9cbf5b23-a9d3-4743-87d7-733e0c2bd08e",
    "name": "Anders Andersen",
    "type": 0,
    "email": "anan@mydomain.no",
    "description": "anan@mydomain.no"
  }

 ```

**Example**  
GET `https://app.profitbase.biz/my-company/api/v1/accesscontrol/identities/04f0bc48-a51d-4339-be90-f20c1787b6ea`

---
<br/>

#### Add Identity API
---
**[POST]** `/api/v1/accesscontrol/identities`  
Adds an Identity.  

**Success response**: 200 OK  
**Error response**: 500 Internal Server Error 

**Body**

```json
  {
    "id": "c6c52e0d-812f-47d1-9795-eb011c2eba03",
    "name": "Anders Andersen",
    "type": 0,
    "email": "anan@mydomain.no",
    "description": "anan@mydomain.no"
  }
```

**Example**  
POST `https://app.profitbase.biz/my-company/api/v1/accesscontrol/identities`

 
<br/>

#### Update Identity
---
**[PUT]** `/api/v1/accesscontrol/identities/<id>`  
Updates an Identity.  

**Success response**: 200 OK  
**Error response**: 500 Internal Server Error  

**Body**

```json
  {

    "id": "c6c52e0d-812f-47d1-9795-eb011c2eba03", //will be ignored
    "name": "Anders Andersen",
    "type": 0,
    "email": "anan@mydomain.no",
    "description": "anan@mydomain.no"
  }
``` 

**Example**  
PUT `https://app.profitbase.biz/my-company/api/v1/accesscontrol/04f0bc48-a51d-4339-be90-f20c1787b6ea`
 
<br/>

#### Delete Identity
---
**[DELETE]** `/api/v1/accesscontrol/identities/<id>`  
Deletes an Identity.  

**Success response**: 200 OK  
**Error response**: 500 Internal Server Error  

**Example**  
DELETE `https://app.profitbase.biz/my-company/api/v1/accesscontrol/identities/04f0bc48-a51d-4339-be90-f20c1787b6ea`

 
<br/>

#### List identity memberships
---
**[GET]** `/api/v1/accesscontrol/identities/<id>/accessgroups`    
Lists the access groups that an identity is member of.  

**Success response**: 200 OK  
**Error response**: 500 Internal Server Error  


<br/>

```json
[
  {
    "id": "2cbf5b23-a9d3-4743-87d7-733e0c2bd08e",
    "name": "My Access Group"
  }
]
```  

**Example**  
GET `https://app.profitbase.biz/my-company/api/v1/accesscontrol/identities/cafdd2dd-f709-4841-a41d-7f2d6cdccca3/accessgroups`


<br/>

#### List identities in Access Group
---
**[GET]** `/api/v1/accesscontrol/accessgroups/<id>/identities`  
Lists the identities that are members of an Access Group.  

**Success response**: 200 OK  
**Error response**: 500 Internal Server Error  

<br/>

```json
[
  {
    "id": "9cbf5b23-a9d3-4743-87d7-733e0c2bd08e",
    "name": "Anders Andersen",
    "type": 0,
    "email": "anan@mydomain.no",
    "description": "anan@mydomain.no"
  }
]
```  

**Example**  
GET `https://app.profitbase.biz/my-company/api/v1/accesscontrol/accessgroups/cafdd2dd-f709-4841-a41d-7f2d6cdccca3/identities`


<br/>

#### Add Access Group Identity  
---
**[POST]** `/api/v1/accesscontrol/accessgroups/<accessgroupid>/identities/<identityid>`  
Adds an identity to an Access Group.  

**Success response**: 200 OK  
**Error response**: 500 Internal Server Error  

**Example**  
POST `https://app.profitbase.biz/my-company/api/v1/accesscontrol/accessgroups/cafdd2dd-f709-4841-a41d-7f2d6cdccca3/identities/c6c52e0d-812f-47d1-9795-eb011c2eba03`

<br/>

#### Remove identity from Access Group
---
**[DELETE]** `/api/v1/accesscontrol/accessgroups/<accessgroupid>/identities/<identityid>`  
Removes an identity from an Access Group.  

**Success response**: 200 OK  
**Error response**: 500 Internal Server Error  

**Example**  
DELETE `https://app.profitbase.biz/my-company/api/v1/accesscontrol/accessgroups/cafdd2dd-f709-4841-a41d-7f2d6cdccca3/identities/c6c52e0d-812f-47d1-9795-eb011c2eba03`


<br/>

#### List Access Groups
---
**[GET]** `api/v1/accesscontrol/accessgroups`  
Lists all Access Groups.  

**Success response**: 200 OK  
**Error response**: 500 Internal Server Error  


```json
[
  {
    "id":"2cbf5b23-a9d3-4743-87d7-733e0c2bd08e",
    "name":"My Access Group"
  }
]
```

**Example**  
`https://app.profitbase.biz/my-company/api/v1/accesscontrol/accessgroups/`

 












<br/>

## See Also 
* [Identities](identities.md)

<br/>

## Videos

* [Access Control](../../videos/accesscontrol.md)
* [Create and Manage Microsoft Entra ID Identities and Access Groups](https://profitbasedocs.blob.core.windows.net/videos/Users%20and%20Permissions%20-%20Create%20and%20Manage%20Azure%20AD%20Users%20and%20User%20Groups.mp4)