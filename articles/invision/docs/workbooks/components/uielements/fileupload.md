
# File Upload

![upploadUI](https://profitbasedocs.blob.core.windows.net/images/upploadUI.png)
<br/>



Provides file upload support from Workbooks. The user can upload one or many files in the same batch.

## Events


*	**CompletedEvent**  
This event is raised when the file upload has completed. The event payload contains an object with the ResourceID assigned by the server, the FileName, and any arguments you specified in the Upload Arguments Expression. 


**Example**
>
>If you uploaded an image file, myimage.png, and specified a custom ContextID = "Test" argument in Upload Arguments Expression, the event data object (@Event.Data) will have the following properties (obviously, the ResourceID will have a different value):
>
    {
        ResourceID: "aa69a209-2828-4ca4-9a89-8ed061620aeb", 
        FileName: "myImage.png", 
        params: {
            ContextID: "Test"
        }
    }

## Properties


*	**Accept Media Type**  
Specifies the types of files that the server accepts.  [Accept Attribute](https://www.w3schools.com/tags/att_input_accept.asp)


*	**Upload Target Solution Object Name**  
Specifies the name of the File Storage table that the file(s) should be uploaded to. You can either use this property or specify the Upload Target Url. If you want to upload the file(s) to the InVision backend and you do not need the upload target to be dynamically resolved, you should use this option instead of Upload Target Url.


*	**Upload Target Url**  
Specifies the url that the file(s) should be uploaded to. You should use this option instead of Upload Target Solution Object Name if you want to upload the file(s) to the InVision backend, and you need the url do be dynamically resolved. The easiest way to upload files to the InVision backend using this option is to use a valid Db Web Api url.


*	**Upload Arguments Expression**  
Specifies a range of SetParamValue(…) statements that can be used to add additional metadata to the file upload message sent from the browser to the server.  
InVision uses FormData to upload files to the server. Each SetParamValue(…) appends a new value onto an existing key inside the FormData object.
When uploading to an InVision File Storage table, the paramName should be the name of the column that you want to store the metadata in, and the param value should be the metadata that you want to store.

**Example**
>
>Suppose you have a File Storage table with a CustomerID column (in addition to the standard File Storage columns), and you want the files you upload to be tagged with the customer id, you should call SetParamValue(…) similar to this;
>
```
SetParamValue("CustomerID", _customer.CustomerID);
```

<br/>

## Videos

* [Workbooks](../../../../videos/workbooks.md)
* [Components - File Upload](https://profitbasedocs.blob.core.windows.net/videos/Workbooks%20-%20File%20Upload.mp4)
* [Components - File Upload and Download](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20-%20File%20Upload%20and%20Download.mp4)