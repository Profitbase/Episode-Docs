
# Component placeholder

Developers can now specify placeholders (also known as skeletons) for Workbook components. When specified, the placeholder will render as a preview of the actual component until it is loaded. We currently support two types of placeholders:

Animating skeleton. This placeholder does what the name suggests – it displays an animating skeleton until the component has loaded.

Static skeleton. This placeholder looks the same as the animating skeleton, but without animation. You should use placeholders when a component is displayed on a page, but not immediately loaded. This will improve the user experience by providing early feedback that work is in progress.

Placeholders are currently supported by the following components:

- Worksheets
- Tables
- SQL Reports
- Forms
<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/comp_placeholder_1.png)
<br/>

Select which placeholder to use for a Workbook component.
<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/comp_placeholder_2.png)

Placeholders are displayed until the components have finished loading.