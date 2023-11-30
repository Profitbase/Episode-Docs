
# Themes and Styles

## Style Sheets
There are two types of Style Sheets:
* Data Grid Style Sheet
* Generic style sheet

A grid arranges its children into rows and columns.


## Creating a new Theme

1. Click on the **“Themes and Styling”** tab.
2. Click on the **“New”** button.
3. Name your style Theme.
4. Check the **“Is Default Theme”** check box.  
This tells the system to use this Theme for the styling of the landing page.
5. Save.
<br/>

![Themes and Styles](https://profitbasedocs.blob.core.windows.net/images/themesstyles1.png "Themes and Styles")
<br/>

Profitbase LOW CODE uses **CSS** to style and format our solution. We are going to create some **CSS** classes.

1. Go to the Style Sheet tab.
2. Click on the **“New”** button and add a **“Data Grid Style Sheet”**.
    - We use this to style components within a worksheet, report or table like column og text color. These classes are surrounded by a “handsontable” class. Make sure you properly close all new classes separately and the handsontable class at the end.
3. Name it “Common”.
4. Then add Bold CSS class:
   
```
.Bold{ 
    font-weight: bold; 
    }
```

5. Your Configuration should look like this:

<br/>

![Themes and Styles](https://profitbasedocs.blob.core.windows.net/images/themesstyles2.png "Themes and Styles")

<br/>

6. Click on the **“New”** button and add a **“Generic style sheet”**.
    - We use this to style components outside of the grid components like buttons and backgrounds etc.
7. Name it **“CommonNonGrid”**.
8. Then add **RedBackground** CSS class:
   
```
.RedBackground{ 
    Background:red; 
    }
```

9. Your Configuration should look like this:

<br/>

![Themes and Styles](https://profitbasedocs.blob.core.windows.net/images/themesstyles3.png "Themes and Styles")

<br/>

10. Save.
11. Click on **“Republish All”.**
    
<br/>

![Themes and Styles](https://profitbasedocs.blob.core.windows.net/images/themesstyles4.png "Themes and Styles")


<!--<br/>

## Difference between ... -->

<br/>

## Videos

* [Themes and Styles](../../videos/themesandstyles.md)
* [Styling - Using custom images](https://profitbasedocs.blob.core.windows.net/videos/Styling%20-%20Using%20custom%20images.mp4)
* [Styling - Adding a Css Class](https://profitbasedocs.blob.core.windows.net/videos/Styling%20-%20AddCssClass.mp4)
* [Form Schema - Layout and styling](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Layout%20and%20styling.mp4)


