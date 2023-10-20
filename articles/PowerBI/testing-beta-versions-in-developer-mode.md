To test it without affecting any reports in production, I would recommend that you have a copy/duplicate file of the current production file.. Then use Developer Mode in Power BI Desktop, and importing the visual from file. 

**Do not save the file while testing!**

When you close without saving, and reopen the current report, it will revert back to the AppSource version. 


**Steps:**
1. Turn on Developer Mode:

![image](https://user-images.githubusercontent.com/82056309/211809276-9e45ff6c-542a-4532-8515-978184561635.png)

2. Import Visual From File:

![image](https://user-images.githubusercontent.com/82056309/211809373-80a4f603-8ac9-4eb3-89c4-f4cad4731797.png)


3. Then select the downloaded visual file.



**Important notes:**

* If you find any bugs, or anything in your existing reports should break, please let us know in the comments or @ [pbi.visuals@profitbase.com](mailto:pbi.visuals@profitbase.com)
* If anything breaks, close your report without saving, and all should be fine once you reopen the report.
* Developer mode is a temporary setting, that will be set to OFF again once you close your report.

**After successful testing:**
If all works as expected, and you want to continue using this version, you can upload the same visual file to Org.Store:
https://docs.microsoft.com/en-us/power-bi/admin/organizational-visuals#add-a-visual-from-a-file