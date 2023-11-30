# Getting an API Key
## Manage Access Control using an API

Access control can be managed through an **HTTP API**. To manage Identities/Groups/Access Control through the API, you need an **API Key** and the **API address**.


<br/>

## Getting an API Key

To get an API Key to use with the Access Control Management API, go to **Application Menu -> API Management -> Edit**. In the **Access Control** tab, find an existing key or create a new one. Use the API Key in the **url** or header in the request (see the **example** below).


<br/>

## Define API key in designer

1. Click the Edit command under the API Management menu item.
2. Select the Access Control tab.
3. Click the Add button.

<br/>

![apimanagement](https://profitbasedocs.blob.core.windows.net/images/apimanagement.png)
<br/>



## Get Identities API

This API gets a list of existing Identities.

**URL**

api/v1/accesscontrol/identities

**Method**

GET

**URL Params**

*Required*  
api_key=[api key]

> [!NOTE]
> Optionally, you can provide the API key as a header named x-api-key

**Success Response**

Code: 200 OK

Content:

<br/>

```
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
<br/>

**Error Response**

Code: 500 Internal Server Error

**Example**

https://mydomain.com/invision/api/v1/accesscontrol/identities?api_key=2b206745-6fa6-40df-a0ea-0364c091bccb



<br/>

## Get Identity API

This API gets the properties of an existing Identity.

**URL**

``api/v1/accesscontrol/identities/<id>``

**Method**

GET

**URL Params**

*Required*  
api_key=[api key]

> [!NOTE]
> Optionally, you can provide the API key as a header named x-api-key

**Success Response**

Code: 200 OK

Content:

<br/>

```
  {

    "id": "9cbf5b23-a9d3-4743-87d7-733e0c2bd08e",

    "name": "Anders Andersen",

    "type": 0,

    "email": "anan@mydomain.no",

    "description": "anan@mydomain.no"

  }

 ```

**Error Response**

Code: 500 Internal Server Error

**Example**

https://mydomain.com/invision/api/v1/accesscontrol/identities/04f0bc48-a51d-4339-be90-f20c1787b6ea?api_key=2b206745-6fa6-40df-a0ea-0364c091bccb

 
<br/>

## Add Identity API

This API adds an Identity.

**URL**

api/v1/accesscontrol/identities

**Method**

POST

**URL Params**

*Required*  
api_key=[api key]

> [!NOTE]
> Optionally, you can provide the API key as a header named x-api-key

 

**Body**

```
  {

    "id": "c6c52e0d-812f-47d1-9795-eb011c2eba03",

    "name": "Anders Andersen",

    "type": 0,

    "email": "anan@mydomain.no",

    "description": "anan@mydomain.no"

  }
```

 

**Success Response**

Code: 200 OK

**Error Response**

Code: 500 Internal Server Error

**Example**

https://mydomain.com/invision/api/v1/accesscontrol/identities?api_key=2b206745-6fa6-40df-a0ea-0364c091bccb

 
<br/>

## Update Identity API

This API updates an Identity.

**URL**

``api/v1/accesscontrol/identities/<id>``

**Method**

PUT

**URL Params**

*Required*  
api_key=[api key]

> [!NOTE]
> Optionally, you can provide the API key as a header named x-api-key

 

**Body**

```
  {

    "id": "c6c52e0d-812f-47d1-9795-eb011c2eba03", //will be ignored

    "name": "Anders Andersen",

    "type": 0,

    "email": "anan@mydomain.no",

    "description": "anan@mydomain.no"

  }
``` 

 

**Success Response**

Code: 200 OK

**Error Response**

Code: 500 Internal Server Error

**Example**

https://mydomain.com/invision/api/v1/accesscontrol/identities/04f0bc48-a51d-4339-be90-f20c1787b6ea?api_key=2b206745-6fa6-40df-a0ea-0364c091bccb

 
<br/>

## Delete Identity API

This API deletes an Identity.

**URL**

``api/v1/accesscontrol/identities/<id>``

**Method**

DELETE

**URL Params**

*Required*  
api_key=[api key]

> [!NOTE]
> Optionally, you can provide the API key as a header named x-api-key

 

**Success Response**

Code: 200 OK

**Error Response**

Code: 500 Internal Server Error

**Example**

https://mydomain.com/invision/api/v1/accesscontrol/identities/04f0bc48-a51d-4339-be90-f20c1787b6ea?api_key=2b206745-6fa6-40df-a0ea-0364c091bccb

 
<br/>

## Get Identity Access Groups API

This API gets a list of an Identity’s Access Groups.

**URL**

``api/v1/accesscontrol/identities/<id>/accessgroups``

**Method**

GET

**URL Params**

Required
api_key=[api key]

> [!NOTE]
> Optionally, you can provide the API key as a header named x-api-key

**Success Response**

Code: 200 OK

**Content:**

<br/>

```
[


  {

    "id": "2cbf5b23-a9d3-4743-87d7-733e0c2bd08e",

    "name": "My Access Group"

  }

]
```

**Error Response**

Code: 500 Internal Server Error

**Example**

https://mydomain.com/invision/api/v1/accesscontrol/identities/cafdd2dd-f709-4841-a41d-7f2d6cdccca3/accessgroups?api_key=2b206745-6fa6-40df-a0ea-0364c091bccb



<br/>

## Get Access Group Identities API

This API gets a list of existing Identities in an Access Group.

**URL**

``api/v1/accesscontrol/accessgroups/<id>/identities``

**Method**

GET

**URL Params**

*Required*  
api_key=[api key]

> [!NOTE]
> Optionally, you can provide the API key as a header named x-api-key

**Success Response**

Code: 200 OK

**Content:**

<br/>

```
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

**Error Response**

Code: 500 Internal Server Error

**Example**

https://mydomain.com/invision/api/v1/accesscontrol/accessgroups/cafdd2dd-f709-4841-a41d-7f2d6cdccca3/identities?api_key=2b206745-6fa6-40df-a0ea-0364c091bccb


<br/>

## Add Access Group Identity API

Using the IdentityID, you can add an identity to an Access Group.

**URL**

``api/v1/accesscontrol/accessgroups/<accessgroupid>/identities/<identityid>``

**URL Params**

*Required*  
api_key=[api key]

> [!NOTE]
> Optionally, you can provide the api key as a header named x-api-key

**Method**

POST

**Success Response**

Code: 200 OK

**Error Response** 

Code: 500 Internal Server Error

**Example**

https://mydomain.com/invision/api/v1/accesscontrol/accessgroups/cafdd2dd-f709-4841-a41d-7f2d6cdccca3/identities/c6c52e0d-812f-47d1-9795-eb011c2eba03?api_key=2b206745-6fa6-40df-a0ea-0364c091bccb

<br/>

## Delete Access Group Identity API

Using the **IdentityID**, you can add an identity to the Access Group.

**URL**

``api/v1/accesscontrol/accessgroups/<accessgroupid>/identities/<identityid>``

**URL Params**

*Required*  
api_key=[api key]

> [!NOTE]
> Optionally, you can provide the api key as a header named x-api-key

**Method**

DELETE

**Success Response**

Code: 200 OK

**Error Response** 

Code: 500 Internal Server Error

**Example**

https://mydomain.com/invision/api/v1/accesscontrol/accessgroups/cafdd2dd-f709-4841-a41d-7f2d6cdccca3/identities/c6c52e0d-812f-47d1-9795-eb011c2eba03?api_key=2b206745-6fa6-40df-a0ea-0364c091bccb


<br/>

## Get Access Groups API

This API gets a list of all  Access Groups.

**URL**

api/v1/accesscontrol/accessgroups

**Method**

GET

**URL Params**

Required api_key=[api key]

> [!NOTE]
> Optionally, you can provide the API key as a header named x-api-key

**Success Response**

Code: 200 OK

**Content:**

```
[

  {

    "id":"2cbf5b23-a9d3-4743-87d7-733e0c2bd08e",

    "name":"My Access Group"

  }

]
```


**Error Response**

Code: 500 Internal Server Error

**Example**

https://mydomain.com/invision/api/v1/accesscontrol/accessgroups?api_key=2b206745-6fa6-40df-a0ea-0364c091bccb

 












<br/>

## See Also 
* [Identities](identities.md)

<br/>

## Videos

* [Access Control](../../videos/accesscontrol.md)
* [Create and Manage Azure AD Identities and Access Groups](https://profitbasedocs.blob.core.windows.net/videos/Users%20and%20Permissions%20-%20Create%20and%20Manage%20Azure%20AD%20Users%20and%20User%20Groups.mp4)