# Filter Service API

The following APIs can be used in any [Execute Expression](../interactionmodel/workbookactions.md#execute-expression) Actions or [Form Schema functions](../../../forms/formschemas/functions.md).

#### get(string, string)

Returns the filter state of a filter in the Workbook.

##### API Definition

```javascript
this.app.filters.get("groupName", "filterName") : FilterData | null
```

##### FilterData definition

```javascript

export class FilterRefSelections {
    public Items: FilterRefSelection[]
    public Descriptions(separator = ', '): string | null
    public Ids(separator = ', '): string | null
}

export interface FilterSelection {
    Id: any
    Description: string | null | undefined
    Level: number | null | undefined
    IsLeaf: boolean | null | undefined
    ColumnName?: string | null
}

interface FilterData {
    fullName: string
    selectedValue?: FilterSelection | null,
    selectedValues?: FilterSelections | null,
    dataSourceId?: string
}
```

##### Example

This example shows how to get the selected department from a filter named "Department" in a Workbook.

```javascript
const selection = this.app.filters.get("Filters", "Department");
const departmentId = selection.selectedValue.Id;
const departmentName = selection.selectedValue.Description;
const isLeaf = selection.selectedValue.IsLeaf;

```
