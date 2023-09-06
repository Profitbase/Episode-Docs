---
title: "Package Properties"
metaKeys: "package property, the returned, "
pageIndex: 2
---



### Package Properties

<br/>

A package property can be defined inside of a Package. 
 
There are ten supported property types. They are listed here:

<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/packageProperties1.jpg)

<br/>

### Defining a package property

>The default value is the returned value if the solution is not part of a version. 

<br/>

**Example**    

<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/packageProperties2.jpg)

<br/>




### Use PackageProperty in a Sql script

<br/>

**@PackageProperty[PropertyName] in a Sql script** 

 
>A package property value can be used inside a Sql script. 
>
>The returned value is a string representation of the data type. Example of use can be:

```
@PackageProperty[Profitbase.PackagePropTests.Planning.StartDate].DateExpr
```

<br/>

**Example**  
  
>You may want to filter data based on a package property value. 

<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/packageProperties3.jpg)

<br/>

**Note!**  
>@PackageProperty[name].DateExpr is recommended for casting package properties to datetime.

<br/>


```
@PackageProperty[Profitbase.PackagePropertyTests.DateTime].DateTimeOffsetStr
```

```
@PackageProperty[Profitbase.PackagePropertyTests.DateTime].DateTimeUtcStr
```

<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/pkprp1.png)

<br/>

### Use PackageProperty in a PowerShell script

<br/>

**@PackageProperty[PropertyName] in a PowerShell script**

>A package property value can be used inside a PowerShell script. 
>
>The returned value is a string representation of the data type. Example of use can be:

```
$date = 
[datetime]::ParseExact('@PackageProperty[Profitbase.PackagePropTests.Planning.NationalHoliday].DateStr',"yyyyMMdd",[Globalization.CultureInfo]::InvariantCulture)
Write-Output $date.Year
```
<br/>

**Example**  
 
Here is an example of use in PowerShell script. 

<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/packageProperties4.jpg)

<br/>

**Note!**  
>@PackageProperty[name].DateStr is recommended for getting yyyyMMdd formatted representation of date/datetime package properties.

<br/>


```
 $datetimeoffset = 
[datetimeoffset]::ParseExact('@PackageProperty[Profitbase.PackagePropertyTests.DateTime].DateTimeOffsetStr',"yyyyMMdd HH:mm:ss zzz",[Globalization.CultureInfo]::InvariantCulture)
Write-Output $datetimeoffset
```
<br/>

```
$datetimeutc = 
[datetime]::ParseExact('@PackageProperty[Profitbase.PackagePropertyTests.DateTime].DateTimeUtcStr',"yyyyMMdd HH:mm:ss",[Globalization.CultureInfo]::InvariantCulture)
Write-Output $datetimeutc
```

<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/pkprp2.png)

<br/>


### Use Directive in a worksheet column expression

<br/>

**Directive("@PackageProperty[PropertyName]") in a worksheet column expression** 

>A package property value can be used inside a worksheet column’s Is Hidden Expression (Caption Expression and Is Read Only Expression is also supported).
>
>The returned object can be cast to a proper data type. Example of use can be:

```
((DateTime)Directive("@PackageProperty[Profitbase.PackageName.Planning.StartDate]")).Year == 2020
```

<br/>

**Example**  
 
>Here is an example of use in a worksheet column Is Hidden Expression. 

<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/packageProperties5.jpg)

<br/>

```
((DateTimeOffset)Directive("@PackageProperty[Profitbase.PackagePropertyTests.DateTime]")) == new DateTimeOffset(new DateTime(2021, 8, 19, 16, 0, 0), new TimeSpan(2, 0, 0))
```

<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/pkprp3.png)

<br/>

### Use PackageProperty in a data flow

<br/>

**Use @PackageProperty in a data flow**

>A package property value can be utilized as a parameter value in a data flow.
>
>The returned value can be cast to the proper data type. 

**Example**

>Adding a PowerShell script with a parameter decalaration.

<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/packageProperties6.jpg)

<br/>

### Adding a data flow item parameter

<br/>

**With @PackageProperty[PropertyName] as Default Value**

<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/packageProperties7.jpg)

<br/>

**Note!**  
>Use @PackageProperty[name].DateStr when dealing with dates to ensure culture invariant datetime parsing.

<br/>

### Mapping the parameters in the Run PowerShell Script Arguments section

<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/packageProperties8.jpg)

<br/>

### Executing the data flow to test that the parameter is parsed OK

<br/>

![PK](https://profitbasedocs.blob.core.windows.net/images/packageProperties9.jpg)



### Videos

* [Packages](../../../../videos/packages.md)
* [Package Properties](https://profitbasedocs.blob.core.windows.net/videos/Package%20-%20Package%20Properties.mp4)
  