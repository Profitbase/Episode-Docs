---
title: "Initializing From URL"
metaKeys: "Initializing from URL (query string)"
folderOnly: "false"
pageIndex: 2
---


**Initializing from URL (query string)**

A [Workbook](../../workbooks.md) can be initialized from the url using parameters in the query string.

The values of the query string parameters can be accessed from special variables in the Workbook.

When the Workbook loads, variables are created from the query string of the url. The variables are created using a naming convention by prepending the parameter name with a "QSP::"-token.

For example, if the url of the Workbook is ``http://site/invision/workbook/default.aspx?test=123&a=45``, two variables will be created:

        @Var[QSP::test] = 123;

        @Var[QSP::a] = 45;
