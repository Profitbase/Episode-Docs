
# Lists

Lists are data sources for controls that render a collection of items, such as Dropdowns. Lists, unlike Models, cannot be modified and saved by the user. Lists are similar to Set Models, except they cannot be modified and saved back to the database.

**Example**

```xml
<Lists>
    <List Name="Products"
    Source="@Object[Products].DbObjectName"
    Fields="ProductID, ProductName"/>
</Lists>
```

Then, use it as the data source of a dropdown control by specifying the List Name as the ItemsSource of the dropdown.

```xml
<Dropdown ItemsSource="Products"
SelectedValue="{Binding Path:FormData.ProductID}"
DisplayMember="ProductName"
ValueMember="ProductID"/>
```

<br/>

## Videos

- [Form Schemas](../../../../videos/formschemas.md)
