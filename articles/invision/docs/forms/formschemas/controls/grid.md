
# Grid

Inherits from [Control](control.md).

<br/>

![grid](https://profitbasedocs.blob.core.windows.net/images/gridFS.png)

<br/>

The Grid defines a flexible grid layout area that consists of rows and columns. It enables displaying controls, such as buttons, labels, lists, etc in a grid layout system. The difference between the Layout panel and the Grid panel is that the Grid panel enables setting the rows and columns on the component itself, rather than having to refer to a layout in the Layout section of the Form Schema.

<br/>

**Properties**

`Rows`

Defines the rows in the grid layout.

https://developer.mozilla.org/en-US/docs/Web/CSS/grid-template-rows

<br/>

`Columns`

Defines the columns in the grid layout.

https://developer.mozilla.org/en-US/docs/Web/CSS/grid-template-columns

<br/>

`Gap`

Sets the gaps between rows and columns.

https://developer.mozilla.org/en-US/docs/Web/CSS/gap

<br/>

`Area`

Specifies named grid areas, establishing the cells in the grid and assigning them names.

https://developer.mozilla.org/en-US/docs/Web/CSS/grid-template-areas

<br/>

**Example**

```xml
    <Grid Rows="100px 1fr 50px" Columns="100px 1fr" Gap="8px" Areas="'header header' 'nav content' 'footer footer'">
        <Label Text="Header" GridArea="header" CssClass="a1"/>
        <Label Text="Nav" GridArea="nav" CssClass="a2"/>
        <Label Text="Content" GridArea="content" CssClass="a3"/>
        <Label Text="Footer" GridArea="footer" CssClass="a4"/>
    </Grid>
```

![Grid](https://profitbasedocs.blob.core.windows.net/images/grid2.png)

**Example**

```xml
<Grid Rows="100px auto auto 200px minmax(10px, 250px) 1fr" Columns="40px auto repeat(2, 200px) 1fr" Gap="8px">
    <Label Text="A1" Row="1" Column="1" CssClass="a1"/>
    <Label Text="A2" Row="2" Column="1" CssClass="a2"/>
    <Label Text="A3" Row="3" Column="1" CssClass="a3"/>
    <Label Text="A4" Row="4" Column="1" CssClass="a4"/>
    <Label Text="A5" Row="5" Column="1" CssClass="a5"/>
    <Label Text="A6" Row="6" Column="1" CssClass="a6"/>
    <Label Text="B1" Row="1" Column="2" CssClass="b1"/>
    <Label Text="C1" Row="1" Column="3" CssClass="c1"/>
    <Label Text="D1" Row="1" Column="4" CssClass="d1"/>
    <Label Text="E1" Row="1" Column="5" CssClass="e1"/>
    <Label Text="C4" Row="4" Column="3" CssClass="c4"/>
    <Grid Row="5" Column="3" ColumnSpan="2" Rows="1fr 200px 1fr" Columns="1fr minmax(100px, 200px) 1fr" CssClass="nestedGrid">
        <Label Text="Nested" Row="2" Column="2" CssClass="center"/>
    </Grid>
</Grid>
```

<br/>

![Grid](https://profitbasedocs.blob.core.windows.net/images/grid.png)

<br/>

## Videos

- [Form Schemas](../../../../videos/formschemas.md)

- [Grid](https://profitbasedocs.blob.core.windows.net/videos/Form%20schema%20-%20Grid.mp4)
