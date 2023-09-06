---
title: "Rendering Items"
metaKeys: "UI, ItemsSource, items, property, array, objects, List, SetModel, listbox, ValueMember, ItemTemplate, DisplayMember, ValueMember, layout, display, The Data Context, keyword, bind, $Data keyword, "
pageIndex: 1
---




To render items, the **ItemsSource** property must reference an array of objects, a List, or a SetModel. Next, you need to specify either the **DisplayMember** and **ValueMember** or the **ItemTemplate**.

#### DisplayMember/ValueMember

The DisplayMember / ValueMember option will simply display a list of strings and can be used if you just need to display a basic list of values.

#### ItemTemplate

The ItemTemplate enables you to customize how you want each item in the listbox to be displayed, using all the available UI controls.

The ItemTemplate must contain a single [Layout](../layout.md) element. Within the Layout element, you can use all the available UI controls to specify how you want each item to be displayed. You are not restricted to simply displaying data in a listbox. You can add input controls with data bindings to edit data and action controls (such as Buttons) to raise events and perform custom operations.

#### The Data Context

The default Data Context for a listbox item is the data item that is rendered. To data bind to a property of a data item, you simply refer to the property using the binding syntax, for example

    Text={Binding Path:TheProperty}

If you need to bind to something outside the default Data Context, for example a Model, List or a custom object in the Form Runtime, you can their fully qualified path, for example 

    Text={Binding Path:Models.MyModel.MyProperty}

#### The $Data keyword

The $Data keyword is a refererence to the data item from the items source that is rendered in the listbox item. You can pass this value to function callbacks (for example the Click function for Buttons), if you want to add custom interactions to listbox items, for example

    <Button Click="SomeAction($Data)"/>


>**Example**
>
>This example shows how a **SetModel** is data bound to a Listbox, and how an **ItemTemplate** describes how each item of the SetModel is rendered in the list.
>
>The $Data keyword is the reference to each **data item** from the Set Model which is rendered in a listbox item. $Data can be be passed as an argument to any function called from within the ItemTemplate, as well as to the ItemSelected handler.
>
    <Data>
        <SetModels>
        <SetModel Name="SetItems"  
            Source="Setting_FormDataTable_11022017131046"  
            Fields="ID, Numeric" ItemKey="ID = @ID">
            </SetModel>
        </SetModels>
    </Data>
    …
    <Listbox Row="12" Column="1" ItemsSource="SetItems" 
            ValueMember="Numeric" 
            ItemSelected="onListboxItemSelected($Data)" 
            SelectedValue="{Binding Path:FormData.Numeric}" KeyProp="ID">
            <ItemTemplate>
                <Layout Grid="listboxItemTemplateGrid" CssClass="listbox-item">
                    <Label Row="1" Column="1" Text="{Binding Path:ID}"  
                    CssClass="{Binding Path:CssClass}"/>
                    <Input Row="1" Column="2" Value="{Binding Path:Numeric}" Type="number"  
                    Margin="0 0 0 10px" />
                <Button Row="2" Column="1" Text="Open" Click="Open($Data)" />                
            </Layout>
        </ItemTemplate>
    </Listbox>

