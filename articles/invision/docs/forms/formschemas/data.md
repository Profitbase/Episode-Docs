
# Data

## Data Models

This section describes the different types of data models that can be used in forms.
A data model is used for either displaying data (for example a list of customers), or editing data.

**Lists** are data sources for controls that render a collection of items, such as Dropdowns. Lists, unlike Models, cannot be modified and saved by the user. Lists are similar to Set Models, except they cannot be modified and saved back to the database.

**Set Models** are similar to Lists, except their contents can be modified and saved back to the database. Set Models represents a collection of objects which is read from the database, can be modified in the user interface, and then saved back to the database. You would typically use a Set Model for displaying and editing data in a Listbox.

**Models** represent the data objects which are loaded from the database, displayed or modified by the user through the user interface, and then saved back to the database. A Form Schema can have many Models.

A (data) Model represents a single object instance, and contains one or more fields that are read from the database, either from a table, view or custom query. Each field can be data bound to form controls for displaying or modifying data. If you read the Model from a view or custom query, you need to provide a custom SQL expression to save changes back to the database.

**Dimension Models** are data sources for controls that can display data in a hierarchical view, for example, the [TreeView](./controls/treeview.md) control.  
Dimension Models are read-only and cannot be modified and saved back to the database.

## See Also

- [Lists](data/lists.md)
- [Models](data/models.md)
- [Dimension Models](data/dimensionmodels.md)
- [Set Models](data/setmodels.md)

<br/>

## Videos

- [Form Schemas](../../../videos/formschemas.md)
- [Layout and Styling](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Layout%20and%20styling.mp4)
- [Models and Databinding - Basics](https://profitbasedocs.blob.core.windows.net/videos/FormSchema-ModelsAndDatabinding-Basics.mp4)
- [Listbox - Basics](https://profitbasedocs.blob.core.windows.net/videos/FormSchema-Listbox-Basics.mp4)
