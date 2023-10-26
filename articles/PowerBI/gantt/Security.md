This Security Statement is aimed at providing you with information about the measures put in place to ensure your data is handled securely by the Profitbase Gantt. Project data is highly sensitive information, and we are committed to protecting your data from any unwanted or unauthorized access.

### 1. Certified by Microsoft _(Pending)_
Profitbase Gantt is certified by Microsoft. This means that the visual is tested by Microsoft to verify 
that it doesn't access external services or resources, and that it follow secure coding patterns and guidelines.

### 2. Hosting model and data  
The image below describes how the Visual is hosted and isolated in Power BI, and how data is ingested and managed by the Visual.
Profitbase Gantt is a Power BI custom visual. Each custom visual run in an isolate sandbox within a Power BI report page, called an iFrame. All data available to the visual is pushed from the Power BI model and query engine TO the visual. The visual does not fetch any data on its own.  

![Gantt Security](https://user-images.githubusercontent.com/82056309/193035643-3fc357a2-8885-4615-ba7b-b4c29bb20bda.png)


### 3. Hosting model and isolation  
The Visual does not in any way access data or any other type of information outside of the Visual itself, including its hosting environment.  