---
title: "File import"
metaKeys: ""
folderOnly: "false"
pageIndex: 1
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2 or later

## Overview

File import is a simple tool to import data to from CSV (comma separated) files to Profitbase EPM using pre-defined import templates for standard dimensions and transactional data.<br/>

File import can be used to speed up the implementation awaiting data integration or as the import tool in the production phase if no data integration exists.<br/>

For financial ledger data, situations may ocurr where new legal entities are acquired and no data integration is available. In such situations a combination of a traditional data integration (existing legal entities) and file import (newly acquired legal entity) may be used. Ledger data for a single legal entity must, however, come from either a file import or a data integration.<br/>

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/FileImportOverview.JPG)

To set up an import ruleset, click the + (new) button:

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/FileImportNew.JPG)

## Required fields

- **Ruleset Name**<br/>
Set a name for the import ruleset.
- **Destination table**<br/>
Select a destination table. The destination table defines what you intend to import and the available import template is defined based on this selection.<br/>
The available destination tables are:<br/>

- Legal entity dimension<br/>
- Account dimension<br/>
- Department dimension<br/>
- Activity dimension<br/>
- Project dimension<br/>
- Employee dimension<br/>
- Product dimension<br/>
- Market dimension<br/>
- Supplier dimension<br/>
- Dim1 dimension<br/>
- Dim2 dimension<br/>
- Dim3 dimension<br/>
- Dim4 dimension<br/>
- Asset group dimension<br/>
<br/>
- Finance Trial balance and OB fact<br/>
- Driver based measures fact<br/>
- Fixed assets fact<br/>
- Salary fact<br/>
<br/>
Note that the dimensions available and their format (parent/child or fixed wide) is configured per solution and controlled by the dimension setup.<br/>

- **Column delimiter**<br/>
The import format is CSV based. Select the delimiter that makes a downloaded template file render correctly in your installation of Excel, i.e. represents one header per column when you open the downloaded template in Excel.<br/>

Once the required fields are set, the import process can start:<br/>

## Download template to your local machine

Click the Download template file, save it to your local machine and open the file in Excel. If the contents does not render correctly, i.e. each header separated into it's own column, alter the column delimiter setting and down load the template again.

Edit the file and save it to your local machine.

## Upload and Process file for your local machine

Having edited the downloaded template (i.e. added the content you want to import), click the Upload button and drag the saved file onto the drop-zone available.

Click the Process button to load the file to a temporary storage in Profitbase EPM. Alongside the Process button is a viewer button that allows you to view the contents loaded into the temporary storage.

## Validate the processed file

Before you can import the file, it is mandatory to validate the contents of the file. The validation is sensitive to the destination table selected e.g., if you have selected the Account dimension as destination table, the validation will check the content with respect to the data requirements for the Account dimension.<br/>

For details on the kind of validation checks performed, please refer to the description given on the Audit page:

-  [Audit](/planner/workbooks/data-management/data-import/audit)

Errors and/or warnings are presented if they exist. Please review and correct any issues before attempting to import the data!

## Import the processed file

If no validation issues exists, click the Import button to import and process the data.

An explanation regarding the import process to the destination table in question is presented above the import button:

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/FileImportImport.JPG)

