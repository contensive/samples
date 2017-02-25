#Contensive 4.1 Aspx Sample#

This AspxSample solution is used to create new aspx sites for Contensive.

The aspx patten is different than the previous asp and php patterns. For aspx sites, add an aspx website to the visual studio solution. For custom projects creating a single solution, use this sample as the website project within the overall solution. For addon collections that will be shared with other applications, use this as thebasis for the development site

##Create a New Site##
To create a new site, start by creating an asp based site with the Contensive Manager and convert from asp to aspx.

##Convert an asp site to an aspx site##
1. Open the code's Visual Studio solution
2. Add new project titled "devSite" where AppName is the name of your contensive application. ( add > new project > select the devSite template created from the aspxSample repositor)
3. Open the new project's properties, and clear the root namespace
4. Open the new project's web.config and add the application name for your development site.
5. Create a publishing profile to deploy the new devSite to your development iis instance.
6. Build and publish the project.
7. Open IIS Manager
8. Set the default page to default.aspx
9. Set the error page's 404 page to /default.aspx
10. In the application pool, SEt the framwork to 4, and change the identity to applicationpool
11. Open a browser and go to the /admin site of your contnsive application. Open Settings > Preferences
12. In the admin tab, set the admin url's page to default.aspx
13. In the Page tab, set the default page to default.aspx and default landing to /default.aspx
14. Go to windows explorer and delete the asp and php pages in the root and admin folders. Delette the indluces folder.

##Create a Visual Studio project template from the aspxSample##
1. Clone the Contensive41AspxSample github repository
2. Open the solution and click file-Export Templte. Create a project template


