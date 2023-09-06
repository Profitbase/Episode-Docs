---
title: "Form Runtime"
metaKeys: "Form Runtime, context, Event Handlers, Control APIs"
folderOnly: "false"
pageIndex: 1
---

The Form Runtime is the context in which all Functions and Event Handles execute. All valid Functions and Event Handlers declared in a Form Schema are added as instance functions to the Form Runtime, and can be called by eachother through the **this** or **functions** keyword.

**Example**

```xml
    <Functions>
        <Function Name="log" Parameters="model, modelName, propertyName, newValue, oldValue">
            console.log('Model ' + modelName + ' changed (property: ' + propertyName + ')');
            console.log(model);
            console.log(modelName);
            console.log(propertyName);
            console.log(newValue);
            console.log(oldValue);
        </Function>
        <Function Name="doStuff" Parameters="newValue">
            controls.Label1.setIsVisible(models.FormData.Bit);
            controls.Input2.setIsEnabled(Models.FormData.Bit);
            console.log(newValue);
        </Function>
    </Functions>
```

You can call a shared function from Event Handlers or other shared functions through the **this** or **functions** keyword:

```xml
    <DataChangedEventHandler Value="{Binding Path:FormData.Bit}">
        this.log($model, $modelName, $propertyName, $newValue, $oldValue);
        // call shared function
        functions.doStuff($newValue);
        // or inline
        controls.Label1.setIsVisible(models.FormData.Bit);
        controls.Input2.setIsEnabled(Models.FormData.Bit);
    </DataChangedEventHandler>
```

In addition to the custom functions and event handlers, the Form Runtime has the following API:

- [Form Runtime API](formrunAPI.md)
- [Control APIs](controlproxyAPI.md)
- [Data Service API](dataserviceapi.md)
