
# Time Frame

Time Frames specifies the core configuration used for supporting time relative features, such as Periodic Input, Rollover, and Transaction Pipeline Distribution.

Time Frames are defined by a Time Dimension, a Reference Date, Calendar Type, and the Resolution. In addition, you can specify a Source Reference Date which can be used by the Pivot Transform when importing data to a Data Store.

Time Frames can be configured for Data Stores, Settings, or Data Store Groups. If you configure a Time Frame for a Data Store Group, descendants of the group can inherit the Time Frame.
For a Time Frame to have any effect, you need to add Time Frame Measure Columns to the Data Stores and Settings. Time Frame Measure Columns are special numeric columns that denote which periods in time the values of the columns apply to.

You can view the Time Frame/Time Frame Measure Column concepts as a "coordinate" system having only an x-axis in which time flows along. The Reference Date would be the origin and the Resolution would represent the distance between each point along the axis. The location (starting date) and extent (ending date) of a Time Frame Measure Column along the axis would be determined by its Offset and Length properties.
<br/>

## Configuring Time Frame for Data Store Group

Configuring a Time Frame for a Data Store Group enables descendant Data Stores and Settings to inherit the configuration so that all members of the group can share the same Time. To set up the Time Frame for a Data Store Group, go to the **Time Frame tab** in the Data Store Group editor. Refer to the following topic for setting up the Time Frame configuration.
<br/>

## Configuring Time Frame for Data Store or Setting

To configure the Time Frame for a Data Store or Setting, go to the **Time Frame tab** in the Data Store or Setting editor.

If the Data Store or Setting is a descendant of a Data Store Group having a Time Frame configured, the Data Store or Setting can inherit the Time Frame configuration from the Data Store Group by selecting "Inherit from Ancestor". When Time Frame inheritance is enabled, the Data Store or Setting inherits the Time Frame configuration from the closes Data Store Group having a valid Time Frame configuration.

If the Data Store or Setting is not a descendant of a Data Store Group, or you want to use a Time Frame configuration local to the entity, you need to specify the Time Frame configuration explicitly.
<br/>

## Time Frame Configuration

- **Inherit from Ancestor**

Specifies that the entity will inherit the Time Frame configuration from an entity higher in the Solution Structure. For Data Stores and Settings that are members of the same group, you would normally use inheritance to ensure they use the same Time Frame.

- **Time Dimension**

Specifies the Time Dimension used by the Time Frame. When configuring the Time Frame for a Data Store, the Time Dimension must be added to the Data Store Layout, but it does not have to be connected to the Data Store Schema.

- **Resolution**

Specifies the resolution for the Time Frame. Possible values are Year, Quarter, Month, Week, and Day. The resolution is the base measure for calculating the date range of a Time Frame Column based on the Length and Offset property.

- **Reference Date**

The Reference Data specifies the origin used for calculating dates from a Time Frame. Its main function is to enable support for setting up Data Stores and Settings used for periodic input and provide the control mechanism for doing rollovers using Time Frame Columns. Imagine time flows along the x-axis, the Time Frame Columns are the points along the axis, and the Reference Date is the origin.

The Reference Date is used for calculating the date range for Time Frame Columns, how data is shifted during rollovers, importing data to Data Stores using pivoting, and exporting data from Data Stores using unpivot.

The Reference Date can also be referred to in scripts and data flows using one or more of the Timeframe _@Object[…]_ – directives.

- **Source Reference Date**

The Source Reference Date can be used for filtering data when importing or exporting data to Data Stores using the pivot or unpivot transforms. Using the Source Reference Date rather than hardcoded date filters should be used when the Data Store is enabled for rollover since the Source Reference Date can be updated according to the rollover delta.

- **Calendar Type**

Specifies whether the Time Frame should use a natural or alternative (fiscal) calendar. To use an Alternative Calendar, you need to specify a Time Dimension and the columns in the Time Dimension representing the date parts (year, quarter, month, week, and day).

<br/>

## Videos

- [Datastores](../videos/datastores.md)
- [Time Frame, Time Frame Columns and Rolling Forecast](https://profitbasedocs.blob.core.windows.net/videos/Data%20Store%20-%20Time%20Frame%2C%20Time%20Frame%20Columns%20and%20Rolling%20Forecast.mp4)
