# Function

Write C# code for custom business logic.


![img](../../../../images/flow/functionDoc.png)

**Example** ![img](../../../../images/strz.jpg)  
This flow retrieves a [sitemap](../../actions/http/get-sitemap.md) from a specified URL, [validates](if.md) its structure and content, and [throws an exception](throw-exception.md) if the validation fails.

<br/>

## Properties

| Name               | Data Type | Description                                                   |
|--------------------|-----------|---------------------------------------------------------------|
| Title              | Optional  | The title or name of the action.                              |
| Function Name      | Optional  | The name of the function being defined.                       |
| Function Definition | Required  | The logic or implementation of the function.                 |
| Description        | Optional  | Additional notes or comments about the action or configuration. |

<br/>

## Detailed description:

This flow is designed to automatically verify the integrity and completeness of a website’s sitemap and alert the user if it doesn’t meet defined criteria.  
The flow consists of four main actions:

1. **Get sitemap** – Downloads the sitemap from the provided URL (in this case, https://docs.profitbase.com) and outputs it as the variable sitemap.

![img](../../../../images/flow/functionDoc1.png)

2. **Validate sitemap**  

![img](../../../../images/flow/functionDoc2.png)

<br/>

The result of this validation is returned as a boolean variable sitemapOk.

![img](../../../../images/flow/functionDoc3.png)

<br/>

A custom function that checks the sitemap’s content. It verifies that:
- It includes a URL ending with cfo-platform/data-platform/overview.html (the expected first URL),
- It includes a URL ending with flow/changelog.html (the expected last URL),
- The sitemap contains more than 100 entries.

![img](../../../../images/flow/functionDoc4.png)

<br/>

3. **Check sitemap** – Evaluates whether sitemapOk is true. If so, the flow continues. If false, it triggers an exception.

![img](../../../../images/flow/functionDoc5.png)

4. **Throw exception** – If the sitemap validation fails, this action raises an error with the message “Sitemap validation failed.”

![img](../../../../images/flow/functionDoc6.png)




