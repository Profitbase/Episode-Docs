
# Styling and Layout

The Style section contains the styling and layout options that are used to describe how the contents of the Form Schema should be displayed (font size, colors, control arrangements, sizes etc). You can use the global (Solution) css styles for styling Forms contents just like any other component in InVision, but each Form Schema will most likely have their own requirements for layout, so keeping them tied together is usually the best option.

## Css Element

The Css element contains your custom css styles that can be applied to the controls inside the Form Schema. Each control has a CssClass attribute, which allow you to add custom css styles to it. In addition, the css styles within this element can be applied to controls through the Form Schema API.

**Css Element**

    <Form>
        <Style>
            <Css>
                …your css…
            </Css>
        </Style>
    </Form>


>**Example**
>
    <Css>
        .bold{
            font-weight:bold;
        }          
        .margin-top-5{
            margin-top:5px;
        }
    </Css>
>
>Then, apply the css class to a Form Schema control
>
    <Label CssClass="bold" Row="2" Column="1" Text="Item 1" />


#### Grid Layouts

The Layouts element contains a collection of Grid layout configurations. A Grid arranges its children into rows and columns. The built-in Grid layout supports a subset of the standard W3C Css Grid Layout features, is very easy to set up, and should cover at least 95% of all Form Schema layout scenarios. 

**Layouts Element**

    <Form>
        <Style>
            <Layouts>
                <Grid Name="name" Rows="horizontal tracks" Columns="vertical tracks" />
            </Layouts>
        </Style>
    </Form>


>**Example**
>
    <Layouts>
    <Grid Name="grid1" Rows="auto 20px auto 20px auto 20px auto 1fr" Columns="1fr 1fr" />
    <Grid Name="grid2" Rows="auto 20px" Columns="80px 1fr" />
    </Layouts>
>
>Then, apply the grid layout to a layout container so that it’s children can be arranged into rows and columns
>
    <UI Grid="grid1">
    </UI>


**Grid properties**

-	**Name** – required. Specify the name of the grid in the Grid property of Layout containers to indicate which grid layout to apply to the container.
-	**Rows** – Specifies the horizontal grid track, and is directly set as the grid-template-rows property of the Css Grid Layout applied to the layout container.
-	**Columns** – Specifies the vertical grid tracks, and is directly set as the grid-template-colums property of the Css Grid Layout applied to the layout container.

If you need to use the full Css Grid Layout, or some other layout schema (for example flexbox), you must do this using standard css and apply class styling to the layout containers and controls in the Form Schema.
<br/>



## Videos

* [Form Schemas](../../../videos/formschemas.md)
* [Styling and Layout](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Layout%20and%20styling.mp4)