
# Examples


**Example 1**  
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

<br/>

**Example 2**  
This example shows how to move files from a File Storage to a table. The script does the following:  
1) Reads all files from the File Storage named 'Job Files'.  
2) Renames the files based on some business rules.  
3) Copies the files to a SQL table (don't do this in production, folks).  
4) Deletes the files from the File Storage  

```powershell
param (
 [Parameter (MANDATORY = $TRUE)][string] $jobId,
 [Parameter (MANDATORY = $TRUE)][string] $jobItemId 
)

function Remove-InvalidFileNameChars {
  param(
    [Parameter(Mandatory=$true,
      Position=0,
      ValueFromPipeline=$true,
      ValueFromPipelineByPropertyName=$true)]
    [String]$Name
  )

  $invalidChars = [IO.Path]::GetInvalidFileNameChars() -join ''
  $re = "[{0}]" -f [RegEx]::Escape($invalidChars)
  return ($Name -replace $re)
}

$targetTable = [Profitbase.Data.SqlCommand]::ExecuteScalar("SELECT [Value] FROM Setting_ApiSettings_04042017103212 WHERE [Key]='FilesArchive'")

$storageName = "Job Files"
$query = "JobItemId == `"${jobItemId}`""
$fileInfos = [Profitbase.IO.FileStorage]::GetFileInfos($storageName, $query)

foreach($fileInfo in $fileInfos)
{  

   $jobItemIdParam_1 = New-Object 'Microsoft.Data.SqlClient.SqlParameter'
   $jobItemIdParam_1.ParameterName = "@jobItemId"
   $jobItemIdParam_1.Value = $jobItemId	
	
   $fileName = $fileInfo.FileName   
   $sqlDataReader = [Profitbase.Data.SqlCommand]::ExecuteReader("SELECT TagID, BoxID FROM Store_JobItems_01242017125507 WHERE JobItemID = @jobItemId" , $jobItemIdParam_1)
   if ($sqlDataReader.Read()){
       $tagId = $sqlDataReader["TagID"]
       $boxId = $sqlDataReader["BoxID"] 
       
       $jobItemIdParam_2 = New-Object 'Microsoft.Data.SqlClient.SqlParameter'
       $jobItemIdParam_2.ParameterName = "@jobItemId"
       $jobItemIdParam_2.Value = $jobItemId	
        
       $count = [Profitbase.Data.SqlCommand]::ExecuteScalar("SELECT COUNT(ResourceID) FROM " + $targetTable + " WHERE JobItemID = @jobItemId AND ResourceName LIKE '%-P_-handdrawing%'", $jobItemIdParam_2) + 1
       
       $tagName = Remove-InvalidFileNameChars $tagId
       $fileName = $tagName + "-" + $boxId + "-P" + $count.ToString() + "-handdrawing" + [System.IO.Path]::GetExtension($fileName)       
   }
   $sqlDataReader.Dispose()

   $fileNameParam = New-Object 'Microsoft.Data.SqlClient.SqlParameter'
   $fileNameParam.ParameterName = "@fileName"
   $fileNameParam.Value = $fileName
   
   $mediaTypeParam = New-Object 'Microsoft.Data.SqlClient.SqlParameter'
   $mediaTypeParam.ParameterName = "@mediaType"
   $mediaTypeParam.Value = $fileInfo.MimeType   

   $dataParam = New-Object 'Microsoft.Data.SqlClient.SqlParameter'
   $dataParam.ParameterName = "@data"
   $dataParam.Value = [Profitbase.IO.FileStorage]::ReadAllBytes($storageName, $fileInfo.FileName)
	
   $sqlQuery = "INSERT INTO " + $targetTable + " (ResourceID, ResourceName, Data, MediaType) VALUES(NEWID(), @fileName, @data, @mediaType)"
   
   [Profitbase.Data.SqlCommand]::ExecuteNonQuery($sqlQuery, $fileNameParam, $mediaTypeParam, $dataParam)
   
   [Profitbase.IO.FileStorage]::DeleteFileByReferenceId($fileInfo.FileReferenceId)
}  
```

<br/>

** Example 3**  
This example show how to read a number of files from a File Storage and send them to a Web API in a single .zip file.
```powershell
param (
 [Parameter (MANDATORY = $TRUE)][string] $sessionId,
 [Parameter (MANDATORY = $TRUE)][string] $jobId
)

$storageName = "Job Files"

$folderName = "_" + [guid]::NewGuid()
$folder = [Profitbase.IO.Directory]::CreateTransientDirectory($folderName)
$query = "session == `"${sessionId}`""
$fileInfos = [Profitbase.IO.FileStorage]::GetFileInfos($storageName, $query)
foreach($fileInfo in $fileInfos)
{	
    $bytes = [Profitbase.IO.FileStorage]::ReadAllBytes($storageName, $fileInfo.FileName)    
	$fileStream = $folder.CreateFile($fileInfo.FileName)
   	$fileStream.Write($bytes, 0, $bytes.Length)
   	$fileStream.Flush()
   	$fileStream.Dispose()    
}

$tempFolderName = "_" + [guid]::NewGuid()
$tempFolder = [Profitbase.IO.Directory]::CreateTransientDirectory($tempFolderName)
[System.IO.Compression.ZipFile]::CreateFromDirectory($folder.FullName, $tempFolder.FullName + "\FileSpread.zip")

$zipFile = $folder.OpenFile($tempFolder.FullName + "\FileSpread.zip", [System.IO.FileMode]::Open)

$FileHeader = [System.Net.Http.Headers.ContentDispositionHeaderValue]::new('form-data')
$FileHeader.Name = "document"
$FileHeader.FileName = "FileSpread.zip"
$FileContent = [System.Net.Http.StreamContent]::new($zipFile)
$FileContent.Headers.ContentDisposition = $FileHeader
$FileContent.Headers.ContentType = [System.Net.Http.Headers.MediaTypeHeaderValue]::Parse('application/zip')

$MultipartContent = [System.Net.Http.MultipartFormDataContent]::new()
$MultipartContent.Add($FileContent)

$apiBaseUrl = [Profitbase.Data.SqlCommand]::ExecuteScalar("SELECT [Value] FROM ApiSettings WHERE [Key] = 'WebApiBaseUrl'")

Invoke-WebRequest -Body $MultipartContent -Method 'POST' -Uri "${apiBaseUrl}/api/filespread/${sessionId}?jobId=${jobId}"

$zipFile.Dispose()
$folder.DeleteFile("FileSpread.zip")

foreach($fileInfo in $fileInfos)
{	
    [Profitbase.IO.FileStorage]::DeleteFileByReferenceId($fileInfo.FileReferenceId)	
}

[Profitbase.Data.SqlCommand]::ExecuteNonQuery("DELETE FROM Files WHERE [FileSpreadSessionID] = '" + $sessionId + "'")
```

### See Also

* [File Storage](../filestorage.md)



#### Videos

* [PowerShell - How To get All File Names From a File Storage](https://profitbasedocs.blob.core.windows.net/videos/PowerShell%20-%20file%20name%20export.mp4)

<br/>