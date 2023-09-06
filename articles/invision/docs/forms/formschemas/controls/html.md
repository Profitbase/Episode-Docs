---
title: "Html"
metaKeys: "UI, Text Control, Controls, custom HTML, form schema, displaying information, text, images, "
pageIndex: 7
---

Inherits from [Control](control.md).

Lets you add custom HTML to the form schema. The primary use case for this feature is displaying information (text, images etc). InVision does not provide an API to the contents of the Html element, but you can of course use the standard browser / DOM API if you want to.

**Example**

```xml
    <Html Row="11" Column="1">
    <span class="bold">
            Hello from html!
        </span>
    </Html>
```
