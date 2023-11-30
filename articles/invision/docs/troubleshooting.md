
# Troubleshooting

## Q : I cannot open a Solution, because it does not exist in the list of Solutions in the start page

A : This probably means that you do not have access to the Solution using your current credentials. You need to contact your Solution administrator to be granted access.

If you are a Solution administrator, you can delete the contents of pbSolutionObjectACL in the Solution database, then refresh the browser. Open the Solution and add yourself as a user to the Solution from the Identities + Permissions menu in the application menu bar. Then you need to recompile the Access Control list.



## Q : I am getting an error message with a 405 MethodNotAllowed error when trying to install the license or activating the software.

A : This means that the web server does not accept all HTTP verbs, such as GET, PUT, POST, and DELETE.
The most likely cause for this is that WebDAV is installed, so you need to uninstall/turn the feature off.  
Note! WebDAV is used by Sharepoint, so you need to make sure that there are not Sharepoint sites running on the web server before you turn this feature off.

![Troubleshooting](https://profitbasedocs.blob.core.windows.net/images/troubleshooting2.jpg)
