
# How to use the Context Filter

Tables can be marked with one or more **contexts**, allowing the **Table Explorer** to filter and display only the relevant ones. To define the scope, assign one or more context labels to the tables — use a semicolon (`;`) to separate multiple contexts.

<br/>

## Example: Context "All Machines"

When adding a **Table Explorer** to a Workbook [Page](./../../workbooks/pages.md), setting the **Context filter** to `"All Machines"` will limit the view to only those tables that:

- Are marked as **Display in Table Explorer(s)**
- Have been marked with the context **"All Machines"**

As shown in ***Figure A***, tables such as **Cars**, **Excavators**, **Limousines**, **Mopeds** and **Trucks**, and have been assigned this context and are therefore visible.

![pic](https://profitbasedocs.blob.core.windows.net/images/table_explorer_web_contextfilter_1.png)
*Figure A: Tables filtered by context "All Machines"*

<br/>

## Example: Context "Big Machines"

Similarly, configuring the **Context filter** to `"Big Machines"` will display only those tables that:

- Are enabled for **Display in Table Explorer(s)**
- Are marked with the context **"Big Machines"**

In ***Figure B***, tables like **Bulldozers**, **Excavators** and **Trucks** are shown, as they match the selected context.


![pic](https://profitbasedocs.blob.core.windows.net/images/table_explorer_web_contextfilter_2.png)
*Figure B*