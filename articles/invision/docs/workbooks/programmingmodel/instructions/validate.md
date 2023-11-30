# Validate(...)

<br/>

```
Validate(terminateOnValidationFailed : boolean | Eaze expression)
```

**Validate(…)** can be executed in the SaveData Action for Worksheets.

 Run it if you want to run the Cell Validation rules before data is saved, and optionally prevent the save process for the particular Worksheet from executing if the validation fails.

>**Note** that validation errors do not prevent subsequent Actions and Action Groups from executing.

If you want to ensure that absolutely no actions can occur unless all Worksheets in the Workbook passes validation, you need to create an Action Group from which you execute the **ValidateDataAction** for all Worksheets.  
If one validation fails, no subsequent actions will execute in that event scope. 