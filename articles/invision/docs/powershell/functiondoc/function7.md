---
title: "Profitbase.IO.FileStorage"
metaKeys: "Profitbase.IO.FileStorage, [byte[]] $fileContent = [Profitbase.IO.FileStorage]::ReadAllBytes($storageName, $fileName), [byte[]] $fileContent = [Profitbase.IO.FileStorage]::ReadAllBytesByReferenceId($fileReferenceId), [Profitbase.IO.FileStorage]::DeleteFile($storageName, $fileName), [Profitbase.IO.FileStorage]:: DeleteFileByReferenceId ($fileReferenceId), [string[]] $fileNames = [Profitbase.IO.FileStorage]::GetFileNames($storageName [,$contextQuery [,$mimeTye]] ), [Profitbase.IO.FSFileInfo[]] $fileInfos = [Profitbase.IO.FileStorage]::GetFileInfos($storageName [,$contextQuery [,$mimeTye]] ), Read a Powershell script, "
pageIndex: 7
---

Use the Profitbase.IO.FileStorage API for querying, reading and writing to File Storage objects.
<br/>

`[Profitbase.IO.FileStorage]::AddFile($storageName, $fileName, $fileBytes, $context)`  
Adds a file to the specified file storage.

**Example**

```powershell
param (
	[Parameter (MANDATORY = $TRUE)][string] $fileName,
	[Parameter(MANDATORY = $TRUE)][byte[]] $fileBytes,
	[Parameter(MANDATORY = $TRUE)][string] $productId
)

$context = New-Object System.Collections.Generic.Dictionary"[String, Object]"
$context.Add("ProductId", $productId)

[Profitbase.IO.FileStorage]::AddFile("Products", $fileName, $fileBytes, $context)
```

`[byte[]] $fileContent = [Profitbase.IO.FileStorage]::ReadAllBytes($storageName, $fileName)`

Returns a file (as byte array) given by name of an Invision File Storage and a file name.

<br/>

`[byte[]] $fileContent = [Profitbase.IO.FileStorage]::ReadAllBytesByReferenceId($fileReferenceId)`

Returns a file (as byte array) given by file reference.

<br/>

`[Profitbase.IO.FileStorage]::UpdateContext($storageName, $fileName, $newContext)`  
`[Profitbase.IO.FileStorage]::UpdateContextByReferenceId($fileReferenceId, $newContext)`  
Updates the context of a file.

**Example**

```powershell
param (
	[Parameter (MANDATORY = $TRUE)][string] $oldClaimId,
	[Parameter(MANDATORY = $TRUE)][string] $newClaimId
)

$newContext = New-Object System.Collections.Generic.Dictionary"[String, Object]"
$newContext.Add("ClaimID", $newClaimId)

$storageName = "Files"
$fileInfos = [Profitbase.IO.FileStorage]::GetFileInfos($storageName, "ClaimID == `"${oldClaimId}`"")
foreach($fileInfo in $fileInfos)
{
     [Profitbase.IO.FileStorage]::UpdateContextByReferenceId($fileInfo.FileReferenceId, $newContext)
}
```

`[Profitbase.IO.FileStorage]::DeleteFile($storageName, $fileName)`

Deletes the specified file from a File Storage.

<br/>

`[Profitbase.IO.FileStorage]:: DeleteFileByReferenceId ($fileReferenceId)`

Deletes the specified file using its reference id.

<br/>

`[string[]] $fileNames = [Profitbase.IO.FileStorage]::GetFileNames($storageName [,$contextQuery [,$mimeTye]] )`

Returns a list of files. This list can optionally be filtered by a Context Query and Mime Type.
The Context Query is based on Context keys defined in the File Storage and has a format like i.e.

```
DepartmentID=="Dep1" && EmployeeId==123 && DepartmentSize==200
```

<br/>

`[Profitbase.IO.FSFileInfo[]] $fileInfos = [Profitbase.IO.FileStorage]::GetFileInfos($storageName [,$contextQuery [,$mimeTye]] )`

Returns a list of file information. This list can optionally be filtered by a Context Query and Mime Type.
The records in the result contains fields for: FileName, ContextJson, MimeType, FileReferenceId, CreatedBy, Created, LastChangedBy and LastChanged.

<br/>

**Examples:**

Read a Powershell script from the given file in the storage, and execute it.

```powershell
param (
  [ Parameter ( Mandatory = $TRUE )][string] $storageName,
  [ Parameter ( Mandatory = $TRUE )][string] $fileName
)

[byte[]] $result = [Profitbase.IO.FileStorage]::ReadAllBytes($storageName, $fileName)

$enc=[System.Text.Encoding]::UTF8
$code=$enc.GetString($result)

Invoke-Expression $code
```

List file by a query.

```powershell
param (
  [ Parameter ( Mandatory = $TRUE )][string] $storageName,
  [ Parameter ( Mandatory = $FALSE )][string] $contextQuery,
  [ Parameter ( Mandatory = $FALSE )][string] $mimeType
)

[string[]] $result = [Profitbase.IO.FileStorage]::GetFileNames($storageName, $contextQuery, $mimeType)

Write-output $result
```

<br/>

**Example 1**  
This example shows how to move files from a File Storage to a table. The script does the following:

1. Reads all files from the File Storage named 'Job Files'.
2. Renames the files based on some business rules.
3. Copies the files to a SQL table (don't do this in production, folks).
4. Deletes the files from the File Storage

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

** Example 2**  
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
