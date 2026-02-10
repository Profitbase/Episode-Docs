# UseFlow function
The UseFlow function is used by Workbook component actions such as the Worksheet [Load Data](../../components/worksheet.md#load-data) or [Send Data](../../components/worksheet.md#send-data) actions to specify which Flow should handle the request, for example which Flow to use for fetching data to a Worksheet or SQL Report.

The specified Flow must have the [Send Tabular Data trigger](../../../../../flow/triggers/invision/send-tabular-data-trigger.md) defined as the startup action.

**Example**  
```javascript
UseFlow("Update forecast", {
    environment: 'Production', // or 'Development' or 'Test'. Leave blank to use default
    data: {
        departmentId: "sales-NO",        
        version: "Jan-26-01"
    }
});
```

### UseFlow(string, object?)
The UseFlow function requires the name of the Flow to be specified. You can optionally specify an options object for passing arguments.  
The UseFlow function can only be called in the Instructions script of action handlers such as Send Data or Load Data of [Worksheets](../../components/worksheet.md), [Tables](../../components/table.md), [SQL Reports](../../components/reports.md) and [Table Views](../../components/tableview.md).  

##### API Definition

```javascript
UseFlow(flowName: string, {
    solutionId?: string,
    environment?: string,
    data: {}
})
```

| Property       |  Description                           |
|----------------|----------------------------------------|
| flowName       | The name of the Flow in the Solution to execute. |
| solutionId     | Optional. Specify this property if you want to run a named Flow that belongs to a differnet Solution than the open Workbook. |
| environment    | Optional. Specify this option of you want to override the FLOW_ENVIRONMENT Solution Variable. |
| data           | Optional. Specifies the arguments to send to the Flow.  |

<br/>

## Returns
If the specified Flow returns a DataPackage, the Worksheet, SQL Report, Table or TableView for which the action is called will update its data accordingly.

**Example**  
```javascript
UseFlow("Update forecast", {
    environment: 'Production', // or 'Development' or 'Test'. Leave blank to use default
    data: {
        departmentId: "sales-NO",        
        version: "Jan-26-01"
    }
});

// You can also pass parameters to Flow using SetParamValue
SetParamValue("@DataSetId", _state.DataSetId);
```

<br/>

![img](/images/invision/load-data-use-flow.png)