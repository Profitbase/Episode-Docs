
# Solution variables

Solution Variables are globally available within a solution, meaning they can be accessed and used throughout the entire solution.

<br/>

### FEEDBACK_EMAILTO

When users send feedback from Workbooks, the feedback is sent to Profitbase as email. 
To customize the email address that the feedback is sent to, add a FEEDBACK_EMAILTO Solution variable and specify the recipient address(es).

![pic](https://profitbasedocs.blob.core.windows.net/images/solution_variables%20(2).png)

<br/>

### FLOW_ENVIRONMENT

Specify the FLOW_ENVIRONMENT Solution variable to override the default environment a Flow executes in. The default environment is Production.
When you run a Flow from a Worbook, you can also explicitly specify the Flow envionment. See [How to run Flows from Workbooks](./flows/how-to/run-flow-from-workbook.md) 

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/solution_variables%20(1).png)

<br/>

#### ARCHIVE OFF
To disable auto creation of archive tables for Data Stores, Views and Tables (which are Workflow DataSet members), set ARCHIVE=OFF.  

![img](/images/invision/solution-variables-archive-off.png)

## See Also

- [Feedback](header/feedback.md)


