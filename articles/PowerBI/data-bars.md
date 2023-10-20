In Edit mode; Right click column, and select "Add data bar"

The parent rows Bergen, Oslo and Stavanger compare to each other, as they are on the same level of the hierarchy.
Child rows compare to other child rows.

![image](https://user-images.githubusercontent.com/82056309/188615791-b7e92e8d-bd31-440d-96ca-6ebab176797a.png)


Once the data bar is applied, you will get a format panel for the data bar:

![image](https://user-images.githubusercontent.com/82056309/188615805-659f203a-2d02-49c0-86db-117a4e16adb6.png)

**Minimum**: default set to Lowest value in the column. Could be set to any value. 
If you have a value of -100, but set the minimum to "-50", then all rows with a value lower than -50 will have a full negative bar. 

Similar with **Maximum**.

**Positiv bar/Negative bar**: Set bar colors.

**Axis**: Set axis color

**Hide Axis for empty cell:** Will create a break in the axis if the value is empty.

**Apply for only this column**: Turn this ON if you only want the data bar for one specific column. Turn this OFF, and you will get a data bar for every instance of that measure. E.g. you have years on your column header, and add a data bar to your Actual measure. Turning this OFF will then apply a data bar to the Actual column for each year.

**Bar direction**: Set what should be the positive direction.

**Compare against**: 
Child Group: Each of the circled child groups contain one Maximum and one Minimum Value to compare against:
The child group under "Bergen" has one maximum value. The child group under Oslo has a separate maximum value. So the comparison is done within the separate child groups.

![image](https://user-images.githubusercontent.com/82056309/188615836-3c8ee722-3680-482d-8875-877a4a7073e1.png)



**RowLevel**: Each row in the circles compare against each other. The middle group has the highest value, of 2,17 million, and all other rows compare to that as their maximum value.

![image](https://user-images.githubusercontent.com/82056309/188615849-d1520264-59db-48b7-af0f-78fc23078876.png)




**Optional Condition:**

![image](https://user-images.githubusercontent.com/82056309/188615863-2c20f52e-5c4c-44dd-a09f-9615db78975e.png)


You can use that field to specify where you want the data bar to appear.

For instance, you can write "RowLevel()>0" to exclude data bars on the top level (top level is defined as 0):


![image](https://user-images.githubusercontent.com/82056309/188615884-f12cb7af-5b32-4918-b459-cbbf05e95ae1.png)



Or you could add it only to the parent rows by using "RowLevel()==0":

![image](https://user-images.githubusercontent.com/82056309/188615904-e4469e3f-016c-4410-a295-e50a5be97bb7.png)


