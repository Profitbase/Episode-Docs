---
title: "Column Captions"
metaKeys: "Column captions, Time Frame, Columns, data, DateStart, DateEnd, Year Functions, YearNum, Year , NYearNum, NYear , YearNumStart , NYearNumStart , YearNumEnd, NYearNumEnd , Month Functions, MonthNum , NMonthNum , MonthNum, MonthNumStart , NMonthNumStart , MonthNumStart,MonthNumEnd , NMonthNumEnd , MonthNumEnd, MonthNameStart, MonthNameEnd, Week Functions, WeekNum, NWeekNum, WeekNumStart, NWeekNumStart, WeekNumStart, WeekNumEnd, NWeekNumEnd, WeekNumEnd, DayOfWeekNameStart, DayOfWeekNameEnd, DayOfWeekNum, NDayOrWeekNum, DayOfWeekNumStart, NDayOrWeekNumStart, DayOfWeekNumEnd, NDayOrWeekNumEnd, Day of Month Functions, DayOfMonthNum, NDayOfMonthNum, DayOfMonthNumStart, NDayOfMonthNumStart, DayOfMonthNumStart, DayOfMonthNumEnd, NDayOfMonthNumEnd, DayOfMonthNumEnd "
pageIndex: 4
---



### Column captions for Time Frame Columns

Time Frame columns represents data relatively to the Time Frame Reference Date of the repository. The Reference Date changes during Rollovers, and which means that the captions of the Time Frame columns should change. To make the captions follow along as the Time Frame changes without having to update them manually, the Caption Expression properties must be C# scripts that calls Time Frame relative functions which returns the date information for the column.
<br/>

### Functions:
<br/>

``DateStart()``  

<br/>

>*string*  
>Gets the start date that the column represents, using the default LongDatePattern format string for the current culture.

``DateStart(format:string)``  
<br/>

>*string*  
>Same as DateStart(), but lets the user specify the format string.

``DateEnd()``  
<br/>

>*string*  
>Gets the end date that the column represents, using the default LongDatePattern format string for the current culture.
<br/>

``DateEnd(format:string)``  
>*string*  
>Same as DateEnd(), but lets the user specify the format string.

<br/>

### Year Functions:
<br/>

``YearNum()``  
<br/>

>*string*  
<br/>

``NYearNum()``  
<br/>

>*int32*  
>Gets the year part of the start date that the column represents.
<br/>

``YearNumStart()`` 
<br/>

>*string*  
<br/>

``NYearNumStart()``  
<br/>

>*Int32*  
>Gets the year part of the start date that the column represents.
<br/>

``YearNumEnd()``  
<br/>

>*string*  
>Gets the year part of the end date that the column represents.
<br/>

``NYearNumEnd()``  
<br/>

>*int32*

<br/>

### Month Functions:
<br/>

``MonthNum()``  
<br/>

>*string*  
<br/>

``NMonthNum()``  
<br/>

>*int32*  
>Gets the month num of the start date that the column represents, applying 2 digits formatting.
<br/>

``MonthNum(digits:int)``  
<br/>

>*string*  
>Gets the month num of the start date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.
<br/>

``MonthNumStart()`` 
<br/>

>*string* 
<br/>

``NMonthNumStart()``  
<br/>

>*int32*  
Gets the month num of the start date that the column represents, applying 2 digits formatting.
<br/>

``MonthNumStart(digits:int)``  
<br/>

>*string*  
Gets the month num of the start date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.
<br/>

``MonthNumEnd()``  
<br/>

>*string*  
<br/>

``NMonthNumEnd()``  
<br/>

>*int32*  
Gets the month num of the end date that the column represents, applying 2 digits formatting.
<br/>

``MonthNumEnd(digits:int)``  
<br/>

>*string*  
Gets the month num of the end date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.
<br/>

``MonthNameStart()``  
<br/>

>*string*  
<br/>

``MonthNameEnd()``  
<br/>

>*string*

<br/>

### Week Functions:
<br/>

``WeekNum()``  
<br/>

>*string*  
<br/>

``NWeekNum()``  
<br/>

>*int32*  
>Gets the week of the year from the start date that the column represents, applying 2 digits formatting.
<br/>

``WeekNumStart()``  
<br/>

>*string*  
<br/>

``NWeekNumStart()``  
<br/>

>*int32*  
Gets the week of the year from the start date that the column represents, applying 2 digits formatting.
<br/>

``WeekNumStart(digits:int)``
<br/>

>*string*  
Gets the week of the year from the start date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.
<br/>

``WeekNumEnd()``  
<br/>

>*string*  
<br/>

``NWeekNumEnd()``  
<br/>

>*int32*  
Gets the week of the year from the end date that the column represents, applying 2 digits formatting.
<br/>

``WeekNumEnd(digits:int)``  
<br/>

>*string*  
Gets the week of the year from the end date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.

<br/>

### Day of Week Functions:
<br/>

``DayOfWeekName()``  
<br/>

>*string*  
Gets the name of the week day from the start date that the column represents.
<br/>

``DayOfWeekNameStart()``  
<br/>

>*string*  
Gets the name of the week day from the start date that the column represents.
<br/>

``DayOfWeekNameEnd()``  
<br/>

>*string*  
Gets the name of the week day from the end date that the column represents.
<br/>

``DayOfWeekNum()``  
<br/>

>*string*  
<br/>


``NDayOrWeekNum()``  
<br/>

>*int32*  
Gets the week day number from the start date that the column represents.
<br/>

``DayOfWeekNumStart()``  
<br/>

>*string*  
<br/>

``NDayOrWeekNumStart()``  
<br/>

>*int32*  
Gets the week day number from the start date that the column represents.
<br/>

``DayOfWeekNumEnd()``  
<br/>

>*string*  
<br/>

``NDayOrWeekNumEnd()``  
<br/>

>*int32*  
Gets the week day number from the end date that the column represents.

<br/>

### Day of Month Functions: 
<br/>

``DayOfMonthNum()``
<br/>

>*string*  
<br/>

``NDayOfMonthNum()``  
<br/>

>*int32*  
Gets the month day number from the start date that the column represents, applying 2 digits formatting. 
<br/>

``DayOfMonthNumStart()``  
<br/>

>*string*  
<br/>

``NDayOfMonthNumStart()``  
<br/>

>*int32*  
Gets the month day number from the start date that the column represents, applying 2 digits formatting.
<br/>

``DayOfMonthNumStart(digits:int)``  
<br/>

>*string*  
Gets the month day number from the start date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.
<br/>

``DayOfMonthNumEnd()``  
<br/>

>*string*  
<br/>

``NDayOfMonthNumEnd()``  
<br/>

>*int32*  
Gets the month day number from the end date that the column represents, applying 2 digits formatting.
<br/>

``DayOfMonthNumEnd(digits:int)``  
<br/>

>*string*  
Gets the month day number from the end date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.


<br/>


>**Example**
>
>Time Frame Reference Date is 1. januar 2021

    YearNum() + MonthNum() returns the text 202101
    YearNum() + " " + MonthNum() returns the text 2021 01
    YearNum() + "-P" + MonthNum() returns the text 2021-P01
    MonthNameStart().Substring(0,3) + ". " + YearNum() returns the text Jan. 2021


<br/>

### Videos

* [Worksheet](../../videos/worksheet.md)
* [Column captions for Time Frame Columns](https://profitbasedocs.blob.core.windows.net/videos/Worksheet%20-%20Column%20captions%20for%20Time%20Frame%20Columns.mp4)