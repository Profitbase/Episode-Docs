# Localize
>
>```
>Localize(textCode : string);
// or
>Localize(textCode : string, interpolationParams : {});
>```

We use the Localize function to translate text to the language selected by the logged-in user. 

We can use the function in Caption Expressions and Name Expressions for labeling UI elements. 

The Localize function takes a text code as its argument, returns the translated text, and displays it to the user.



>**Example**
>
```
Localize("AccountID")
```

<br/>

>For this to work, you have to configure translations:

<br/>

![Localization](https://profitbasedocs.blob.core.windows.net/images/loc.png)
<br/>



## See Also
* [Caption Expression](../../worksheets/columnproperties/caption.md)

## Videos
* [Localization](../../../videos/localization.md)