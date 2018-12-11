# Contensive Developer Samples #

## Develop Addons ##

In the Contensive environment most development is creating addons. In the source folder are addon samples for vb (addonCollectionVb) and c# (addonCollectionCs).

## Create a New Back-end Site ##

A back-end site lets developers and administrators create and manager the database and filesystem used by an application.

1. Download and install the command line installation code at Contensive.io
2. Use the command line tool (cc.exe) to configure the database, filesystem, and cache. Use the command >cc --config
3. Create a new application using the command line tool. This step will also setup an IIS website (if you application uses a site.) Use the command >cc -new
4. To use the default IIS appplication, download it from Contensive.io. Open IIS, select the new site, right click, select Import and Import the DefaultIISSite.zip
5. Hit the site on the admin route (default = /admin). The default login is root/contensive

## Setup a new website front-end with the Page Manager addon ##

The default installation (Back-end site) routes traffic to the Page Manager Addon. Hit the root of the back-end site and turn on edit to create pages.

## Create an Addon to handle a route (a remote method) ##

The goal of this sample is to hit the route /testme and the application will reply "Hello World"

1. Log into the back-end, open the admin navigator, open Manage Add-ons, open Advances, click on Addons to see the list of addons
2. Click Add to create a new addon
  - name = testme
  - Content Tab, Content = Hello World
  - Placement Tab, check remote method
  - Hit save.
3. hit the url /testme and the response will be Hello World

## Add dot net code to an addon (remote method) ##

The goal of this sample is to write a dot net class, upload the assembly to an addon, hit the route for the addon