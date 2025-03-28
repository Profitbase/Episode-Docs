# Refresh Table artifacts

This action refreshes artifacts associated with [InVision Tables](../../../../invision/docs/tables/index.md).  

> [!NOTE]
> You must use this action if you modify data in Tables using a [SQL Script](../../../../invision/docs/sqlscripts/index.md) or other methods that directly manipulate the database table, instead of using InVision of Flow APIs.  
> You don't have to use this action when updating InVision Tables using the built-in data import APIs or when users updates data through the UI.

<br/>

The following artifacts are updated:  

- **Ranked input**: If the table has [Ranked input](../../../../invision/docs/tables/rankedinput.md) enabled, this action regenerates the artifact table. 
- **Auto transaction**: If the table has the Auto transaction feature enabled, the artifact table used by Flow is synchronized with the main table.
- **Distribution key**: If the table has the Distribution key feature enabled, the artifact table used by Flow is synchronized with the main table.
- **Mapper**: If the table has the Mapper feature enabled, the artifact table used by Flow is synchronized with the main table.