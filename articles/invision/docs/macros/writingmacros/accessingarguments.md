
# Accessing Arguments

## How to access

To access the arguments passed to the executed object (SQL Script, Report, etc), you can use the Context.Arguments API.

    namespace Local
    {
        using System; 
        using System.Collections.Generic;
        using System.Threading.Tasks;
        using Profitbase.Invision.Scripting.Dynamic;
        
        public class MyMacros : MacroExpansionProvider
        {   
            public string CheckArguments()
            {
                // will throw invalid cast exception if @EmployeeID cannot be cast to int
                if(this.Context.Arguments.TryGetValue<int>("@EmployeeID", out int employeeId))
                {
                    // do something with employeeId
                }
                
                if(this.Context.Arguments.TryGetValue("@ManagerID", out object managerId))
                {
                    // do something with Manager ID
                }
                
                // Check if the @CustomerID was passed
                bool customerIdExists = this.Context.Arguments.Contains("@CustomerID");
                
                // will throw if KeyNotFoundException if @SalesRepID does not exist.
                // will throw invalid cast exception if @SalesRepID cannot be cast to string
                var salesRepId = this.Context.Arguments.GetValue<string>("@SalesRepID");
                
                object objValue = this.Context.Arguments.GetValue("@SomeObjectID"); 
                
                return string.Empty;
            }
        }
    }
