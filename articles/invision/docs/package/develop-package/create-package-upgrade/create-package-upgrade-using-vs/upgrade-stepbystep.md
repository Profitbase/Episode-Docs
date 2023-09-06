---
title: "Step by Step Guide"
metaKeys: "package property, the returned, Package Upgrade Template"
pageIndex: 1
---



### Modify the PackageUpgradeTemplate:


1. Set/check the the version attribute [PackageUpgrade("1.0.0","2.0.0")] in the V1ToV2Upgrader class in the V1ToV2 folder.
2. Add/paste a **.pbpck** file (i.e. named V1ToV2.pbpck) into the V1ToV2 folder.
3. Alt + click the **.pbpck** file to edit properties without opening the file.
4. Set the **"Build Action"** property to **"Embedded resource"**.
5. Edit the **packageheader.json** to set valid metadata for the upgrade package file. The **PackageId** can be copied using Invision Designer.


<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/PackDoc%20(2).png)

<br/>


6. Right click project file and click **Build** in Release mode.
7. Now you can find the .pckup file in the **{ProjectPath}\bin\Release\net5.0** folder.  

