---
title: "Models"
metaKeys: "Models, data, objects, database, displayed, modified, user, interface, Form Schema, instance, table, view, custom query, name, source, fields, filter, insertkey, autoinsert, save, load, query, connectiongstring"
pageIndex: 2
---

Models represent the data objects which are loaded from the database, displayed or modified by the user through the user interface, and then saved back to the database. A Form Schema can have many Models.

A (data) Model represents a single object instance, and contains one or more fields that are read from the database, either from a table, view or custom query. Each field can be data bound to form controls for displaying or modifying data. If you read the Model from a view or custom query, you need to provide a custom SQL expression to save changes back to the database.

**Example**

This example shows how to create a Model named **Person**, with **FirstName**, **LastName** and **DoB** fields. The Source specifies the table that the data is read from (it could have been an actual table name instead of the using the @Object directive). The Fields specify the columns that are read from the table and set as the Model Members. UI controls can data bind to the members of the Model.

The Filter property specifies the WHERE clause of the query.

```xml
<Models>
    <Model Name="Person" Source="@Object[Persons].DbObjectName"
        Fields="FirstName, LastName, DoB" Filter="ID = @ID">
    </Model>
</Models>
```

---

### Model Properties:

<br/>

#### Name

The name of the model. **Required**.

<br/>

#### Source

The database object to read from. Source can either be a View, Table or @Object[…].DbObjectName reference. **Required unless LoadQuery is specified**.

<br/>

#### Fields

Specifies the members of the Model, and the columns containing the data for the model. **Required unless SaveQuery is specified**.

<br/>

#### Filter

Specifies the WHERE clause of the automatically generated (load data) query from the **Fields** and **Source** properties. **Optional**.

<br/>

#### InsertKey

When a Model is saved, it will either do an Update or Insert, based on whether a row matching an id exists or not. The InsertKey is a comma separated list of tokens that specifies the mapping between parameters and key columns not already contained in the Fields property, that is required to insert a new row. The insert key must be on the form Column1 = @Param1, Column2 = @Param2, ...

<br/>

**Example**

```xml
<Model InsertKey ="ProductID = @ProductID, Year = @Year"/>
```

<br/>

#### AutoInsert

When saving Model data, and no custom SaveQuery is specified, InVision will do an update if a matching row already exist, or an Insert if no matching row exist. If, for some reason, you don’t want an insert to happen, you need to explicitly set this property to false.**Optional**. The default value is true.

<br/>

#### SaveQuery

If data is not to be saved to the source table, or if you need to use a custom SQL to save the data correctly, you need to provide the query manually. **Optional**.

<br/>

**Example**

```xml
<Model> <SaveQuery> UPDATE Table1 SET CustomerID = @CustomerID, etc </SaveQuery> </Model>
```

<br/>

#### LoadQuery

Use the load query if the model data cannot be loaded “as-is” from the source table. For example, if you need to pull in data from multiple tables, or if you need to apply transformation during load. **Optional**.

<br/>

**Example**

```xml
<Model> <LoadQuery> SELECT CustomerID, CustomerName FROM  </LoadQuery> </Model>
```

<br/>

#### ConnectionString

If the source table is not in the InVision database, you need to specify the connection string. **Optional**.

<br/>

#### Videos

- [Form Schemas](../../../../videos/formschemas.md)
- [Models and Databinding - Basics](https://profitbasedocs.blob.core.windows.net/videos/FormSchema-ModelsAndDatabinding-Basics.mp4)
