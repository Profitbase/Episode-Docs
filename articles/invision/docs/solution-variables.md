# Solution Variables


Solution Variables are global variables defined at the **Solution** level.  
They are useful for storing configuration values (such as environment flags, connection names, constants, or feature toggles) that you want to reuse across multiple Data Flows, queries, or forms without hard-coding them.

Solution Variables are defined as **Name/Value pairs** in the **Solution Variables** tab of a Solution.

## Creating custom Solution Variables
You can add your own Solution Variables in the **Solution Variables** tab:

1. Open your Solution in InVision.
2. Navigate to **Solution Variables**.
3. Click **Add** and enter:
   - **Name**: the identifier used when referencing the variable (e.g., `SubscriptionPlan`).
   - **Value**: the actual value (e.g., `Premium`).
4. Save your changes.

Variables created here are immediately available for use in Data Flows, SQL, and expressions.

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

##
# ARCHIVE OFF
To disable auto creation of archive tables for Data Stores, Views and Tables (which are Workflow DataSet members), set ARCHIVE=OFF.  

![img](/images/invision/solution-variables-archive-off.png)


## Reading Solution Variables

You can read Solution Variables using [Directives](../docs/directives/index.md), for example in SQL scripts, custom queries, etc. This gives developers a built-in mechanism to define global variables that are easier to use than the Lookup function, when there’s no need for conditional lookups.

### In SQL and custom queries

Use the [@SolutionVariable[Name]](../docs/directives/solution-variable-name.md) directive to inject the value of a Solution Variable directly into SQL:

```sql
SELECT '@SolutionVariable[SubscriptionPlan]' AS SubscriptionPlan;
```

![img](/images/invision/solution-variables2.png)

<br/>

![img](/images/invision/solution-variables3.png)

<br/>

## See Also

- [Feedback](header/feedback.md)


