# Dropbox Explorer

Frustratingly, the Dropbox web interface doesn't allow you to see the sizes of folders. The only way to do this is to sync all your files locally and use your local file browser to get recursive directory information. This isn't very helpful if you're storing a lot of data and using Selective Sync locally to avoid having to download everything.

Dropbox Explorer is a simple Winforms app that uses the Dropbox API to query and aggregate this information.

I created this quickly to get around my issue - it's not the most amazing user interface - I just wanted something usable.

## Usage

To use this, you'll have to create a Dropbox application and generate an access token ...

* Log on to your Dropbox account and go to http://www.dropbox.com/developers
* Click on 'Create your app'
* Choose 'Dropbox Api'
* Choose 'Full dropbox'
* Give your app a name - this can be anything you want
* Click 'Create app'
* Click 'Generate access token', and make a note of this access token

You can now use this access token in Dropbox Explorer ...

* Install and run Dropbox Explorer
* Paste your access token into the 'Access Token' text field
* Click on 'List Directory Structure' - this will show your directory listing
* Double click on a directory to expand it if required
* Select a directory, and click 'Get Folder Size' to get the folder size recursively

## Known issues

* Auth token isn't persisted
* Need to improve error handling
* Need a better user interface
