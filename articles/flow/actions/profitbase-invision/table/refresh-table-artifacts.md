# Refresh Table artifacts

This action refreshes artifacts associated with InVision tables.  

> [!NOTE]
> You must use this action if you modify data in Tables using a `SQL Script` or other non-InVision or Flow standard APIs.  
> Standard APIs include user inputs and data imports through Flow or legacy InVision Dataflows.

<br/>

The following artifacts are updated:  

- **Ranked input**: If the table has Ranked input enabled, this action regenerates the artifact table. 
- **Auto transaction**: If the table has the Auto transaction feature enabled, the artifact table used by Flow is synchronized with the main table.
- **Distribution key**: If the table has the Distribution key feature enabled, the artifact table used by Flow is synchronized with the main table.
- **Mapper**: If the table has the Mapper feature enabled, the artifact table used by Flow is synchronized with the main table.