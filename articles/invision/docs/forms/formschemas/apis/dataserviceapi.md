---
title: "Data Service API"
metaKeys: "Form Runtime API, Data Service API, Event Handlers, Functions, raiseWorkbookComponentEvent, AddViewStateModel, isNumber, isDate, startsWith, endsWith, convertTo, rounds, controls, models, setModels, texts, lists, AppVariables, disables "
pageIndex: 4
---

#### Data Service

<br/>

The Data Service enables developers to save and reload specific data models in a [Form Schema](../../formschemas.md). This feature adds extra flexibility and more fine-grained control for loading and saving data because models can be saved and loaded individually and not just with the Load and Save Data actions of the [Workbook component](../../../workbooks/components.md).

The Data Service can be accessed from the Form Runtime (link to) and has the following methods:

<br/>

`save(model, params?: object) : Promise<void>`

Saves / updates a specific model. You can optionally pass in arguments if the model does not contain sufficient data to perform the update.

**Example 1**

```xml
<Function Name="saveData" Async="true">
          await this.dataService.save(this.models.CustomerInfo);
</Function>
```

**Example 2**

```xml
<Function Name="saveData" Async="true">
          await this.dataService.save(this.models.CustomerInfo, {CustomerID: "foo"});
</Function>
```

<br/>

`reload(model: model | string, params?: object): Promise<Model>`

Reloads a specific model by returning a new model. 

> [!NOTE]
> The model passed in is not mutated. You can pass in either the model to reload, or the name of the model. If your data model has a filter or a parameterized Load Data query, you need to provide the required parameters.

**Example**

```xml
<Data>
    <Models>
        <Model Name="CustomerInfo" Source="@Object[FormUsingDataService_Table].DbObjectName" Fields="CustomerID,CustomerName,ProductID" Filter="CustomerID = @CustomerID" />
    </Models>
</Data>
<Functions>
   <Function Name="refreshData" Async="true">
          this.models.CustomerInfo = await this.dataService.reload(this.models.CustomerInfo, {CustomerID : this.models.CustomerInfo.CustomerID});
          // The CustomerID parameter can also be passed as a string
          // this.models.CustomerInfo = await this.dataService.reload(this.models.CustomerInfo, {"@CustomerID" : this.models.CustomerInfo.CustomerID});
   </Function>
</Functions>
```
