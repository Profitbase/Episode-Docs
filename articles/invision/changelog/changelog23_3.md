

# InVision 2023.3 change log

<br/>

InVision 2023.3 introduces a diffing tool to view and compare all changes to any Solution object + a few other minor improvements.

<br/>

### Change tracking and diffing

We have added support for viewing any changes made to objects a Solution. To view changes, right-click the object in the Solution Explorer and open the Change log.

- You can see when changes to Solution objects were made, and who made the changes.
- You can compare two versions of an object, and pinpoint exactly what was changed.
- If you select a Package, you can see which objects in a Package were changed between two points in time, for example between two Package upgrades.
- You can right-click a Solution object in the Solution Explorer and view all changes to descendant objects.

![Diff tool](https://profitbasedocs.blob.core.windows.net/images/difflog.png)

<br/>

### Form Schemas

We have added an API for running Web Functions from Forms Schemas. This makes it easier to run backend code directly from Forms, without using the native browser API where you have to provide the Web Function url and authentication headers manually.

```javascript
const result = await this.webFunctions.execute("CalculateResult", {
  a: 100,
  b: 200,
});
console.log("100 + 200 is " + result);
```

### Misc fixes

- Fixed an issue where the search result list in filters wrapped items with long names onto new lines instead of showing a horizontal scroll bar.
- Fixed an issue with generation of compound views during Package upgrade and deployment caused by invalid or missing view source tables.

### See Also

- [Change Log 2024.3](changelog24_3.md)
- [Change Log 2024.2](changelog24_2.md)
- [Change Log 2024.1](changelog24_1.md)
- [Change Log 2023.7](changelog23_7.md)
- [Change Log 2023.6](changelog23_6.md)
- [Change Log 2023.5](changelog23_5.md)
- [Change Log 2023.4](changelog23_4.md)
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
- [Change Log 4.0](changelog40.md)

<br/>

