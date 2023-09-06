---
title: "Change Log 2023.4"
metaKeys: "2023.4 change log"
pageIndex: 1
---

2023.4 adds numerous new features for developers and end users. Continue reading to get the highlights.

<br/>

### Package deployment and upgrade logging

We’ve made improvements to logging during Package deployments and upgrades:

- We show the Work Process Versions, Solutions, and package versions that are upgraded. If you do a multi-version package upgrade, each Package version upgrade is listed.
- Non-essential log messages are no longer displayed in the compact log. This makes the log very easy to read.
- If an error occurs, you can switch to a detailed log view to do an investigation.
- You can view detailed logs about previously run Package deployments and upgrades. This is useful if some error has occurred, and you need to investigate what went wrong.

![Diff tool](https://profitbasedocs.blob.core.windows.net/images/pacdepl.png)

<br/>

### Data Pool

We now enforce the correct data types for columns in Data Pool Compound Views, so the default SQL Server data types are not applied when view source columns contain NULL values.

<br/>

### Dimensions and Access Control

- Fixed an issue where access permissions on dimension members were not deleted if the dimension member was deleted.
- Fixed an issue where access permissions on non-leaf dimension members were not correctly updated if the dimension was restructured.
- When publishing a dimension from the Dimension Editor, you will get warnings in the log if any Ranked Input tables have references to dimension members that no longer exist.
- The “Publish Dimension” dialog now displays a warning when you choose to overwrite the permissions at the target dimension(s) if the source dimension has no permissions defined. This prevents users from inadvertently deleting all permissions in a Work Process Version if they publish a primary dimension and tick the “Overwrite permissions” checkbox.

![Diff tool](https://profitbasedocs.blob.core.windows.net/images/diacctrl.png)

<br/>

### Work Process

- Auto selection of Work Process Version when the user switches Work Process source version in the Create Version dialog. This change prevents the user from inadvertently creating a version from the blueprint resulting in a version with no data.
- When publishing a dimension from the Dimension Editor, you will get warnings in the log if any tables have references to dimension members that no longer exist.

![Diff tool](https://profitbasedocs.blob.core.windows.net/images/wpch.png)

<br/>

### Ranked input tables

- Cells containing invalid references to dimension members are now displayed as #REF! instead of the row being removed.
- Clearing the source version dropdown in the Create Version dialog now displays a “Blueprint” watermark, making it obvious to the user that the new version will be created using the Blueprint as the data source.

![Diff tool](https://profitbasedocs.blob.core.windows.net/images/rainp.png)

<br/>

### Form Schema

- Added the **Readonly** property to all input controls.
- Links in the RichTextEditor will now always open in separate windows or browser tabs, regardless of whether a Workbook is running in an iframe or not.

<br/>

### Filter

- Fixed an issue with using search in hierarchical filters (for example TreeView) returned incorrect dimension member metadata for non-leaf members, causing incorrect data in reports when the filter was applied.

<br/>

### PowerShell FileStorage API

- Added an API to programmatically add files to a File Storage. [Read more](../docs/powershell/functiondoc/function7.md)
- Added APIs to programmatically update the context for files in a File Storage. [Read more](../docs/powershell/functiondoc/function7.md)

**Change the context of a file using the UpdateContextByReferenceId API**

```
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

<br/>

### TableView

- Fixed an issue where string filters did not have a border.
- Fixed an issue where custom context menu actions did not work when the table was filtered.

<br/>

### Workbook

You can now use JavaScript instead of Eaze when defining business logic for component actions.

![Diff tool](https://profitbasedocs.blob.core.windows.net/images/wbjs.png)

<br/>

By supporting JavaScript, we make it easier for new developers familiar with JavaScript to start using InVision. It also adds more flexibility, but at the same time adds a bit more complexity when working with global variables. With Eaze, any variable declared in an action handler was automatically globally available to other Workbook components as well. When using JavaScript, you need to declare global variables explicitly before they can be used.

If you want to migrate from Eaze to JavaScript, you can do it gradually by changing the Script language (as shown in the screenshot below) one action handler at a time from Eaze to JavaScript. You also need to make the following changes to the existing Eaze code to make it valid JavaScript code:

- Global variables are not created on the fly. Instead, you need to declare them in the Variables dialog in the Workbook toolbar.
- @Var[…] is not supported. “@Var[…]” is not a valid JavaScript variable name. If you need to keep using @Var while migrating, you can use the appVariables object to read and write to @Var variables. (see the example below).
- You must use the await keyword if you run the Web Api, Execute Web Function and Execute SQL Script workbook actions.
- Use Event instead of @Event in action instructions.

<br/>

**Differences between Eaze and JavaScript**

```
// Eaze: Execute SQL script using Eaze:
	SetParamValue("@param1", @Event.Data.customerId);
	_sqlScriptResponse = Execute("ExecSqlScriptFromWorkbook");

// JavaScript: Execute SQL Script using JavaScript. Note the use of the await keyword and Event instead of @Event	
	SetParamValue("@param1", Event.Data.customerId);
	_sqlScriptResponse = await Execute("ExecSqlScriptFromWorkbook");
```

**Use of legacy @Var-variables**

```
this.appVariables["@Var[…]"] = 'hello world';
```

<br/> 

### Web Functions

- When a Web Function is pasted, the endpoint name is now automatically set to the name the developer provides. This prevents duplication of endpoint names when developers copy Web Functions and forgets to update the endpoint name of the new Web Function.
- Added overloads to all methods in the SqlCommandService to accept an ``IDictionary<string,object>`` for SQL parameters.

<br/>

**Pass sql parameters to ExecuteNonQuery using a Dictionary**

```
public record ClaimSubmission(string Subject, string FromEMail, DateTimeOffset SubmittedDate, string FileName, byte[] FileBytes);

public sealed class MyWebFunction : WebFunction
{
    public async Task<IActionResult> Run(HttpRequest request)
    { 
    	HttpClient httpClient = this.HttpClientFactory.CreateClient();    
		HttpResponseMessage response = await httpClient.GetAsync("https://localhost:7133/AzureStorageClaims/fetch-all");
		var claimSubmissions = await response.Content.ReadFromJsonAsync<List<ClaimSubmission>>();
		
		foreach(var claimSubmission in claimSubmissions)
		{
			var claimId = Guid.NewGuid().ToString();
			
		    await this.SqlCommandService.ExecuteNonQueryAsync("INSERT INTO Setting_CaseBacklogtable_a0349_04062023064229147 (CaseID, Title, SubmittedDate, FromEmail) Values(@id, @title, @date, @from)",
		    	new Dictionary<string,object>
		    	{
		    		{"@id", claimId },
		    		{"@title", claimSubmission.Subject },
		    		{"@date", claimSubmission.SubmittedDate },
		    		{"@from", claimSubmission.FromEMail }
		    	});
		    
		    await this.PowerShellService.ExecuteScriptByNameAsync("AddToClaimDocuments.powershell", new Dictionary<string,object>
		    {
		       {"fileName", claimSubmission.FileName},
		       {"fileBytes", claimSubmission.FileBytes},
		       {"claimId", claimId}
		    }); 
		    
		}
		
        return await Task.FromResult(Ok());
    }
}
```

<br/>

### Support for defining partitions and indexes

We’ve added support for defining indexes and partitions on Data Stores and Tables which enables developers to significantly improve the performance of key parts of products and custom solutions.

Partitions and indexes can be configured in the new “Scripts” tab of Data Stores and Tables. It is important to note that developers must script the entire logic related to the creation of indexes and partitions, including checking if the index or partition already exists, as shown in the screenshot below.

By pressing “Insert template”, you get a default script with template tags that you can modify to define partitions and indexes on the table.

![Diff tool](https://profitbasedocs.blob.core.windows.net/images/supp.png)

<br/>

### Eaze

- Fixed an issue with the ArrayItemAt(collection, index) function, which did not return the expected value.

<br/>

#### See Also

- [Change Log 2023.3](changelog23_3.md)
- [Change Log 2023.2](changelog23_2.md)
- [Change Log 2023.1](changelog23_1.md)
- [Change Log 2022.5](changelog22_5.md)
- [Change Log 2022.4](changelog22_4.md)
- [Change Log 2022.3 pt 2](changelog22_3_2.md)
- [Change Log 2022.3 pt 1](changelog22_3_1.md)
- [Change Log 2022.2](changelog22_2.md)
- [Change Log 2022.1](changelog22_1.md)
- [Change Log 5.2](changelog52.md)
- [Change Log 5.1](changelog51.md)
- [Change Log 5.0](changelog5.md)
- [Change Log 4.1](changelog41.md)
- [Change Log 4.0](changelog40.md)

<br/>

