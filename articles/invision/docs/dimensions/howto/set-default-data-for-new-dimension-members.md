# Set default data for new dimension members

When a new dimension member is added to a dimension, default values for Name and Properties can be automatically assigned through a custom JavaScript function.

The JavaScript function that assigns default values to new dimension members are defined in the `Editor Scripts` tab in the `Designer`.

![img](/images/invision/dimension-editor-scripts-onadditem.png)

The function has the following signature: 
```javascript
function(newItem: Item) : void{
}
```

#### Item

| Property    | Data type     | Description             |
|-------------|---------------|-------------------------|
| name        | string        | The name of the new dimension member, for example the product or employee name. |
| isLeaf      | boolean       | Indicates whether or not the new member was added at the lowest (leaf) level. Note that the user can rearrange the dimension at any time, so this property only captures the current position of the item. |
| properties  | Array&lt;DimensionProperty&gt; | An array of dimension properties. You cannot add or remove items from the collection, only modify the `value` property of each item. (See example below.) |

#### DimensionProperty

| Property    |  Data type      | Description                                                |
|-------------|-----------------|------------------------------------------------------------|
| propertyId  | string          | The propertyId, for example "Color", as defined in the Properties and/or Extended Properties panel in the Designer. You cannot modify this value. |
| value       | any             | The value of the property, for example "Red". You can modify this value.   |

<br/>

##### Example
```javascript
// Set the Name property of the dim member to 'My default value'
newItem.name = 'My default value';

// Set the default value for the Color property to 'Red'
const colorItem = newItem.properties.find(prop => prop.propertyId === 'Color');
colorItem.value = 'Red';
```



