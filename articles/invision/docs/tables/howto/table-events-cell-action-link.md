---
title: "How to Set Cell Action Link Tapped Event"
metaKeys: "How to set Cell Action Link Tapped Event"
folderOnly: "false"
pageIndex: 2
---

In this section, you will find examples on how to Set Cell Action Link Tapped Event. 

* [Video Example 1](https://profitbasedocs.blob.core.windows.net/videos/Table%20Events%20-%20Cell%20Action%20Link%20Tapped%20(2).mp4)
* [Video Example 2](https://profitbasedocs.blob.core.windows.net/videos/Table%20Events%20-%20Cell%20Action%20Link%20Tapped.mp4) 
* [Documentation](../../workbooks/components/table.md)
  
<br/>

### Step by step


1. Choose css class for the column:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTcelLinkTapped%20(1).png)

2. Write the formatter:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTcelLinkTapped%20(2).png)

3. Check "is Action Link Column" box in properties:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTcelLinkTapped%20(3).png)

4. Place SQL in the Workbook:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTcelLinkTapped%20(4).png)

5. Write SQL which you want to execute after clicking the link in the column:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTcelLinkTapped%20(5).png)

6. Add OnTapped event in the button:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTcelLinkTapped%20(6).png)

7. Add Load action to make sure that refreshed table will apear after deleting the data:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTcelLinkTapped%20(7).png)

8. Add event for the column in the table as well:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTcelLinkTapped%20(8).png)