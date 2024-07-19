
# Feedback


This functionality allows sending feedback in the Invision client. 

![Feedback](https://profitbasedocs.blob.core.windows.net/images/feedback2.png)

<br/>

The feedback functionality has a default recipient address feedback@profitbase.com. This can be changed through the Solution Variable functionality in the designer

<br/>

> [!NOTE]
> The **EmailTo** property from appsettings has a default value, however it can have many recipients. This can be overridden with a [SolutionVariable](../solution-variables.md) **(FEEDBACK_EMAILTO)**.

<br/>

Expression emojis are clickable to set a "feedback mood," which will be provided in the feedback email.
<br/>

![Feedback](https://profitbasedocs.blob.core.windows.net/images/feedback1.png)


<br/>
After the feedback is sent, the assigned recipient receives an email with all the data, such as the email of the logged-in user, the name and ID of the solution, and the content of the feedback.

![Feedback](https://profitbasedocs.blob.core.windows.net/images/feedback5.png)

## See Also

[SolutionVariable](../solution-variables.md)