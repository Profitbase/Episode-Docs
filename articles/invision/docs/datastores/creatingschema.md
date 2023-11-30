
# Creating Schema

![img](https://profitbasedocs.blob.core.windows.net/images/datastores.png)


##	Creating Data Store Schema 

Our Product Sales data store will consist of these columns: 

-	**DepartmentID** – Nvarchar(50) 
-	**ProductID** – Nvarchar(50) 
-	**HistSalesLY** – Decimal(18,4)
-	**MarginPCT** – Decimal(18,4) 
-	**P01Sales**- P12 Sales – Decimal(18,4) 
-	**Comments** – Nvarchar(350) 
-	**P01Cost** – P12Cost – Decimal(18,4)

**DepartmentID** and **ProductID** are key columns. This is indicated with key symbol left of the column name. The columns **P01Sales** to **P12Sales** and **P01Cost** to **P12Cost** are timeframe columns. This is indicated with small calendar symbol.

1.	Use the “add column” button to add the columns DepartmentID, ProductID, HistSalesLY and MarginPCT. 
2.	 Name them and give them the correct datatype. 
3.	Remember to check of “Is Key Column” for DepartmentID and ProductID.
4.	Click “Save” or Ctrl + S.
 
5.	Click the small “Arrow” on the “Add Column(s)” button and select “Add Time Frame Column(s)”, as shown by image below:

![Schema](https://profitbasedocs.blob.core.windows.net/images/DSschema1.png)

6.	Makes sure the “Add Time Frame Column(s)” pop up is filed out like this:

![Schema](https://profitbasedocs.blob.core.windows.net/images/DSschema2.png)

7.	Add the column Comments. You will see that there are no data type Nvarchar(350) in the dropdown menu. Use the Nvarchar(50) data type and edit the number of characters from 50 to 350 by double clicking on the respective cell.
8.	Repeat step 5 and 6 but this time changes “Column Name Sufix” to “Cost” instead of “Sales”.
9.	Click “Save” or Ctrl + S.

Your Schema should look like this: 

![Schema](https://profitbasedocs.blob.core.windows.net/images/DSschema3.png)

10.	Go to the “Time Frame” tab and check off the “Inherit from ancestor” checkbox.

Your time frame columns now represent each month from the reference date in the storegroup and 12 months forward. The offset represents how many resolutions (months in this case) from the reference date the column represents. This configuration is used to create a date for the transactions originating from each column through a pipeline in a later stage. 

<br/>

Check out how to Mapp the Source [Here](sourcemapping.md).

## Videos
* [Data Stores](../../videos/datastores.md)
* [Basics - Creating Schema and Source Mapping](https://profitbasedocs.blob.core.windows.net/videos/DS%20Basic%20-Creating%20Schema%20and%20source%20maping.mp4)