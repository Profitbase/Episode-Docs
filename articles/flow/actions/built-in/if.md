# If

Defines an If-Else decision with **two** possible outcomes.


![img](../../../../images/flow/If_builtIn.png)

**Example** ![img](../../../../images/strz.jpg)  
This flow retrieves a [sitemap](../../actions/http/get-sitemap.md) from a specified URL, [validates](function.md) its structure and content, and [throws an exception](throw-exception.md) if the validation fails.

<br/>


| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           | Optional | The title or name of the action.     |
| Condition         | Required   | Executes an action only if the specified condition evaluates to true. |
| Description   |    Optional   | Aditional informations about the action. |

<br/>

## Detailed description of the Flow example:

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

A custom [function](function.md) that checks the sitemap’s content. It verifies that:
- It includes a URL ending with cfo-platform/data-platform/overview.html (the expected first URL),
- It includes a URL ending with flow/changelog.html (the expected last URL),
- The sitemap contains more than 100 entries.

![img](../../../../images/flow/functionDoc4.png)

<br/>

3. **Check sitemap** – Evaluates whether sitemapOk is true. If so, the flow continues. If false, it triggers an exception.

![img](../../../../images/flow/functionDoc5.png)

4. **Throw exception** – If the sitemap validation fails, this action raises an error with the message “Sitemap validation failed.”

![img](../../../../images/flow/functionDoc6.png)
