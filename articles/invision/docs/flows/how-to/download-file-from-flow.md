# Download file from Flow

To generate a file with Flow and automatically download it from an InVision Workbook, you must do the following:

1) Create a Flow that returns a file using the [Return File HTTP response](../../../../flow/actions/http/return-file-http-response.md). 
2) From a Workbook, run the Flow using the [Download API](../../workbooks/programmingmodel/apis/flow-apis.md#downloadstring-data). This API can be called from any [Execute Expression](../../workbooks/programmingmodel/interactionmodel/workbookactions.md#execute-expression) action or [Form Schema functions](../../forms/formschemas/functions.md). 