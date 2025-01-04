# Convert spreadsheets to Profitbase web apps

To address shortcomings of spreadsheets, consider moving to web apps with data stored in a central database for any of the following reasons:   
#### 1. Enable distributed input with multiple contributors

#### 2. Apply security and access control
  

#### 3. Versioning and revisions

#### 4. Automate consolidation and reconciliacion

#### 5. Handle large and complex models
**Data size**  
When using spreadsheets like Excel or Google Sheets, there is a limit to the size of how large models can be. When the become too large, they take a long time to load, or simply will not load at all.

Profitbase Web apps does not have this limitation, as data is stored in a database and all heavy data processing is done on the backend. Only the data that a user needs to see is loaded to the UI, which is a very small part of the entire model.

**Complexity**  
The business logic in (large) spreadsheets is hard to understand because it is comprised of a web of formulas and cell addresses with "meaningless" names. You have to jump back and forth between cells and sheets to understand what is going on, and you quickly loose track of where you are and what you are looking at. Also, the inability to document what you are doing and effectively test formulas or parts of the model in isolation, makes building and maintaing complex spreadsheets hard.

In Profitbase web apps, the business logic and the rendering of the data is split between code and UI. This is somewhat similar to using VBA in Excel to do calculations, but still very different because you are operating on _data_ and not cell or sheet _addresses_. Effectively, this means that you can read the business logic as a document top to bottom, left to right, without switching context. Also, because the business logic is expressed with code, calculations are easier to understand because they contain meaningful names instead of cell addresses.

##### Example

Profitbase formula:  
```csharp
Model.SalesAmount = Input.Amount + Input.Amount * Parameters.VAT;
```

Equivalent Excel formula (what F3 and Parameters!B2 refers to is not immediately obivious):
```excel
=F3+F3*Parameters!B2
```

#### 6. Ensure consistency and reliability
If you share spreadsheets via email or file shares, can you be confident that users does not accidently modify or delete formulas, breaks links or data source connections? Can you be sure you are getting back the same version of the spreadsheet that you sent out? Can you be sure  everyone is using the same assumptions and parameters?

Profitbase Web apps does not enable end users to edit formulas, data connections or business logic. Only power users are allowed to do this. End users can only edit _data_ through a simple to use web interface, where data is retrieved and saved to a central database. The built-in access control system ensures that users only see what they are allowed to see, and only has access to their data. This ensures that everyone is using the current model, assumptions and parameters, calculations, and that data is updated in real-time to the central repository as users provides input.

#### 7. Eliminate key person dependency
Only a single person fully understands the spreadsheet model, and they are the only one who can make changes without risking breaking it. What if this person leaves the company or becomes unavailable for any reason?  

Considering Profitbase web apps are also built by people, the main difference is the tools and technology used to build the solutions as described [above](#5-large-and-complex-models). The tools makes the models easier to understand, maintain, and modify by others besides the original author, effectivly eliminating dependency on a single person.  




