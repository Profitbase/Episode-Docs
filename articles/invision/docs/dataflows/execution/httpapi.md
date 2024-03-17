# Execution of Data Flows using an API

Data Flows can be executed through an **HTTP API**. To execute a Data Flow through the API, you need an **API Key**, the **Data Flow Id**, and the **API address**.
<br/>

## Getting an API Key

To get an API Key to use with the Data Flow Execution API, go to **Application Menu** -> **API Management** -> **Manage API Keys**. In the **Data Flow Execution** tab, find an existing key or create a new one. Use the API Key in the url or header in the request (see the example below).
<br/>

## Define API key in designer

1. Click the Edit command under the API Management menu item.
2. Select the Access Control tab.
3. Click the Add button.

<br/>

![apimanagement](https://profitbasedocs.blob.core.windows.net/images/apimanagement.png)
<br/>




## Start Execution API

This API starts the execution of a Data Flow. If you do not specify **await=true** as a url parameter, the API will return immediately after the Data Flow has been started. You should then use the Status API to check for completion by providing the RunId. 

**URL**

*api/pub/v1/dataflows/< id >/start*

**Method**

POST

**URL Params**

*Required*  
api_key=[api key]

> [!NOTE]
> Optionally, you can provide the API key as a header named x-api-key

*Optional*  
await=true (default = false)

> [!NOTE]
> Specifying **await=true** tells the API to not reply until the Data Flow has completed execution. You should carefully consider when to use this option, because Data Flows may take from seconds to hours to complete.

**Success Response**

Code: 200 OK  
Content: 
```json
    {
        runId : "execution run id", 
        status : "Pending" | "Running" | "Succeeded" | "Failed" 
    }
```

**Error Response**

Code: 500 Internal Server Error

**Example**

https://mydomain.com/invision/api/pub/v1/dataflows/2b081248-4963-43b3-ba06-5b7403d58b4d/start?api_key=dd63a1ad-60eb-4066-8d71-1721007437b4

<br/>

## Get Status API

Using the **RunId**, you can check the status of a Data Flow execution. You get the **RunId** from the **Start Execution API response**.

**URL**

`api/pub/v1/dataflows/< id >/runs/< runid >/status`

**URL Params**

*Required*

api_key=[api key]

> [!NOTE]
> Optionally, you can provide the api key as a header named x-api-key

**Method**

GET

**Success Response**

Code: 200 OK  
Content: 
```json


    {
        runId : "execution run id", 
        status : "Pending" | "Running" | "Succeeded" | "Failed" 
    }
```

**Error Response**
Code: 500 Internal Server Error

**Example**

https://mydomain.com/invision/api/pub/v1/dataflows/2b081248-4963-43b3-ba06-5b7403d58b4d/runs/ad73a1ad-60eb-1066-4d61-1821009431b2/status?api_key=dd63a1ad-60eb-4066-8d71-1721007437b4

## Videos

* [Data Flow](../../../videos/dataflows.md)
* [Execute from Workbook with arguments](https://profitbasedocs.blob.core.windows.net/videos/Data%20Flow%20-%20Execute%20from%20Workbook%20with%20arguments.mp4)
* [Execute Using dfcmdutil Command Line Tool](https://profitbasedocs.blob.core.windows.net/videos/Data%20Flow%20-%20Execute%20using%20dfcmdutil%20command%20line%20tool.mp4)
