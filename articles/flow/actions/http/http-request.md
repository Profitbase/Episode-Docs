# HTTP request

Executes an HTTP request. Use this action to call an HTTP API to run an operation and/or get data. 

![img](/images/flow/http-request.png)

### Dynamic URLs

You can use Flow variables or [Workspace Variables](../../workspaces/workspace-variables.md) to create dynamic URLs. 

![img](/images/flow/http-request-dynamic-url.png)

#### Defining the request Body
Usually, all APIs using the `POST` or `PUT` HTTP methods accepts a body payload.   
The request body can be defined by either referencing a variable containing the entire body payload (for example an object returned from a [Function](../built-in/function.md)), or by defining the payload as a [JSON](https://en.wikipedia.org/wiki/JSON) object.

##### Defining the request body from a variable

To get the request body from a variable, it needs to somehow be created first. In most cases, you can simply use a [Function](../built-in/function.md) to create and return the object that you want to send via the HTTP request. Note that the object you create must match the format in terms of structure, property names and data types that the HTTP API expects.  

To use a variable as the body payload, simply switch to the `Body` tab and select the object from the variable selector. This will serialize the object and send it to the API when the Flow runs.  

![img](/images/flow/http-request-body-variable.png)

##### Defining the request body by building a JSON object

You can manually construct the HTTP body by building a [JSON](https://en.wikipedia.org/wiki/JSON) object. 
- A JSON object must begin with `{` and end with `}`.  
- Property names must be quoted in double quotes.
- String and date values must be quoted in double quotes.
- Properties must be separated by commas.

When building the JSON object, you can combine hard-code values and variables as shown in the screenshot below.

> [!NOTE]
> You must remember to add quotes around string values, like shown with the `customerId`,`orderId`, and `productId` property below. Flow does not know which data type a property expects, so you will have to add quotes manually.

![img](/images/flow/http-request-body-json.png)

<br/>