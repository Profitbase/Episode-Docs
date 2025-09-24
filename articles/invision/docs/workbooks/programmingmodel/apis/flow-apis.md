# Flow API

The following APIs can be used in any [Execute Expression](../interactionmodel/workbookactions.md#execute-expression) Actions or [Form Schema functions](../../../forms/formschemas/functions.md).

#### execute(string, object)

Executes a short-running Flow in the current Solution and returns data if the Flow is configured to do so.

##### API Definition

```javascript
this.app.services.flow.execute(flowName: string, {
    solutionId?: string,
    environment?: string,
    data: {}
}) : Promise<any>
```

| Property       |  Description                           |
|----------------|----------------------------------------|
| flowName       | The name of the Flow in the Solution to execute. |
| solutionId     | Optional. Specify this property if you want to run a named Flow that belongs to a differnet Solution than the open Workbook. |
| environment    | Optional. Specify this option of you want to override the FLOW_ENVIRONMENT Solution Variable. |
| data           | Optional. Specifies the arguments to send to the Flow.  |

## Returns

The API returns a response object with the following properties.

| Property      | Description                        |
|---------------|------------------------------------|
| data          | The data returned from the executed Flow (if any). This may be null, a simple value, or a complex object.  |
| status        | The HTTP status code.              |

##### Example

This example shows how to run a Flow that returns a value (price) and displays the result in a message box. You can run this code in an [Execute Expression](../interactionmodel/workbookactions.md#execute-expression) Actions or [Form Schema functions](../../../forms/formschemas/functions.md).  

```javascript

const response = await this.app.services.flow.execute('Calculate Price', {
    data: {
        productId: this.app.variables._state.selectedProductId,
        qty: 30
    }
});

this.app.ui.dialogs.showMessage(`The calculated price is ${response.data}`);

```


#### download(string, data)

Executes a short-running Flow that returns a file, and downloads the file. Use this API if you have a Flow that returns a file that you want to download in the browser.

##### API Definition

```javascript

this.app.services.flow.download(flowName: string, {
    solutionId?: string,
    environment?: string,
    data: {}
}) : Promise<void>

```

##### Example

The following example shows how run a Flow named `Export to Excel` creates an Excel file for the selected department, and then download the file to user.

```javascript
await this.app.services.flow.download("Export to Excel", {
    data: {
        departmentId: this.app.filters.get("Filters", "Department").selectedValue.Id
    }
});
```

![flow-api-download-file](../../../../../../images/invision/flow-api-download-file.png)

<br/>

#### getExecutions(string | {objectId?: string, name?: string}, request: {solutionId?: string}): Promise<FlowExecution[]>  
Returns an array of [FlowExecutions](#flowexecution) for the specified Flow (based on the `name` or the `objectId`).  
You can then use the the `getExecutionLog` API to fetch the log items for the execution by providing the jobId (see example below).

##### API Definition
```javascript
this.app.services.flow.getExecutions(flowName: string | { objectId?: string, name?: string }, request?: {solutionId?: string}): Promise<FlowExecution[]>
```

| Property       |  Description                           |
|----------------|----------------------------------------|
| flowName | {objectId?: string, name?: string} | Specifies the name of the Flow to execute, or the Solution Object Id of the Flow to execute. The most common use case is to use the name of the Flow. If you are using the API in a generic component and you don't know the name of the Flow upfront, you can use the request object with the objectId instead (like shown in the example below). |
| request: {solutionId?: string}    | Optional. Specify a request object with the SolutionId if you want to run a Flow in a different Solution than the Workbook. |

##### Example
The example below shows how to get an array of all executions of a Flow. It then picks the first item in the array and uses the 
`jobId` to fetch the log items for the execution.  

```javascript
const objectId = 'the-guid'; // This is the id of the Flow object in the _Solution Explorer_. Note that this is not the same as the FlowId.
const executions = await this.app.services.flow.getExcutions({objectId});
if(executions.lenght > 0){
    const jobId = executions[0].jobId;
    const logItems = await this.app.services.flow.getExecutionLog({objectId}, jobId);
}

// Alternatively, you can use the name of the Flow instead of the object id.
const flowName = 'My flow';
const executions = await this.app.services.flow.getExcutions(flowName);
if(executions.lenght > 0){
    const jobId = executions[0].jobId;
    const logItems = await this.app.services.flow.getExecutionLog(flowName, jobId);
}
```

<br/>

#### getExecutionLog(name: string | {objectId?: string, name?: string}, jobId: string, request?: {solutionId?: string})
Returns the log items for a specific Flow execution based on the `jobId` (See example above).

##### API definition
```javascript
this.app.services.flow.getExecutionLog(flowName: string | {objectId?: string, name?: string}, jobId: string, request?: {solutionId?: string}): Promise<FlowLogEntry[]>
```

<br/>

#### FlowEnvironment
```javascript
type FlowEnvironment = 'Development' | 'Test' | 'Production'
```


#### FlowExecutionState
```javascript
enum FlowExecutionState {
    submitted = 0,
    running = 1,
    completedOk = 2,
    completedWithWarning = 3,
    failed = 4,
}
```

#### FlowLogType
```javascript
enum FlowLogType {
    debug = 1,
    information = 2,
    success = 3,
    warning = 4,
    error = 5
}
```

#### FlowExecution
```javascript
type FlowExecution = {
    jobId: "string",
    message: "string",
    state: FlowExecutionState,
    environment: FlowEnvironment,
    startTime: "string",
    endTime: "string" | null
}
```

#### FlowLogEntry
```javascript
type FlowLogEntry = {
    flowId: "string",
    jobId: "string",
    data: "string",
    type: FlowLogType,
    logTimestamp: "string"
    logItemId: number
}
```