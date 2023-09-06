---
title: "Dropdown"
metaKeys: "Dropdown, Enabled editing data using a dropdown list, Value Member, Display Member, Save Data Expression"
pageIndex: 2
---

<br/>

![ddn](https://profitbasedocs.blob.core.windows.net/images/drDown.png)

<br/>


#### Enabled editing data using a dropdown list.

**Select Value Query**

Specifies the Data Query which returns a single value displayed as the currently selected value when the Dropdown is loaded. 

**Items Source Query**

Specifies a Data Query returning the list of elements that the user can choose from using the Dropdown editor. 

The query must always return two columns, the Display Member column and the Value Member column. The value of the Display Member column is displayed to the user, while the value of the Value Member column is the actual value that is stored to the database when the selected value is saved. If you want to reference the same source column for both the Display and Value Member, you need to create an alias for the Display Member column. 

**Value Member**

Specifies the name of the column in the Items Source Query that contains the actual value being selected to the user and stored to the database.

**Display Member**

Specifies the name of the column in the Items Source Query that contains the value displayed to the user in the Dropdown list.

>**Example**
>
>This example shows a query returning a list of available dates for a course, using an alias for the Display Member column since we want to use the same source column for displaying and saving data.
>
    SELECT CourseDate, CourseDate AS CDisplay  
    FROM @Object[Courses].DbObjectName  
    WHERE CourseDate > GETDATE() AND CourseID = @CourseID 
>
>Using this query, you would specify **CourseDate** as the **Value Member** and **CDisplay** as the **Display Member**.

**Save Data Expression**

Specifies the Data Query used for saving data. The query must handle both insertion of a new row and updating an existing one. 

```
//Template for upsert statement
MERGE MyTargetTable AS [Target]
USING(SELECT @MyParam1 AS Key1, @MyParam2 AS Key2) AS [Source](Key1,Key2)
ON([Target].TKey1 = [Source].Key1 AND [Target].TKey2 = [Source].Key2)
WHEN MATCHED THEN UPDATE SET [Target].Value = @FormElementValue()
WHEN NOT MATCHED THEN
INSERT (TKey1,TKey2,Value) VALUES([Source].Key1,Source.Key2,@FormElementValue());
```


<br/>

#### See Also

* [Dropdown - Control](../formschemas/controls/dropdown.md)
* [Dropdown Selection](../../worksheets/columnproperties/dropdownselection.md)

<br/>

#### Videos

* [Dropdown](https://profitbasedocs.blob.core.windows.net/videos/Dropdown.mp4)