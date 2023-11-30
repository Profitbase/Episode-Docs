
# View

InVision supports creating database Views. 
<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/View2.png)

<br/>


## Properties

<br/>

**Template Deployment Behavior**

> `Auto-Create during Template Deployment`  
> Specifies whether a view should be automatically created during template deployment. Views depending on other views should **not** be auto-created during template deployment, because the internal dependencies are not automatically resolved.
>
> This means that creating views that depend on other views during template deployment has a high risk of failing because there is a good chance that the dependencies do not already exist.
>
> If you need to create views as part of a template deployment process, you should create a Data Flow that creates the view in the correct order, and then set up the Data Flow to execute at the end of the template deployment process.



<br/>

## Videos

- [View Basics](https://profitbasedocs.blob.core.windows.net/videos/View%20-%20Basics.mp4)

<br/>
