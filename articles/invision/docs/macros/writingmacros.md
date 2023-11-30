# Writing Macros

Macros are written in **C#** and must be implemented in a class that inherits from the **MacroExpansionProvider** base class.  

To implement **Non-Function** macros, you need to override the **RunAsync()** method in the base class and return one expansion for each macro.  

To implement Function macros, you must implement your own methods which must return a string.

<br/>

## See Also  
* [Function Macros](writingmacros/functionmacros.md)
* [The MacroExpansionProvider API](writingmacros/macroexpansionprovider.md)
* [Accessing Arguments](writingmacros/accessingarguments.md)
  
<br/>
