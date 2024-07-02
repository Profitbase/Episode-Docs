
# Feedback


This functionality allows to send a feedback in the Invision client. 

![Feedback](https://profitbasedocs.blob.core.windows.net/images/feedback2.png)

<br/>

It is a part of the standard header as default. To change that, remove the APIkey for the sendmail service from appsettings.json file.

![Feedback](https://profitbasedocs.blob.core.windows.net/images/feedback1.png)

<br/>

> [!NOTE]
> The **EmailTo** property from appsettings has a default value, however it can have many recipients. This can be overridden with a [SolutionVariable](../solution-variables.md) **(FEEDBACK_EMAILTO)**.


<br/>
After the feedback is sent, asigned recipient is getting an email with all the data, such as email of the logged in user, name and ID of the solution, and the content of the feedback.

![Feedback](https://profitbasedocs.blob.core.windows.net/images/feedback5.png)

## See Also

[SolutionVariable](../solution-variables.md)