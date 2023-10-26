
### You add data to the visual by dragging and dropping fields from the Power BI data model onto the different buckets. 


***

**Tasks and Hierarchy:**

Add task field to display in the first column of the data grid.
Adding multiple fields to this bucket will create a hierarchy of grouped tasks.


***

**Start Date:**

Field defining the start point of the bar showing in the chart. 
_This field needs to be a date._

**End Date:**

Field defining the end point of the bar showing in the chart. Without this field, all tasks will just be visualized with a dot on the start date.
_This field needs to be a date._

**Duration:**

Alternative to End date. If your task start at the Start Date, and lasts for 2 weeks, then add the Duration field here, and specify Duration Unit as Weeks". Unit choices range from seconds to years.

![image](https://user-images.githubusercontent.com/82056309/194148283-58e13a4b-c9f6-4fca-991f-3e4c678272e5.png)

***



**Progress:**

Add a field here to display progress as part of the bars in the Chart. _Field needs to be a value between 0 and 1 (0 and 100%)._
![image](https://user-images.githubusercontent.com/82056309/194149456-61f5dc94-a9b7-46bb-ace8-893f78dba861.png)

***


**Planned Start and End Date:**

Add fields to these buckets to show when a task was planned to start and end (red bar). _Fields needs to be dates_ 

![image](https://user-images.githubusercontent.com/82056309/194150785-f3068b9a-c679-4097-a08c-47ceb6762bd3.png)

***


**Milestones:**

Add fields to show milestones on tasks. Each task might have multiple milestone dates. If so, add multiple fields to this bucket.
Milestones will show as a shape on a specific date. Shape can be set in the formatting options.

![image](https://user-images.githubusercontent.com/82056309/194153335-ed9393e2-211f-4869-ba1d-840dc05c2f8b.png)

***

**Milestone details:**

Fields added here will be used as either Milestone Label or Milestone ToolTip.
Select how you want to display it in the format pane.

![image](https://github.com/Profitbase/PowerBI-visuals-Gantt/assets/82056309/018a3d0b-cbf2-4cdc-bdd5-bdf7335a97d7)



***

**Additional Columns:**

Fields added here will be shown in the Data Grid next to the column showing Tasks and Hierarchy.

***


**Primary Connect To:**

Add fields here to display connector lines. If one task is dependent on another, it will show a line from on task to another.
To set this up, the field used in Depend on needs to be a reference to the task it referees to. 

![image](https://user-images.githubusercontent.com/82056309/194154282-55f26f8c-312c-4dba-84b5-2c3e2939ab60.png)




**Primary Connect Type:**
Field will specify how the connector line is drawn. Field has to be text, and state one of these types:

_StartStart, StartFinish, FinishStart, FinishFinish_

***


**Tooltip Fields:**

Add the fields you want to display in the Tooltip when hovering over a task in the Chart.
If left empty, the default information will show in the Tooltip.

***


**Data Labels:**

Add a field to display next to the tasks shown in the Chart. Possible to add multiple fields, that will be separated by a comma in the label.

![image](https://user-images.githubusercontent.com/82056309/194156481-60e37a06-1bd1-4654-a722-3c16bfc69a9c.png)


***

**All buckets:**

![image](https://github.com/Profitbase/PowerBI-visuals-Gantt/assets/82056309/b629edea-04d8-467e-b24d-007c4b129ce1)


![image](https://github.com/Profitbase/PowerBI-visuals-Gantt/assets/82056309/1b63364b-e0a9-457e-987f-0851f57c1a5d)
