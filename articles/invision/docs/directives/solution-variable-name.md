# @SolutionVariable[Name]


The `@SolutionVariable[Name]` directive returns the value of a Solution Variable defined in the current Solution.  
Solution Variables are global key/value pairs configured in the **Solution Variables** tab and can be used for storing constants, environment flags, or configuration values.

This directive allows you to reference these variables directly in SQL queries, custom filters, and Data Flow items.


```text
@SolutionVariable[VariableName]
```

**Example**

The name of the Solution Variable is defined in the [Solution Variables](../solution-variables.md) tab in [Workbook](../workbooks.md).

![img](/images/invision/solution-variables2.png)

<br/>

```SQL query
SELECT '@SolutionVariable[SubscriptionPlan]' AS SubscriptionPlan;
```

**Result:**

|  SubscriptionPlan          |                                                                  |
|-----------------|-----------------------------------------------------------------------------|
|    Premium       |                                                     |

![img](/images/invision/solution-variables3.png)

<br/>





**Using in C# expressions**

When inside a C# expression field, wrap the directive in the Directive("...") function:

```c#
(string)Directive("@SolutionVariable[SubscriptionPlan]") == "Premium"
```


Returns the value as a System.Object

Cast it to the expected type (string, int, bool, etc.)

Use cases

Store environment-specific values (e.g., FLOW_ENVIRONMENT, ApiBaseUrl).

Centralize constants like limits, schema names, or feature toggles.

Reuse the same variable across multiple SQL queries and Data Flows without hard-coding.

