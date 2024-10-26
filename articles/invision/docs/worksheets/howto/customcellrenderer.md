
# How to Use Cell Renderers

## Link to the video

Under [this link](https://profitbasedocs.blob.core.windows.net/videos/Spreadsheet%20-%20Column%20Properties%20-%20Custom%20Cell%20Renderer.mp4) you will find a video that shows how to use Cell Renderers. [Here](../columnproperties/cellrenderer.md) you will find [Documentation](../columnproperties/cellrenderer.md).
<br/>

## Step by step


1. Go to the schema tab and choose a column that you want to enhance:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTccr%20(4).png)

2. Click three dots to open the renderer window: 

![pic](https://profitbasedocs.blob.core.windows.net/images/HTccr%20(2).png)

3. Create a javascript function:

```javascript
function(eventArgs, services){
    // eventArgs.value - The value of the cell    
    // eventArgs.rowData - The data row
    // eventArgs.prop - The name of the cell. Usually the column name
    // eventArgs.rowNum - The visual row index
    // eventArgs.element - them cell HTML element (div)
    // services.eventDispatcher.raiseCustomEvent({prop: value}) - raises the Custom event on the component        
    // services.lib.html.sanitizeHtml(eventArgs.value) - removes usafe HTML content from the input string to protect against XSS attacks.  

	const btn = document.createElement('button');
    btn.style.width = '100%';
    btn.style.height = '100%';
    btn.onclick = () => services.eventDispatcher.raiseCustomEvent({prop: eventArgs.prop, value: eventArgs.value});

    // Note! 
    // If rendering data directly to the DOM, for example setting element.innerText of element.innerHTML, 
    // always sanitize the input first using the services.lib.html.sanitizeHtml(...) function.
    // Also, prefer using element.innerText over element.innerHTML to minimize risks of XSS attacks.
    // Example:
    // element.innerText = services.lib.html.sanitizeHtml(eventArgs.value);
    btn.innerText = eventArgs.value;
    return btn;    
}
```