
# Run SQL Commands from Web Functions

## SqlCommandService

To run SQL queries against the InVision database from Web Functions, use the SqlCommandService. If you need to run queries against external SQL databases, use the method overloads with connectionString parameters.

<br/>

**Example**
The example below shows how to use the SqlCommandService to query the Customers table for a customer name.

```csharp

    public async Task<IActionResult> Run(HttpRequest request)
    {
        var customerName = await this.SqlCommandService.ExecuteScalarAsync<string>(
        "SELECT Name FROM Customers WHERE CustomerID = @customerId"
        , new SqlParameter("@customerId", "theCustomerId"));
    }

```

More examples are available in the Samples window in the Invision Desktop Designer.

<br/>
<br/>

### Methods

`LoadDataTableAsync`

Asynchronusly executes a SQL query and returns the result as a .NET DataTable.

```csharp
Task<DataTable> LoadTableAsync(string query, params SqlParameter[] sqlParameters)
Task<DataTable> LoadTableAsync(string connectionString, string query, params SqlParameter[] sqlParameters)
```

`ExecuteNonQueryAsync`

Asynchronusly executes a SQL query and returns the number of rows affected by the query.

```csharp
Task<int> ExecuteNonQueryAsync(string query, params SqlParameter[] sqlParameters)
Task<int> ExecuteNonQueryAsync(string connectionString, string query, params SqlParameter[] sqlParameters)
```

`ExecuteScalarAsync`

Asynchronusly executes a SQL query and returns the value of the first column in the first row from the result.

```csharp
Task<T> ExecuteScalarAsync<T>(string query, params SqlParameter[] sqlParameters)
Task<T> ExecuteScalarAsync<T>(string connectionString, string query, params SqlParameter[] sqlParameters)
```
