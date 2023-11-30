
# Work Process Configuration

## Content

The content defines the blueprint of the Work Process. It specifies the Workbooks where the identities will do their work. The Workbooks that you select will appear directly in the Workbook Menu. The other Workbooks in the same Package(s) will also be available, but they will not appear in the Workbook Menu.

When a Version is created, a new copy of every Package in the blueprint is created and added to a new Solution. If the blueprint contains more than one Package from the same Solution, they will all be placed together in the new Solution. This means that you can create your Packages that extend the functionality or reference objects in other Packages and deploy them together in Work Processes.
<br/>

## Menu positioning

You need to position the Work Process in the Workbook Menu. If you don't, it will appear in a random place at the root level. 

Versions and Workbooks will automatically appear under the Work Process in the menu. Availability of Versions and Workbooks is based on user permissions. The logged-in user will only see the Workbooks they have access to. If the logged-in user does not have access to any Workbooks, the user will not see a menu item for the Version.
<br/>

## Administrators

[Work Process administrators](howto/clientside.md) determine the following:

1. Which identities have access to the Work Process in the Work Process editor
2. Which identities can access Workbooks and Versions that are in the **Deployed** state.

Work Process administrators can be either specific identities or access groups.
<br/>

## Translations

You can specify a translation for the name of the Work Process for each of the languages defined in the system. 

The translated name will appear in the Workbook Menu and on the default homepage.
