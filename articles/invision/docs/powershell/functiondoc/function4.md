---
title: "Profitbase.Data.SqlScript functions"
metaKeys: "[Profitbase.Data.SqlScript]::ExecuteReader, $result = [Profitbase.Data.SqlScript]::ExecuteNonQueryByName($scriptName [, $sqlParameters]), $result = [Profitbase.Data.SqlScript]::ExecuteNonQueryById($scriptId [, $sqlParameters]), $objectResult = [Profitbase.Data.SqlScript]::ExecuteScalarByName($scriptName [, $sqlParameters]), $objectResult = [Profitbase.Data.SqlScript]::ExecuteScalarById($scriptId [, $sqlParameters]), $dataTable = [Profitbase.Data.SqlScript]::LoadTableByName($scriptName [, $sqlParameters]), $dataTable = [Profitbase.Data.SqlScript]::LoadTableById($scriptId [, $sqlParameters]), $sqlDataReader = [Profitbase.Data.SqlScript]::ExecuteReaderByName($scriptName [, $sqlParameters]), $sqlDataReader = [Profitbase.Data.SqlScript]::ExecuteReaderById($scriptId [, $sqlParameters]), Executes the defined SQL Script, [Profitbase.Data.SqlScript]::ExecuteNonQuery, [Profitbase.Data.SqlScript]::ExecuteScalar, [Profitbase.Data.SqlScript]::LoadTable, [Profitbase.Data.SqlScript]::ExecuteReader "
pageIndex: 4
---

These functions use SQL Scripts stored in InVision. Scripts can be addressed by Name or Id.

`$result = [Profitbase.Data.SqlScript]::ExecuteNonQueryByName($scriptName [, $sqlParameters])`

`$result = [Profitbase.Data.SqlScript]::ExecuteNonQueryById($scriptId [, $sqlParameters])`

Executes the defined SQL Script against the solution database connection and returns the number of rows affected.

<br/>

`$objectResult = [Profitbase.Data.SqlScript]::ExecuteScalarByName($scriptName [, $sqlParameters])`

`$objectResult = [Profitbase.Data.SqlScript]::ExecuteScalarById($scriptId [, $sqlParameters])`

Executes the defined SQL Script, and returns a single value of first column of the first row in the result set returned by the query.

<br/>

`$dataTable = [Profitbase.Data.SqlScript]::LoadTableByName($scriptName [, $sqlParameters])`

`$dataTable = [Profitbase.Data.SqlScript]::LoadTableById($scriptId [, $sqlParameters])`

Executes the defined SQL Script against the solution database connection and returns a DataTable object that contain the resulting columns and rows.
<br/>

`$sqlDataReader = [Profitbase.Data.SqlScript]::ExecuteReaderByName($scriptName [, $sqlParameters])`

`$sqlDataReader = [Profitbase.Data.SqlScript]::ExecuteReaderById($scriptId [, $sqlParameters])`

Executes the defined SQL Script against the solution database connection and returns a SqlDataReader object that can be used to read field and row data.
<br/>

<br/>

**Example: ExecuteNonQueryByName**

```powershell
$param1 = New-Object System.Data.SqlClient.SqlParameter('@logEntryType',
[System.Data.SqlDbType]::NVarChar)
$param1.Value = 'Warning'
[Profitbase.Data.SqlScript]::ExecuteNonQueryByName('NonQuerySql', $param1)
```

<br/>

**Example: ExecuteScalarByName**

```powershell
$param1 = New-Object Microsoft.Data.SqlClient.SqlParameter('@logEntryType',
[System.Data.SqlDbType]::int)
$param1.Value = 3
Write-Output([Profitbase.Data.SqlScript]::ExecuteScalarByName('ScalarScript', $param1))
```

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/ExSc1.png)

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/ExSc2.png)

<br/>

**Example: LoadTableByName**

```powershell
$param1 = New-Object System.Data.SqlClient.SqlParameter('@logEntryType',
[System.Data.SqlDbType]::NVarChar);
$param1.Value = 'Error'
[Profitbase.Data.SqlScript]::LoadTableByName( 'LoadTableSql', $param1)
```

<br/>

**Example: ExecuteReaderByName**

```powershell
$param1 = New-Object System.Data.SqlClient.SqlParameter('@logEntryType', [System.Data.SqlDbType]::NVarChar);
$param1.Value = 'Error'
[Profitbase.Data.SqlScript]::ExecuteReaderByName( 'ReaderSql', $param1)
$readerHadRows = $reader.HasRows
$reader.Close() # Closes reader and connection
```

### Videos

- [PowerShell](../../../videos/powershell.md)
- [ExecuteScalarByName](https://profitbasedocs.blob.core.windows.net/videos/PS%20-%20execute%20scalar%20SQL.mp4)

<!--
```


    public class SqlCommand   
       
        #region Public Functions 
               
// This function is part of the public API and cannot be removed or renamed    
   
    public static int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)       
    {           
    return ExecuteNonQueryAsync(commandText, parameters).GetAwaiter().GetResult();       
    }        

// This function is part of the public API and cannot be removed or renamed       
    public static object ExecuteScalar(string commandText, params SqlParameter[] parameters)       
    {           
        return ExecuteScalarAsync(commandText, parameters).GetAwaiter().GetResult();       
        }        

// This function is part of the public API and cannot be removed or renamed       

public static DataTable LoadTable(string commandText, params SqlParameter[] parameters)       
{           
    return LoadTableAsync(commandText, parameters).GetAwaiter().GetResult();       
    }        

// This function is part of the public API and cannot be removed or renamed       

public static SqlDataReader ExecuteReader(string commandText, params SqlParameter[] parameters)       
{           
    return ExecuteReaderAsync(commandText, parameters).GetAwaiter().GetResult();       
}        

public static int ExecuteNonQuery(string commandText, IDictionary<string, object> parameters)       
{           
    return ExecuteNonQueryAsync(commandText, ToSqlParameters(parameters)).GetAwaiter().GetResult();       
    }        

// This function is part of the public API and cannot be removed or renamed       
public static object ExecuteScalar(string commandText, IDictionary<string, object> parameters)       
{           
    return ExecuteScalarAsync(commandText, ToSqlParameters(parameters)).GetAwaiter().GetResult();       
     }        

// This function is part of the public API and cannot be removed or renamed       

public static DataTable LoadTable(string commandText, IDictionary<string, object> parameters)  
     
{           
    return LoadTableAsync(commandText, ToSqlParameters(parameters)).GetAwaiter().GetResult();       
    }        

// This function is part of the public API and cannot be removed or renamed       

public static SqlDataReader ExecuteReader(string commandText, IDictionary<string, object> parameters)       
{           
    return ExecuteReaderAsync(commandText, ToSqlParameters(parameters)).GetAwaiter().GetResult();       
    }        

    #endregion
``` -->
