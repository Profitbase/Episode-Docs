
# Time Frame Measure Columns

Time Frame Measure Columns are special numeric columns with date/time metadata, which in conjunction with the [Time Frame](timeframe.md), associates the values of a column with an actual date/time.

Time Frame Measure Columns can be added to Data Stores and Settings to enable support for features such as [Periodic Input](periodicimput.md), [Rollover](rollover.md), and [Transaction Pipeline](transactionpipeline.md) Distribution.
The starting and ending date of a Time Frame Measure Column is always relative to its Time Frame configuration. The date range (start-end) of a Time Frame Measure Column is defined by its Offset and Length properties. 

The Offset represents the starting date of the column by specifying its position relative to the origin along the Time Frame x-axis.

The Length property represents the ending date of the column by specifying its position relative to the Offset property along the Time Frame x-axis.

Having specified the Offset and Length properties of a column, the date (range) is calculated based on the Time Frame Resolution (day, week, month, quarter, year) and the Time Frame Reference Date.

In addition to adding support for the features mentioned above, Time Frame Measure Columns makes it easy to use the Unpivot and Pivot Data Import Transforms for Data Stores to convert between a transaction based format and a periodic format.

**Example**

Suppose you have the following Time Frame configuration:
Store Reference Date : 2014.01.01  
Resolution : Month  
Calendar Type : Natural  

Time Frame Measure Column «P01» has Offset and Length as follows:
Offset: 0  
Length: 1  

Offset 0 will represent the start date of 2014.01.01 + 0 months = 2014.01.01.
Length 1 will represent the end date of 2014.01.01 + 1 month = 2014.01.31

**Start and end date for «P01» will be 01.01.2014-31.01.2014**

Time Frame Measure Column «P03» has Offset and Length as follows:  

Offset: 3  
Length: 2  

Offset 3 will represent the start date of 2014.01.01 + 3 months = 2014.04.01.  
Length 2 will represent the end date of 2014.04.01 + 2 months = 2014.05.31.  

**Start and end date for «P03» will be 2014.04.01 – 2014.05.31**  

<br/>

## Videos

* [Datastores](../../videos/datastores.md)
* [Time Frame, Time Frame Columns and Rolling Forecast](https://profitbasedocs.blob.core.windows.net/videos/Data%20Store%20-%20Time%20Frame%2C%20Time%20Frame%20Columns%20and%20Rolling%20Forecast.mp4)