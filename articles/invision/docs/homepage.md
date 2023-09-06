---
title: "Home Page"
metaKeys: "Home Page, Customizing, WorkbookId , Order , ImageUrl , CssClass  "
folderOnly: "false"
pageIndex: 14
---

### Customizing the Home Page Layout

The Home Page lists all the available Workbooks that the logged-on user has access to. By default, the Workbooks are listed in the order they are defined in the Solution, with a default icon and default colors. This may, however, not be the way you want to display them to end-users.

To customize the order, icon, grouping, and style of the Workbooks displayed on the Home Page, you need to use the InVision Desktop Designer to configure the Home Page layout.
<br/>

In the application main menu bar, go to **Home Page** -> **Edit Layout** and create a configuration if one does not already exist. The xml configuration will have the following format:

```xml

    <HomePageConfiguration>
        <WorkbookGroups>
            <WorkbookGroup Heading="Group heading"
                        HeadingTextCode=""
                        MenuImage="">
                <Workbooks>
                    <WorkbookTile/>
                </Workbooks>
            </WorkbookGroup>
        </WorkbookGroups>
        <Workbooks>
            <WorkbookTile WorkbookId="workbook object Id"
                        Order="0...n"
                        Image="url"
                        MenuImage=""
                        CssClass="css class string"/>
            <WorkbookTile WorkbookId="workbook object Id"
                        Order="0...n"
                        Image="url"
                        MenuImage=""
                        CssClass="css class" />
            . . .
        </Workbooks>
    </HomePageConfiguration>
```

<br/>
The configuration enables you to define Workbook groups and the order of which the Workbooks are displayed to the end user. 
<br/>

To configure a WorkbookTile, you need to set the WorkbookId attribute. The value of the attribute is the object id of the Workbook that can be found by right-clicking the Workbook in the Solution Explorer and "Copy Id to Clipboard".
<br/>

#### Workbook as a Homepage

You can configure a Workbook to be the landing page of InVision instead of the default system homepage. This enables you to create a fully customized and actionable landing page for users instead of just a Workbook launcher portal.
![pic](https://profitbasedocs.blob.core.windows.net/images/wbasSp.png)
<br/>

#### WorkbookGroup properities

- **Heading** specifies the default heading for the group in the Homepage or the heading of the Group in the Workbook Menu (sidebar)

- **HeadingTextCode** specifies the text code used for localization of the heading based on the user language.

- **MenuImage** specifies the image displayed as the Group node in the Workbook Menu.

#### WorkbookTile properties

- **WorkbookId** specifies the Id of the Workbook that the tile should represent. Available Workbooks without matching tile Ids will be rendered after the configured tiles using a default style template.

- **Order** specifies the order at which the Workbook Tile apprears on the Home Page

- **Image** specifies the URL to the tile image. (preferably a .svg). This property is optional.

- **CssClass** property specifies one or more CSS classes to apply to the Workbook tile. This property is optional.

- **MenuImage** specifies the image for the Workbook when displayed in the Workbook Menu (sidebar). This property is optional.

<br/>



### See Also

* [How to's](homepage/howto.md)


### Videos

* [Home Page](https://profitbasedocs.blob.core.windows.net/videos/Workbooks%20-%20Workbook%20as%20a%20Homepage.mp4)
  