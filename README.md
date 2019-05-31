# PDF Generator for Sitecore

Welcome to PDF Generator for Sitecore, a project that allows you to render PDF's from any Sitecore Page.

This project adds a MVC route:  "/pdf/{ID} where ID is mapped ot the GUID of the item you wish to render into PDF. 

The controller will make a webrequest to the web url of the page associated with the guid, and do so using the same cookies of the calling request, which should allow Sitecore to apply any personalization rules to the page the same as if they requested the page themselves.

This supports a number of useful optional parameters including:

* name - file name of the PDF to serve. (Makes it download instead of open)
* landscape - presence of this parameter indicates the pdf should be rendered as landscape
* size - Rotiva Enum value for page Size. A0 - A9, B0 - B10, Letter, Legal, Tabloid, Ledger, Folio, Executive, C5E, Com10E, Dle
* width - width of the page
* height - height of the page
* nomargin - presence of this sets the margins to 0
* ignoreCookies - if included, will not pass visitors cookies to webrequest (bypasses Sitecore's personalization)
* dss - presence of this sets the wkhtmltopdf options to disable smart shrinking

# Examples

Render the Default Home Page as a plain PDF:

http://pdf.dev.local/pdf/%7B110D559F-DEA5-42EA-9C1C-8A5DF7E70EF9%7D

Render it with a fileName having it download instead of open in a browser.

http://pdf.dev.local/pdf/%7B110D559F-DEA5-42EA-9C1C-8A5DF7E70EF9%7D?name=HomePage

Render it using a Legal Page Size

http://pdf.dev.local/pdf/%7B110D559F-DEA5-42EA-9C1C-8A5DF7E70EF9%7D?size=Legal

Render it Landscape and disable smart shrinking

http://pdf.dev.local/pdf/%7B110D559F-DEA5-42EA-9C1C-8A5DF7E70EF9%7D?landscape=y&dss=y

# Disclaimer

This leverages the open source library Rotativa which uses wkhtmltopdf tool. 

PDF generation can be fairly resource intensive, so ensure you have enough capacity to support this on your server if you expect a heavy load of pdf requests. 

You may need to consider to offloading PDF generation to another farm or leveraging a cloud based SaaS tool instead.