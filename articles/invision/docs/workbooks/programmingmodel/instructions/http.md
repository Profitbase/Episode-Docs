---
title: "Http"
metaKeys: "Http, Get, Post, Put, Patch, Delete "
folderOnly: "false"
pageIndex: 11
---

### Get

<br/>

```
HttpGet(url)
```

When called from a WebApi action, issues an Http GET request to the specified address.
<br/>

>**Example**
>
>This example shows how to issue an Http GET request from a WebApi action and update the value of a Text Input (Workbook) element. In the WebApi action, we're calling HttpGet(…) and storing the request handle in the _requestHandle variable.
>
```
_requestHandle = HttpPatch("api/webfunctions/Get_Product_Info?productid=abc");
```
>
>After the WebApi action has completed, we can access the data returned form Http Request (in this case, it's an object with a ProductName property) through the .Data property of the request handle, for example in an ExecuteExpression or Input UpdateValue action. 
>
```
Input_ProductName.Value = _requestHandle.Data.ProductName;
```

<br/>

### Post

```
HttpPost(url : string, httpContent : object)
```

When called from a WebApi action, issues an Http POST request to the specified address.
<br/>

### Put

```
HttpPut(url : string, httpContent : object)
```
When called from a WebApi action, issues an Http PUT request to the specified address.
<br/>

### Patch

```
HttpPatch(url : string, httpContent : object)
```
When called from a WebApi action, issues an Http PATCH request to the specified address.
<br/>

>**Example**
>
>This example shows how to issue an Http PATCH request from a WebApi action and update the value of a Text Input (Workbook) element. In the WebApi action, we're calling HttpPatch(…) and storing the request handle in the _requestHandle variable.
>
```
_requestHandle = HttpPatch("api/webfunctions/My_Web_Function", {"Level" : 1});
```
>
>After the WebApi action has completed, we can access the data returned form Http Request through the .Data property of the request handle, for example in an ExecuteExpression or Input UpdateValue action.
>
```
Input_Level.Value = _requestHandle.Data;
```

<br/>

### Delete

```
HttpDelete(url : string)
```

When called from a WebApi action, issues an Http DELETE request to the specified address.
 