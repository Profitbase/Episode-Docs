# API

Specifies the endpoint of the writeback service.

When users edits and saves comments, the changes are sent to a service that writes back to the Direct Query data source used by the visual. If you try to edit and save data without specifying the API URL, you will get an error message.  

You will need a separate API endpoint for every visual in a report or dashboard (unless they use the same Direct Query data source).  

You have two options for creating a writeback service:  
1) Use Profitbase Flow. This is the easiest option, and only takes a few minutes to set up.
2) Create an Azure Function and implement the API for writing data to the data source yourself. If you choose this option, you will need a license for the visual.