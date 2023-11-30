
# Workbook Actions

##	ExecuteExpression

 Executes one or more **instructions**.
<br/>

## InvokeActionGroup

 Invokes another Action Group. Configure the invocation using the ConfigureInvocation(…) function.
<br/>

## WebApi

 Invokes an HTTP request by calling one of the following methods in the expression:

      HttpGet(url)

      HttpPost(url, httpContent)

      HttpPut(url, httpContent)

      HttpPatch(url, httpContent)

      HttpDelete(url)

Add **headers** by calling the AddHeader(name, value) method.


>**Example**
>
>See [this example](../../../webfunctions/calling.md) to learn how to call InVision Web Functions from a Workbook.

<br/>

## DownloadFile

 Downloads a file to the browser by calling one of the following methods in the expression:
    
      SetSrc(url)
      SetSrcIf(boolean expression, trueUrl, falseUrl)

