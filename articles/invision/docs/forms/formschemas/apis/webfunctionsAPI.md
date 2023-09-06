---
title: "Web Functions API"
metaKeys: ""
pageIndex: 5
---

You can use the Web Functions API to run Web Functions from a Form.  
<br/>

**Example**
The example below shows how to use the Web Functions API to call a Web Function named with the endpoint name "CalculateResult".

```
<Function Name="Calculate" Async="true"><![CDATA[
          const result = await this.webFunctions.execute("CalculateResult", {a: 100, b: 200});
          console.log('100 + 200 is ' + result);
      ]]>
</Function>
```

**Example**

The example below shows how to use the Web Functions API to call a Web Function with the endpoint name "CalculateResult" using a query string to pass in a multiplication factor.

```
<Function Name="Calculate" Async="true"><![CDATA[
          const result = await this.webFunctions.execute("CalculateResult?factor=2", {a: 100, b: 200});
          console.log('(100 + 200) * 2 is ' + result);
      ]]>
</Function>
```

<br/>

**API Reference**

Asynchronously executes a Web Function in the current Solution and returns the result.

`execute(webFunctionEndpointName: string, data: any = null) : Promise<any>`

**Note!**  
The _Web Function Endpoint Name_ is displayed in the Web Function configuration editor in the Designer.
