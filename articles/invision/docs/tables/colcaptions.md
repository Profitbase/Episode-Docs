
# Column Captions


## Column captions for Time Frame Columns

Time Frame columns represents data relatively to the Time Frame Reference Date of the repository. The Reference Date changes during Rollovers, and which means that the captions of the Time Frame columns should change. To make the captions follow along as the Time Frame changes without having to update them manually, the Caption Expression properties must be C# scripts that calls Time Frame relative functions which returns the date information for the column.
<br/>

## Functions:

``DateStart()``  
>*string*  
>Gets the start date that the column represents, using the default LongDatePattern format string for the current culture.

``DateStart(format:string)``  
>*string*  
>Same as DateStart(), but lets the user specify the format string.

``DateEnd()``  
>*string*  
>Gets the end date that the column represents, using the default LongDatePattern format string for the current culture.

``DateEnd(format:string)``  
>*string*  
>Same as DateEnd(), but lets the user specify the format string.

<br/>

## Year Functions:

``YearNum()``  
>*string*  

``NYearNum()``  
>*int32*  
>Gets the year part of the start date that the column represents.

``YearNumStart()``  
>*string*  

``NYearNumStart()``  
>*Int32*  
>Gets the year part of the start date that the column represents.

``YearNumEnd()``  
>*string*  
>Gets the year part of the end date that the column represents.

``NYearNumEnd()``  
>*int32*

<br/>

## Month Functions:

``MonthNum()``  
>*string*  

``NMonthNum()``  
>*int32*  
>Gets the month num of the start date that the column represents, applying 2 digits formatting.

``MonthNum(digits:int)``  
>*string*  
>Gets the month num of the start date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.

``MonthNumStart()``  
>*string* 

``NMonthNumStart()``  
>*int32*  
Gets the month num of the start date that the column represents, applying 2 digits formatting.

``MonthNumStart(digits:int)``  
>*string*  
Gets the month num of the start date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.

``MonthNumEnd()``  
>*string*  

``NMonthNumEnd()``  
>*int32*  
Gets the month num of the end date that the column represents, applying 2 digits formatting.

``MonthNumEnd(digits:int)``  
>*string*  
Gets the month num of the end date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.

``MonthNameStart()``  
>*string*  

``MonthNameEnd()``  
>*string*

<br/>

## Week Functions:

``WeekNum()``  
>*string*  

``NWeekNum()``  
>*int32*  
>Gets the week of the year from the start date that the column represents, applying 2 digits formatting.

``WeekNumStart()``  
>*string*  

``NWeekNumStart()``  
>*int32*  
Gets the week of the year from the start date that the column represents, applying 2 digits formatting.

``WeekNumStart(digits:int)``  
>*string*  
Gets the week of the year from the start date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.

``WeekNumEnd()``  
>*string*  

``NWeekNumEnd()``  
>*int32*  
Gets the week of the year from the end date that the column represents, applying 2 digits formatting.

``WeekNumEnd(digits:int)``  
>*string*  
Gets the week of the year from the end date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.

<br/>

## Day of Week Functions:

``DayOfWeekName()``  
>*string*  
Gets the name of the week day from the start date that the column represents.

``DayOfWeekNameStart()``  
>*string*  
Gets the name of the week day from the start date that the column represents.

``DayOfWeekNameEnd()``  
>*string*  
Gets the name of the week day from the end date that the column represents.

``DayOfWeekNum()``  
>*string*  

``NDayOrWeekNum()``  
>*int32*  
Gets the week day number from the start date that the column represents.

``DayOfWeekNumStart()``  
>*string*  

``NDayOrWeekNumStart()``  
>*int32*  
Gets the week day number from the start date that the column represents.

``DayOfWeekNumEnd()``  
>*string*  

``NDayOrWeekNumEnd()``  
>*int32*  
Gets the week day number from the end date that the column represents.

<br/>

## Day of Month Functions: 

``DayOfMonthNum()``  
>*string*  

``NDayOfMonthNum()``  
>*int32*  
Gets the month day number from the start date that the column represents, applying 2 digits formatting. 

``DayOfMonthNumStart()``  
>*string*  

``NDayOfMonthNumStart()``  
>*int32*  
Gets the month day number from the start date that the column represents, applying 2 digits formatting.

``DayOfMonthNumStart(digits:int)``  
>*string*  
Gets the month day number from the start date that the column represents, using the specified number of digits for formatting. If null is passed as the argument, no formatting is applied.

``DayOfMonthNumEnd()``  
>*string*  

``NDayOfMonthNumEnd()``  
>*int32*  
Gets the month day number from the end date that the column represents, applying 2 digits formatting.

``DayOfMonthNumEnd(digits:int)``  
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


## Videos

* [Worksheet](../../videos/worksheet.md)
* [Column captions for Time Frame Columns](https://profitbasedocs.blob.core.windows.net/videos/Worksheet%20-%20Column%20captions%20for%20Time%20Frame%20Columns.mp4)