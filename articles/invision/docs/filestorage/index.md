<br/>

![File Storage](https://profitbasedocs.blob.core.windows.net/images/FileStorage_Panel.PNG)

<br/>

#### File Storage

File Storage enables users to upload download and manage files. 


<br/>



#### Configuration

<br/>

**Context**

By setting the [Context](context.md), you associate the File Storage to the [Filter](../filters/index.md).

•	Key ``<Context item>``

•	Type

![fs](https://profitbasedocs.blob.core.windows.net/images/filestorage1.png)

<br/>
 

**Options**

•	Allowed File Extensions

![fs](https://profitbasedocs.blob.core.windows.net/images/filestorage2.png)
 
•	Max File Size (MB)

<br/>

#### Data
Here you will find saved files with default File Storage references, more filters you use, more columns with references([context keys](./context.md)) will appear.
<br/>

![fs](https://profitbasedocs.blob.core.windows.net/images/filestorageData.png)

<br/>

**Default File Storage references**

•	FileName

•	CreatedDate

•	CreatedBy

<br/>

**Filtering the column**

![fs](https://profitbasedocs.blob.core.windows.net/images/filestorage3.png)

<br/>

<br/>

#### How to get all file names from a File Storage

The example below shows how to get all file names from a File Storage and insert the file names to "MY TABLE" in the InVision database.

<br/>


```powershell
param (
 [Parameter (MANDATORY = $TRUE)][string] $sessionId   
)

$storageName = "My Files"
$fileInfos = [Profitbase.IO.FileStorage]::GetFileInfos($storageName)

$sessionIdSqlParam = New-Object 'Microsoft.Data.SqlClient.SqlParameter'
$sessionIdSqlParam.ParameterName = "@sessionId"
$sessionIdSqlParam.Value = $sessionId

[Profitbase.Data.SqlCommand]::ExecuteNonQuery("DELETE FROM [MY_TABLE] WHERE SessionID = @sessionId", $sessionIdSqlParam)

foreach($fileInfo in $fileInfos)
{  
    $sessionIdSqlParam = New-Object 'Microsoft.Data.SqlClient.SqlParameter'
    $sessionIdSqlParam.ParameterName = "@sessionId"
    $sessionIdSqlParam.Value = $sessionId

    $fileNameSqlParam = New-Object 'Microsoft.Data.SqlClient.SqlParameter'
    $fileNameSqlParam.ParameterName = "@fileName"   
    $fileNameSqlParam.Value = $fileInfo.FileName
   [Profitbase.Data.SqlCommand]::ExecuteNonQuery("INSERT INTO [MY_TABLE] (SessionID, FileName) VALUES(@sessionId, @fileName)", $sessionIdSqlParam, $fileNameSqlParam)
}
```




#### See Also

- [How to's](howto/index.md)
- [File Storage Setup](setup.md)
- [Context](context.md)
- [Display Modes](display-modes.md)
- [File Storage - Component](../workbooks/components/filestorage.md)

<br/>

#### Videos

- [File Storage](../../videos/filestorage.md)
- [File Storage - Basics](https://profitbasedocs.blob.core.windows.net/videos/File%20Storage%20-%20Basics.mp4)