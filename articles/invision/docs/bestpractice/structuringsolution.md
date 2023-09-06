---
title: "Structuring a Solution"
metaKeys: "Structuring a Solution, Namespace, Basic guidelines,  "
pageIndex: 1
---



### Basic guidelines for structuring solutions

When building an InVision Solution, you are free to structure your Solution as you see fit. InVision does not require you to follow any patterns or rules as to how you organize the components of the Solution. However, the recommended approach is to structure your solution components by feature/business area, not type. As an example, the structure of «MySolution», containing Budget, Forecast, and Booking, may look like this:
<br/>
My Solution

>Shared Resources  
>Content
>
>>Budget  
>>….  
>>Forecast  
>>….  
>>Booking  
>>…
>
>System

<br/>

### Namespace - Logical structuring

Namespaces in InVision are used for defining the logical structure of the Solution. The contents of the toolboxes are organized based on the namespacing information specified for each Solution Explorer Object, so that it's easier to navigate and find what you're looking for.

Namespaces are inherited based on the physical structure of the Solution, meaning a descendant node will belong to the same namespace as its ancestor having a namespace specified. If an unrooted namespace is assigned to a node, the namespace will become a sub-namespace of the ancestor namespace, and the node and its descenants will belong to the new (sub) namepace.

Namespaces can be rooted at any level, meaning that a new top-level namespace can be created for any node if you don't want a node (and its descendants) to inherit the namespace from one of its ancestors. To create a new root namespace, the namespace name must start with two colons ("::"), for example **::My New Namespace**.
<br/>

**Example**

Given the following physical Solution structure with namespace definitions highlighted in bold

My Solution (**Solution**)
>Budget (**Budget**)  
>>Data Flows  
>>>Budget Flow 1  
>>>Budget Flow 2  
>>>Budget Full Processing (**::Global/Data Flows**) 
>>
>>Data Stores  
>>>Salary  
>>>Assets  
>
>Booking (**Booking**)  
>>Data Stores  
>>>Courses  
>>
>>Data Flows  
>>>Booking Flow 1  
>>>Booking Full Processing (**::Global/Data Flows**)
<br/>

A toolbox displaying the Data Stores in the Solution will have the following structure

>**Solution**
>>**Budget**
>>>Salary
>>>Assets
>>
>>**Booking**
>>>Courses

<br/>

A toolbox displaying the Data Flows in the Solution will have the following structure
>**Solution**
>>**Budget**
>>>Budget Flow 1
>>>Budget Flow 2
>>**Booking**
>>>Booking Flow 1
>
>**Global**
>>**Data Flows**
>>>Budget Full Processing
>>>Booking Full Processing
		
