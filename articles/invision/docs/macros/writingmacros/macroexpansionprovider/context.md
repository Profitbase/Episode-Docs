# Context

## MacroExpansionProvider.Context

The Context API provides information about the current execution context of the macros. For example, for macros in a SQL Script, the current execution context of the macros is the invocation of the SQL Script.

The **Context** has the following APIs
<br/>

**Properties:**

``ObjectId : string``
>The Id of the object in the current execution context, for example the Object Id of a SQL Script or Report.

``SolutionId : string``
>The ID of the solution in the current execution context, for example the id of the solution of the SQL Script being executed.

``IsDevMode : boolean``
>Indicates whether the execution context is being invoked from the Designer or not.

``Arguments : ArgumentsProvider`` 
>Provides access to read the arguments passed in to the execution context, for example the arguments passed by SetParamValue(…) when executing a SQL Script of loading data to a SQL Report.

``CustomArguments : ArgumentsList``
>Provides an API for creating custom arguments from within macros. When generating parameterized SQL expressions, it is best practice to use query parameters instead of coding the values into the expressions. You can use the CustomArguments list to register query parameters from within your macro.

``UserId : string``
>The id of the currently logged-in user, for example, user@corp.com.

``GetUserUniqueId() : string``
>Returns the ID of the user account of the currently logged in user. If Microsoft Entra ID is used as the identity provider, this is the OID (GUID) coming from Microsoft Entra ID. If Windows AD is used, the ID is the SID.

``LanguageCode : string``
>The culture name in the format languagecode2-country/regioncode2, for example, EN-US.


> [!NOTE]
> This property usually just returns a two-letter language code (for example EN), because InVision is usually set up to use two-letter cultures codes.

``TwoLetterLanguageCode : string``
>The ISO 639-1 two letter language code, for example, EN.




<br/>

The **ArgumentsProvider** has the following APIs

``bool TryGetValue<T>(string name, out T value)``

``bool TryGetValue(string name, out object value)``

``T GetValue<T>(string name)``

``object GetValue(string name)``

``bool Contains(string name)``


<br/>

>The following example shows how the **Context** API can be used to create the ConditionalWhere macro.
>
    namespace Local
    {
        using System; 
        using System.Collections.Generic;
        using System.Threading.Tasks;
        using Profitbase.Invision.Scripting.Dynamic;
        public class MyMacros : MacroExpansionProvider
        {           
            public string ConditionalWhere(string tableAlias)
            {            
                if(this.Context.IsDevMode)
                {
                    return "WHERE 1 = 1";
                }
                else
                {
                    if(this.Context.Arguments.TryGetValue<int>("@Level", out int level))
                    {
                        // @SelectedProductId is passed as argument to the execution context
                        // for example by SetParamValue(...). 
                        // If it is not, provide a default value
                        if(!this.Context.Arguments.Contains("@SelectedProductId"))
                        {
                           this.Context.CustomArguments.Add("@SelectedProductId", "myDummyValue");
                        }
                        switch(level)
                        {
                            case 1:
                                return $"WHERE {tableAlias}.L1 = @SelectedProductId";
                            case 2:
                                return $"WHERE {tableAlias}.L2 = @SelectedProductId";
                            default:
                                return $"WHERE {tableAlias}.LEAF = @SelectedProductId";
                        }
                    }
                    else
                    {
                        return "WHERE 1 = 2"; 
                    }
                }
            }
        }
    }




<br/>

