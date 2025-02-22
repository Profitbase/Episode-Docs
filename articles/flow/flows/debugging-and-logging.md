
#### Debugging and logging

By default, Profitbase Flow only logs the start and end of executions. If you want to log anything else, you need to do this manually using a [Function](../actions/built-in/function.md) action and one of the `Context.Diagnostics.Log` or the shorthand `Context.Log` APIs.

<br/>

```csharp
public async Task Foo()
{
    await this.Context.Log.Error(…) // Write an error to the log. It will also set the final status of the run as failed.  
    await this.Context.Log.Warning(…) // Write a warning to the log.  
    await this.Context.Log.Information(…) // Write an information entry to the log.  
    await this.Context.Log.Debug(…) // Write an entry to the debug log.  
}


```

When you run a Flow from the Designer, any log and debug information will appear in the bottom panel.  


<br/>

![img](../../../images/debug2.png)


To view logs from previous runs, open the [Execution logs](execution-logs.md) window from the `Resources` menu in the application bar.

<br/>

![img](../../../images/open-flow-execution-logs.png)