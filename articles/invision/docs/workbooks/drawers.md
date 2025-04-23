# Drawers

A drawer is a panel that slides in from the right, displaying a [Workbook Page](./pages.md) inside the panel.  

![img](/images/invision/drawer-example-1.png)

Drawers are typically used for providing tools or supporting details for data in the primary page, and then quickly dismissed by the user when they are done.  
A drawer can be resized and closed by the user, and programatically opened and closed by calling the `Navigate To`, `Show` or `Hide` actions of the displayed Workbook Page.  

To display a page in a Drawer, to the following:  
1) Create a Workbook Page, then in the Properties panel, enable `Display in Drawer`.
2) Optionally, specify the initial width of the Drawer.
3) Call the `Navigate To` or `Show` action of the Workbook Page, for example from a button click or spreadsheet cell click.  

