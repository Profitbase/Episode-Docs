---
title: "Functions"
metaKeys: " Functions, business logic, javascript, form runtime, name parameters, function body"
folderOnly: "false"
pageIndex: 6
---

                                                                 

Using Functions, you can define your own, reusable functions (business logic) that you can call from within Event Handlers or other Functions. This enables you to reuse code and reduce code duplication for business logic within Form Schemas.

A function configuration is directly converted into a **JavaScript** function, and is added as an instance function (method) to the **Form Runtime** of the schema. A function can be called from Event Handlers or other functions through the **functions** or **this** keyword.
___

**Function Properties**

*	**Name** must be a valid JavaScript function name. Use it to call the function from Event Handlers or other Functions through the **this** or **functions** keyword.

*	**Parameters** property is optional, but must be a comma separated list of valid parameter names if it is specified. Use it to pass arguments to a function.

*   **Async** By applying the Async attribute, you can specify that the function runs asynchronously which allows you to use the await keyword instead of callbacks.

*	The **function body** must be plain JavaScript since it is not transpiled (TypeScript, Babel), so you need to stick to whatever the browser supports out of the box.

>**Async Example**
>
        <Function Name="Foo" Async="true" Parameters="args">
            const delay = ms => new Promise(res => setTimeout(res, ms));
            await delay(3000);
        </Function>






>**Example**
>
    <Functions>
        <Function Name="log" Parameters="model, modelName, propertyName, newValue, oldValue">
            <![CDATA[
            console.log('Model ' + modelName + ' changed (property: ' + propertyName + ')');
            console.log(model);
            console.log(modelName);
            console.log(propertyName);
            console.log(newValue);
            console.log(oldValue);
            ]]>
        </Function>
        <Function Name="doStuff" Parameters="newValue">
            <![CDATA[
            controls.Label1.setIsVisible(models.FormData.Bit);
            controls.Input2.setIsEnabled(Models.FormData.Bit);
            console.log(newValue);
            ]]> 
        </Function>
    </Functions>
>
>You can call a shared function from Event Handlers or other shared functions through the `this` or functions keyword:
>
    <DataChangedEventHandler Value="{Binding Path:FormData.Bit}">            
        <![CDATA[
        this.log($model, $modelName, $propertyName, $newValue, $oldValue);        
        // call shared function
        functions.doStuff($newValue);
        // or inline
        controls.Label1.setIsVisible(models.FormData.Bit);
        controls.Input2.setIsEnabled(Models.FormData.Bit);                            
        ]]>
    </DataChangedEventHandler>


<br/>

### Videos 

* [Form Schemas](../../../videos/formschemas.md)
* [Functions](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Function.mp4)
* [Calling Functions from External Events](https://profitbasedocs.blob.core.windows.net/videos/Form%20schema%20-%20Calling%20Functions.mp4)