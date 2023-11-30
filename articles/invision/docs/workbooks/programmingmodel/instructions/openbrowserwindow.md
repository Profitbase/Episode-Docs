# OpenBrowserWindow(...)

<br/>


```
OpenBrowserWindow(url : string | Eaze expression [,name : string | Eaze expression, 
windowFeatures : string | Eaze expression])
```
Opens a new browser window with the specified URL and optionally a window name. The URL and name can be constructed dynamically using Eaze expressions.
<br/>

**Example**

The example below how to construct a url by combining a url and the value of the OrderId property read from a variable using the CONCAT function.

```
OpenBrowserWindow(CONCAT("http://mysite/api/invoices?id=", SelectedOrder.OrderId));
```
<br/>

The example below shows how to open a new browser window by providing a static url.

```
OpenBrowserWindow("http://www.profitbase.com");
```

