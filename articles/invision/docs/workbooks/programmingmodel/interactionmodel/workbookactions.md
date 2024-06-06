
# Workbook Actions

## Execute Expression

Executes one or more statements.
Please refer to the [API topic](../apis.md) for further reading.  

![execute expression](../../../../../../images/invision/execute-expression-action.png)

<br/>

## Send Message

Sends messages to other Workbooks.

> [!IMPORTANT]
> This API is being deprecated. Use the [Message Hub API](../apis/message-hub-apis.md) in an `Execute Expression` action instead.

## Invoke Action Group

Invokes another Action Group. Configure the invocation using the [ConfigureInvocation(…)](../instructions/configinvocation.md) function.

<br/>

## Web Api

> [!IMPORTANT]
> This API is being deprecated. Use the [HTTP API](../apis/http-apis.md) in an `Execute Expression` action instead.

 Invokes an HTTP request by calling one of the following methods in the expression:
```
HttpGet(url)
HttpPost(url, httpContent)
HttpPut(url, httpContent)
HttpPatch(url, httpContent)
HttpDelete(url)
```  

Add **headers** by calling the AddHeader(name, value) method.

<br/>

## Download File

> [!IMPORTANT]
> This API is being deprecated. Use the [HTTP API](../apis/http-apis.md) or [Flow API](../apis/flow-apis.md) in an `Execute Expression` action instead.

Downloads a file to the browser by calling one of the following methods in the expression:
```
SetSrc(url)
SetSrcIf(boolean expression, trueUrl, falseUrl)
```

