---
title: "Set Models"
metaKeys: "Set Models, properties,  data, objects, database, displayed, modified, user, interface, Form Schema, instance, table, view, custom query, name, source, fields, filter, insertkey, autoinsert, save, load, query, connectiongstring"
pageIndex: 4
---

Set Models are similar to Lists, except their contents can be modified and saved back to the database. Set Models represents a collection of objects which is read from the database, can be modified in the user interface, and then saved back to the database. You would typically use a Set Model for displaying and editing data in a Listbox.

**Example**

This example shows how to load all employees in a department and display them in a Listbox.

```xml
<SetModels>
        <SetModel Name="Employees"
        Source="Employees_ByDepartment"
        Fields="EmpID, FirstName, LastName"
        Filter="DepID = @DepID"
        ItemKey="EmpID = @EmpID">
        </SetModel>
</SetModels>

...
<Listbox Row="12" Column="1" ColumnSpan="2" ItemsSource="Employees" KeyProp="EmpID">
    <ItemTemplate>
        <Layout Grid="listboxItemTemplateGrid" CssClass="listbox-item">
            <Label Row="1" Column="1" Text="{Binding Path:FirstName}"/>
            <Input Row="1" Column="2" Value="{Binding Path:LastName}" Type="text" />
            <Button Row="2" Column="1" Text="Edit" Click="EditEmp($Data)" />
        </Layout>
    </ItemTemplate>
</Listbox>
```

---

### Set Model Properties:

<br/>

#### Name

The name of the model. **Required**.

<br/>

#### Source

The database object to read from. Source can either be a View, Table or @Object[…].DbObjectName reference. **Required unless LoadQuery is specified.**

<br/>

#### Fields

Specifies the members of the Model, and the columns containing the data for the model. **Required unless SaveQuery is specified.**.

<br/>

#### Filter

Specifies the WHERE clause. This property is ignored if the LoadQuery is specified. **Optional**.

<br/>

#### ItemKey

Specifies the WHERE clause that identifies a single row in the set. This property is used when data is saved to the database. **Required** if you want to save data.

<br/>

#### InsertKey

When a Set Model is saved, it will either do an Update or Insert pr row, based on whether the row mathing a key exists or not. The InsertKey is a comma separated list of tokens that specifies the mapping between parameters and key columns not already contained in the Fields property, that is required to insert a new row. The insert key must be on the form **Column1 = @Param1, Column2 = @Param2, ... **

<br/>

**Example**

```xml
<SetModel InsertKey="ProductID = @ProductID, Year = @Year"/>
```

<br/>

#### AutoInsert

When saving Set Model data, and no custom SaveQuery is specified, InVision will do an update for each Set Model object if a matching row already exist, or an Insert if no matching row exist. If, for some reason, you don’t want an insert to happen, you need to explicitly set this property to false. **Optional**. The default value is true.

#### SaveQuery

If data is not to be saved to the source table, or if you need to use a custom SQL to save the data correctly, you need to provide the query manually. The SaveQuery executes pr Set Model item. **Optional.**

<br/>

**Example**

```xml
<SetModel>
    <SaveQuery>
        UPDATE Table1 SET CustomerID = @CustomerID, etc
    </SaveQuery>
</SetModel>
```

<br/>

#### LoadQuery

Use the load query if you want to provide a custom query for loading items into the Set Model. For example, if you need to pull in data from multiple tables, or if you need to apply transformation during load. **Optional.**

<br/>

**Example**

```xml
<SetModel>
    <LoadQuery> SELECT CustomerID, CustomerName FROM  </LoadQuery>
</SetModel>
```

#### ConnectionString

If the source table is not in the InVision database, you need to specify the connection string. **Optional.**

<br/>

### Videos

- [Form Schemas](../../../../videos/formschemas.md)
- [Listbox - Basics](https://profitbasedocs.blob.core.windows.net/videos/FormSchema-Listbox-Basics.mp4)
