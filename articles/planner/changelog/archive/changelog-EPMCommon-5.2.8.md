---
title: "Changelog EPM Common 5.2.8"
metaKeys: "Changelog"
pageIndex: 86
---

**Changes:**

- Functionality for **setting up and stepping through so called Guides**. Guides are meant as helpers for more complex administrative operations covering multiple steps involving workbooks and operations. A guide can be set up to guide the user through these steps with textual (rich text) information and interactive links to the relevant workbooks and operations. Two workbooks are involved: Guide manager for setting up guides and Guides for accessing and stepping though available guides.
- A new workbook, **Solution documentation**, for documenting the solution and important decisions made during the implementation project is added. Contains two pages, one for Planner standard and one for customizations. (#478)

**Bug fixes and GitLab reference list**

- Operation Manager: System operations does not run in scheduled operations (#1203)
- Issues with Operations and Activity monitor (#1182)
- Execute Operation from any workbook - implement operation completed event (#1180)
- Operation: Creating new step in operation. Dropdown for scripts or dataflows must contain orign application/package. (#1178)


