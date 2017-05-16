#Contensive Developer Samples#

##4.1 Aspx Sample##

This AspxSample solution is used to create new aspx sites for Contensive. The aspx pattern is different than the previous asp and php patterns. 
For aspx sites, add an aspx website to the visual studio solution. For custom projects creating a single solution, use this sample as the website 
project within the overall solution. For addon collections that will be shared with other applications, use this as thebasis for the development site

##Create a New Site##
To create a new site, start by creating an asp based site with the Contensive Manager and convert from asp to aspx.
1. Start Contensive Application Manager
2. Right click on the server and click add "Add/Import Site"
3. Set the name, and set the "type of site" and "asp" (not aspx). click through the rest of the default values and wait for the icon to turn green
4. Open IIS and open the Application Pool created for the site. Go to advanced properties and enable 32-bit applications

##Convert an asp site to an aspx site##
1. Check out the GitHub ContnesiveDevSamples and Open the aspxSite Visual Studio Solution
2. Open the project's web.config and add the application name for your development site.
3. Right click on the project and publish to the wwwRoot of your new website
4. Open a browser and go to http://siteName/admin/setup.aspx to initialize the aspx site properties
4. Open a browser and go to http://siteName to verify the site is running correctly
5. Go to windows explorer and delete any asp and php pages in the root and admin folders. Delete the /includes folder.

##Create a Visual Studio project template from the aspxSample##
1. Open the aspxSite solution and click file-Export Templte. Create a project template


