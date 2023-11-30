# Context Directives


Arguments can be passed to Data Flow Items using directives. Directives enables arguments to be resolved based on the execution context of the Data Flow, and by addressing Solution resources without using hard to read and maintain metadata ids.

**@Object[name[,object type]].property-directive**

<br/>

**@Context.StoreDBConnectionString**

Gets the connection string to the first ancestor Data Store relative to the execution context of the Data Flow or Data Flow Item. If no ancestor Data Store can be found, the connection string to the Solution database is returned. 

<br/>

**@Context.SolutionDBConnectionString**

Gets the connection string to the Solution database that the Data Flow belongs to.
<br/>

**@Context.ObjectConnectionString**
<br/>

**@Context.ConnectionString**

Gets the connection string having the specified name.
<br/>

**@Context.DataFlowId**
<br/>

**@Context.DataFlowItemId**
<br/>

**@Context.TaskId**       
<br/>

**@Context.StoreTable**

Gets the database table name of the first ancestor Data Store relative to the execution context of the Data Flow or Data Flow Item. If the value cannot be resolved, the execution will fail. 
<br/>


**@Context.StoreId**

Gets the metadata id of the first ancestor Data Store relative to the execution context of the Data Flow or Data Flow Item. If the value cannot be resolved, the execution will fail.
<br/>

**@Context.SolutionId**

Gets the solution id of the solution that the Data Flow belongs to.
<br/>

**@Context.StoreGroupId**

Gets the metadata id of the first ancestor Data Store Group relative to the execution context of the Data Flow or Data Flow Item. If the value cannot be resolved, the execution will fail.
<br/>

**@Context.Step[name].Results[«Repository»]< expression >** and **@[StepName].Results[«Repository»]< expression >**  
Gets a value from a completed Data Flow Step (Item instance) within a Data Flow execution context.  

When a Data Flow is executed, an isolated execution context is created which lasts for the lifetime of the execution process. When a Data Flow Step has finished executing, it returns a collection of keys and values (Dictionary< string,dynamic >) which is added to the execution context of the Data Flow. The collection contains a result code and the number of rows processed and generated. If addition to the standard values, the you can add your own items to the collection, which enables passing data from one Data Flow Step to another at runtime.

*	To read the result of a Data Flow Step and use it for passing arguments to other steps in a Data Flow, you use the @Context.Step[name].Results[«Repository»][«Key»] syntax.
 

*	To read the result of a Data Flow Step and use it for determining the path in a Condition, you use the @[StepName].Results[«Repository»]< expression > syntax.
This is the most common usage of the Data Flow Step return value.

>**Example**
>
>Use the expression @[Step1].Results["ResultCode"] == 100 to test wether a step completed successfully.
>
>Result codes  
>Not  Started = 0,  
>Started = 10,  
>Succeeded = 100,  
>Failed = 200,  
>Aborted = 300,  
>Runtime error = 400

<br/>

**@Context.DbObjectName**
<br/>

**@Context.ObjectId**
<br/>

**@Context.Environment.AvailableProcessorCount**

Gets the number of available logical CPU’s.  



