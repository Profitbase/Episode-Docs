---
title: "Class Libraries"
metaKeys: "Class Libraries, Creating , ScriptMethodAttribute, Developing and deploying Class Libraries using Visual Studio, Debugging code using Visual Studio, "
pageIndex: 2
---

Class Libraries contains the functions (business logic) being executed by Data Flow Items. 

Class Libraries can be written directly in Data Flow Item as Scripts, or using any tool able to produce a .dll and then linked into InVision by referencing the .dll(s). 

The process of turning a Class Library into executable code is called compiling, and a compiled class library is called an Assembly.
<br/>

### Creating Class Libraries

Class Libraries contains one or more classes with methods which are compiled into assemblies that can be executed by Data Flow Items. 

In order for the Infinity runtime to be able to recognize and execute the code, the classes and methods must be annotated with ScriptClass and ScriptMethod attributes.
<br/><br/>

**ScriptClassAttribute**

>Namespace : Profitbase.AppFramework.Infinity.Runtime  
>Assembly : Profitbase.AppFramework.Infinity.Core  
(in Profitbase.AppFramework.Infinity.Core.dll)

The ScriptClass attribute is used for annotating classes containing executable code for the Infinity runtime. Classes not annotated by the ScriptClass attribute cannot be referenced or called from Data Flow Items.

The class is identified by its namespace and its class name on the form, mynamespace.myclass.
<br/>

**Property**

* **ClassId** can be used for specifying an identifier for the class instead of the default namespace and class name.

>
    namespace MyCompany.Tasks
    {
        using System;
        using Profitbase.AppFramework.Infinity.Runtime;
        [ScriptClass]
        public class Calculator
        {
        }
        [ScriptClass("AdvancedCalculator")] 
        public class AdvancedCalculator
        {
        }
    }
>
>The Id of the Calculator class will be MyCompany.Tasks.Calculator.  
>The Id of the AdvancedCalculator class will be AdvancedCalculator, since we’re using the ClassId property of the ScriptClass attribute to set the class id explicitly.

<br/><br/>

**ScriptMethodAttribute**

>Namespace : Profitbase.AppFramework.Infinity.Runtime  
>Assembly : Profitbase.AppFramework.Infinity.Core  
(in Profitbase.AppFramework.Infinity.Core.dll)

The ScriptMethod attribute is used for annotating methods that can be executed by the Infinity runtime. Methods annotated with the ScriptMethod attribute are the public API of the Class Library. Methods not annotated by a ScriptMethod attribute cannot be referenced or called from Data Flow Items.

The method is identified by the **class id** and the **method id** on the form classid.methodid. The method id matches the method name unless a different method id is specified using the MethodId property of the ScriptMethod attribute.

A method id must be globally unique, meaning that in order to use method overloading, you need to use the MethodId property of the ScriptMethod attribute to specify unique names if you have two public methods with the same name.
<br/>

**Property**

* **MethodId** can be used for specifying a method id instead of the method name.

>
    namespace MyCompany.Tasks
    {
        using System;
        using Profitbase.AppFramework.Infinity.Runtime;
        [ScriptClass]
        public class Calculator
        {
            [ScriptMethod]
            public double Add(double a, double b)
            {
                return a + b;
            }
        }
        [ScriptClass("AdvancedCalculator")] 
        public class AdvancedCalculator
        {
            [ScriptMethod("Sub2")]
            public double Sub(double a, double b)
            {
                return a – b;
            }
        }
    }
>
>The Id of the **Add** method will be MyCompany.Tasks.Calculator.Add.  
The Id of the **Sub** method will be AdvancedCalculator.Sub2, since we’re using the ClassId property of the ScriptClass attribute to set the class id and the Method Id of the ScriptMethod attribute to set the method id explicitly.

<br/><br/>

**Developing and deploying Class Libraries using Visual Studio**

This section describes how to develop, deploy and debug Class Libraries using Visual Studio.
<br/><br/>

*To set the stage, we’ll create a class library for the imaginary company Hypotesia:*

1.	In Visual Studio, create a new **Class Library** project (**File** -> **New** ->** Project… Windows | Class Library**). We’ll call it **Hypotesia.BusinessLogic.**

2.	Create a new **public class** for your business logic.

3.	Add a **public method** to the class.
<br/>

*Next, we need to make the class and method discoverable and executable:*

1.	Add a reference to **Profitbase.AppFramework.Infinity.Core.dll**. 
 To find it, browse to the \bin folder in the Designer website, or to the Worker service install folder. This assembly contains the core runtime types that enables your code to be discovered and executed by the Infinity Runtime.

2.	In your class file, add a **using** statement to the **Profitbase.AppFramework.Infinity.Runtime** namespace.

3.	Add a **ScriptClass** attribute to your **class**.

4.	Add a **ScriptMethod** attribute to your **method**.
<br/>

*To make your functions discoverable by the Designer, you need to copy the assembly (.dll) to two folders and register them with the application. Now you can use them in your Solution, and enable the Infinity Runtime to execute them.*

1.	In the Solution Explorer, open the Project Properties:

      *	Go to Build Events.

      *	Add the following Post-build event command line commands:

         *	``xcopy "$(TargetDir)Hypotesia.BusinessLogic.dll" <path to worker service> /y``
         *	``xcopy "$(TargetDir)Hypotesia.BusinessLogic.dll" <path to designer website bin folder> /y``

         **Note!** You may not have permissions to write to these folders by default. If not, open Properties for each folder and go to **Security** -> **Edit**, and make sure you have at least Modify, Read and Write permissions.

2.	Navigate to ``<designer website folder>\InVisionServices\Data`` and open **DPDServiceConfig.Custom.xml** for editing.  
(Make sure you have at least write and modify permissions).

3.	Add the following line to the ScriptAssemblyReferenceCatalog element.
``<ScriptAssemblyReferenceCatalogItem LibraryName="Hypotesia BusinessLogic" AssemblyFile="Hypotesia.BusinessLogic.dll" Version="1.0"/>``  
(*If you copy this line into the xml file, make sure to fix the quotes*).

<br/>
Copying the .dll to the Worker Service folder enables executing your code in Data Flows, because Data Flows are executed by the Worker Service.

Copying the .dll to Designer website and registering it enables you to use it as part of your Solution and configure the execution.

Once you have everything set up, you can go ahead and build your project. If you have everything set up correctly, your code should be compiled into assemblies and copied to the two folders. Once that’s done, you can go to the Data Flow Item designer, add a reference to the assembly then create tasks using your classes and methods.
<br/><br/>

**Debugging code using Visual Studio**

Once a Class Library has been compiled into an assembly and deployed to the Worker Service, you can debug it from Visual Studio by attaching to the (Worker Service) process, **dfworker.exe**.

**Note!** In order to attach to the dfworker.exe process, make sure you’re running Visual Studio as Administrator.
<br/><br/>

**To attach to a process:**

1.	Go to **Debug (in the Visual Studio menu bar)** ->**Attach to Process…(*or Ctrl+Alt+P*)**. 

2.	In the list of Available Processes, find **dfworker**.exe and attach to it. If you cannot find dfworker.exe, enable **Show processes from all identities** below the list.

3.	Once you have successfully attached to the process, add break points to your code by pressing F9 or by clicking the left margin. Statements with break points are (normally) indicated by red circles in the left margin and a red background.

4.	Go to InVision and execute a Data Flow that calls your code. When your break points are hit, you can step through and debug your code as if you were running the .dll in your own process.
