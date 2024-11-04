
# InVision 4.0 change log

<br/>


## Installing InVision 4.0

To install InVision 4.0 on your local PC or on a server / VM, you need to do the following

1. Contact Profitbase to get a license id.
2. Make sure you have PowerShell 5.1 and IIS .Net core hosting bundle installed.
3. Download and install Profitbase Installation Manager 4.
4. Follow the instructions in the installation guide.

You can download Profitbase Installation Manager 4 from [here](http://download.profitbase.com/installer/) or run the following Powershell command:

```
Invoke-WebRequest -Uri “https://download.profitbase.com/installer/ProfitbaseInstallationManager v4.0.0.0.exe” -Outfile “ProfitbaseInstallationManager v4.0.0.0.exe”; Start-Process ("ProfitbaseInstallationManager v4.0.0.0.exe")
```

<br />

## Upgrading to InVision 4

Because we’ve moved to a new technology platform, you cannot automatically upgrade to InVision 4.0 from previous versions just by clicking the “Upgrade” button in the installer. Depending on which features you have used in your Solution(s), there are a few manual steps involved.

Read the detailed steps about how to upgrade to InVision 4 here.

<br />

## New features

The focus for this release has been on moving to a new, modern technology platform. We have, however, found the time to add a few new features to please y’all.

<br />

### Time Dimension

We’ve added support for creating and managing Time Dimensions directly in InVision without having to use Profitbase Studio.

<br />

### Monitoring and diagnostics through Application Insights

We’ve added support for sending telemetry information to Application Insights to enable IT departments to include InVision in their standard operations and monitoring tools and processes.
This feature is enabled by default, and sends telemetry information to Profitbase unless you change the instrumentation key during installation or manually at a later point by editing the appsettings.json configuration files.

<br />

### Change Workbook Title dynamically

You an now dynamically change the Workbook Title at any time after the Workbook has been loaded by calling the SetWorkbookTitle(…) command in Execute actions on the Workbook object.

<br />

## Bug fixes

Version 4 contains more than 50 bug fixes from version 3. Many of them were reported through our support site / user forum, and we appreciate all feedback that help us improve the product.

<br />

## What’s next

Now’s where the fun begins! The last year+ has been spent on porting our entire software platform from “legacy” to a modern technology stack. This has prevented us from delivering new features and capabilities to partners and customers that help them unleash business value faster. For the next year, we’ve lined up a range of exiting new features that we know will provide great value and help you exceed your customers expectations.



<br />

### See Also

- [Change Log 2024.4](changelog24_4.md)
- [Change Log 2024.3](changelog24_3.md)
- [Change Log 2024.2](changelog24_2.md)
- [Change Log 2024.1](changelog24_1.md)
- [Change Log 2023.7](changelog23_7.md)
- [Change Log 2023.6](changelog23_6.md)
- [Change Log 2023.5](changelog23_5.md)
- [Change Log 2023.4](changelog23_4.md)
- [Change Log 2023.3](changelog23_3.md)
- [Change Log 2023.2](changelog23_2.md)
- [Change Log 2023.1](changelog23_1.md)
- [Change Log 2022.5](changelog22_5.md)
- [Change Log 2022.4](changelog22_4.md)
- [Change Log 2022.3 pt 2](changelog22_3_2.md)
- [Change Log 2022.3 pt 1](changelog22_3_1.md)
- [Change Log 2022.2](changelog22_2.md)
- [Change Log 2022.1](changelog22_1.md)
- [Change Log 5.2](changelog52.md)
- [Change Log 5.1](changelog51.md)
- [Change Log 5.0](changelog5.md)
- [Change Log 4.1](changelog41.md)
