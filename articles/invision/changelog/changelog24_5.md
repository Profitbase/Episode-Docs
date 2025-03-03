# Changelog 2024.5

Our main focus for InVision is improvement of existing features and usability, while [Flow](../../flow/changelog/changelog24_december.md) is receiving a lot of new features with a focus on business logic, data integrations, and ease of use. Our goal is to ensure that InVision and Flow feel truly integrated, and make Flow the main tool for defining business logic for InVision solutions.

</br>

## Work Process

### View Log of Previous Version Deployment

You can now view the log of the previous status change operation (Deploy, Open, Close) of a Work Process Version. This makes it easier to review any issues during the operation later.

![img](https://profitbasedocs.blob.core.windows.net/images/InVision_24_5_1.png)

</br>

## Dimensions and Dimension Management

### Create a Copy of a Dimension from the Dimension Editor

You can now create a copy of a dimension directly from the Workbook Dimension Editor. This eliminates the need to use the Designer to do this. This makes it easy for business users to create multiple versions of a dimension and then publish that version to select forecast or budget versions.

![img](https://profitbasedocs.blob.core.windows.net/images/InVision_24_5_2.png)

### Changes to Publish Dimension

The Publish Dimension dialog has the following changes:

- You can now publish **to** any dimension that matches the schema, including columns and data types, of the source dimension.
- When publishing a dimension, you now have to explicitly specify that you want to publish to other versions or solutions before you can select which other dimensions you want to publish to. This change was introduced because users too often inadvertently publish to dimensions they don’t mean to.

![img](https://profitbasedocs.blob.core.windows.net/images/InVision_24_5_3.png)

### New Editing Options

You can configure which editing and publishing options are available for a dimension in the Dimension Editor. This includes:

- Whether or not a dimension can be published to. You typically want to disable this option for most Primary dimensions.
- Whether or not users can edit the contents of the dimension from the Dimension Editor. You often want to disable this option for dimensions in blueprint or versioned solutions.
- Whether or not users can make a copy of the dimension from the Dimension Editor. You can determine whether enabling this option aligns with your solution’s requirements.  
For example:
  - If you create a solution for users to create multiple reporting structures for Power BI, you want to enable this option.
  - If you create a solution where it does not make sense to have more than one version of a dimension, you should disable this option.

</br>

![img](https://profitbasedocs.blob.core.windows.net/images/InVision_24_5_4.png)

## Tab Controls

- The Workbook Tab Control now raises the Selection Changed event when a tab is selected programmatically or by a user. This allows developers to define business logic that runs when a tab is selected.
- You can now register a callback function for the **SelectionChanged** event, which is raised when the selected tab is changed programmatically or by a user. [Read more here: Tab control events](../docs/forms/formschemas/controls/tabcontrol.md#events).

</br>

## Language and Regional Settings

Users can now specify different preferences for language and regional settings, meaning formatting of dates and numbers are independent of language. A typical example is if you want the text in the UI to be in English, but you want Norwegian date and number formatting.

</br>

![img](https://profitbasedocs.blob.core.windows.net/images/InVision_24_5_5.png)

## Performance

We’ve added multiple enhancements that make saving data to Worksheets, Tables, and Dimensions much faster. These performance improvements are especially evident for customers managing numerous Work Process Versions.

</br>

## Flow Integration

You can now navigate directly to Flow from the Workbook Menu. This makes it easy for business users to jump into the business logic directly from Workbooks instead of having to open the Flow Portal manually or through the InVision Designer.

![img](https://profitbasedocs.blob.core.windows.net/images/InVision_24_5_6.png)


## See Also
- [Change Log 2025.1](changelog25_1.md)
- [Change Log 2024.4](changelog24_4.md)
- [Change Log 2024.3](changelog24_3.md)
- [Change Log 2024.2](changelog24_2.md)
- [Change Log 2024.1](changelog24_1.md)
- [Change Log 2023.7](changelog23_7.md)
- [Change Log 2023.6](changelog23_6.md)
- [Change Log 2023.5](changelog23_5.md)
- [Change Log 2023.4](changelog23_4.md)
- [Change Log 2023.3](changelog23_3.md)
- [Change Log 2023.2](changelog23_2.md)
- [Change Log 2023.1](changelog23_1.md)
- [Change Log 2022.5](changelog22_5.md)
- [Change Log 2022.4](changelog22_4.md)
- [Change Log 2022.3 pt 2](changelog22_3_2.md)
- [Change Log 2022.3 pt 1](changelog22_3_1.md)
- [Change Log 2022.2](changelog22_2.md)
- [Change Log 5.2](changelog52.md)
- [Change Log 5.1](changelog51.md)
- [Change Log 5.0](changelog5.md)
- [Change Log 4.1](changelog41.md)
- [Change Log 4.0](changelog40.md)
