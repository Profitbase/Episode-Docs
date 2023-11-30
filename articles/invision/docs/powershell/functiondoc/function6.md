
# Profitbase.IO

Profitbase.IO allows for using a transient folder to process files. In SaaS solutions, the Solution Devs will not be able to put a file on any disk, so the scripts should use transient folders for file handling.  
Transient folders and their contents are deleted once the script execution finishes (if there are no file locks).

<br/>

`$folder = [Profitbase.IO.Directory]::CreateTransientDirectory`  
Creates all the transient directories in a specified path.

`$folder.FullName`  
Returns the path of the Profitbase.IO.TransientDirectory object.

`$folder.ToString()`  
Returns the path of the Profitbase.IO.TransientDirectory object.

`$folder.CreateFile`  
Creates or overwrites a file in the specified path.

`$folder.OpenFile`  
Opens a FileStream on the specified path with read/write access with no sharing.

`$folder.DeleteFile`  
Deletes the specified file.

`$folder.Delete`  
Deletes the directory.

`[Profitbase.IO.Directory]::Delete`  
Deletes the specified directory.

**Example**

```powershell
$folder = [Profitbase.IO.Directory]::CreateTransientDirectory('MyFolder')
$fileStream  = $folder.CreateFile("MyFile.txt")
$sw = New-Object IO.StreamWriter $fileStream
$sw.WriteLine("Add a line of text.")
$sw.Close()
$fileStream.Close()
```
