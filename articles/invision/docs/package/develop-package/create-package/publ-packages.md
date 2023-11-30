# Publish packages (Azure blobstorage)


<br/>

1. In appsettings.json, specify a user name and password.


2. Publish the package file.

**Parameters:**

**-u /file path to your file or directory/** -upload the following file/files in  the directory

**-v** -verbose: Print log lines in the command prompt (default is silent, no logs)

**-o** -overwrite the file if it already exists in Profitbase.Store

<br/>

Parameters **-v** and **-o** are optional.

<br/>

```
pbstore -u "mypackage.pbpck"
```

<br/>

> [!NOTE]
> If your package has dependencies, you must upload the dependencies first.
<br/>

