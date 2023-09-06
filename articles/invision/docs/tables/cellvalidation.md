---
title: "Cell Validation"
metaKeys: "Cell validation, Name, Disabled, Rule Type, Target, Statement, Validation Failure Message Expression "
pageIndex: 3
---

Cell value validation can be enabled by entering Cell Validation Rules. Cell Validation Rules uses the formula syntax to address the cell to validate and the expression used for evaluating whether the value of the cell passes validation or not.

<br/>

#### Name

The name of the validation rule. This property is used for management purposes only.

<br/>

#### Disabled

Specifies whether the validation rule is enabled or disabled. Mainly used for temporarily disabling validation rules while debugging or configuring the grid.

<br/>

#### Rule Type

Specifies whether the validation rule is a critical (ValidationError) or not-critical (ValidationWarning) rule. A validation error sets a red border around a cell, while a warning sets a yellow border.
Also, if validation is set up to execute from a Workbook context, a toast notification will appear if there are any validation errors. 
You can specify both a warning and error validation for the same cells.

<br/>

#### Target

The address of the cells to mark as invalid if the validation Statement fails (returns false).
Cells are addressed using standard formula syntax. 

<br/>

#### Statement

The formula used for evaluating whether the validation fails or not.  
The statement should return true if the validation succeeds, otherwise false.

>**Example**
>
>To verify that cells in the Amount column contains values greater than 500, specify the following Target and Statement properties:
>
    Target: @Amount[]
    Statement : @Amount[] > 500

<br/>

#### Validation Failure Message

The message displayed to the user if the validation failes.
<br/>

#### Validation Failure Message Expression

A C#.NET expression returning a string displayed to the user if the validation fails.

<br/>

#### Videos

* [Worksheet](../../videos/worksheet.md)
* [Cell Validation in Spreadsheets](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20-%20Cell%20Validation%20in%20spreadsheets.mp4)