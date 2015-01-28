
# StinkyPete - E-Form Browser

StinkyPete is a simple web browser using the same Microsoft IE7-based WebBrowser control used by Hyland OnBase* (pre-version 15) for displaying E-Forms in the thick client and the Unity client.

If you've ever created e-forms you know what this means: finally, you can reliably develop, test, and maintain HTML E-Forms outside of OnBase without jumping through hoops (or as many).

If you use it to browse real websites, expect to get frequent formatting and script errors, but that's the whole point!

\* StinkyPete is in no way affiliated with Hyland Software.


## Keyboard Shortcuts

```
     Back: Alt + Left Arrow
  Forward: Alt + Right Arrow
 Edit Url: Alt + D
       Go: Enter; Alt + G
  Refresh: Alt + R
     Home: Alt + H
     Stop: Alt + X
```

## Custom Home Page

Create a file called `home.html` and place it in the folder `resources` (same as `about.html`). It will be shown instead of the about page on start and when you use the Home button.

The file `home.html` is ignored by git.

## Keeping Everything Local

Odds are your E-Forms use external resources such as images, javascript files, and css loaded from a web server.

The easiest way to keep those resources on your local dev box without hassling with changing the references back-and-forth is to run a local web server and change the hostname to match the web server you reference. Then, modify your hosts file to redirect that name to your local web server. It's super easy with IIS.

## Deploying and Synchronizing with OnBase

My git deployment workflow isn't very fancy, but it's mostly automated.

I push local changes to GitHub and on the server I run a script that pulls from GitHub (through a proxy) and copies runtime files as needed. This takes care of resource files but HTML files still need to get into OnBase.

I have a Unity script that automatically imports only the changed HTML files as new SYS HTML Files. It spits out a list of the changed files that I then have to manually set as the new E-form for each associated Document Type (because Hyland's API doesn't provide a way to update the E-form for a Doc Type).

## Known Issues

- Ability to change focus with the tab key is sometimes lost after loading a page from the address textbox. Clicking a control re-enables tab key. Navigating to new pages using links has no negative effect.

## Potential Enhancements

- Live reload (automatically reload page when files change)
- Simulated Submit (see what keyword values would be)
- Debug tools
- Save/retrieve form element values for autofill
- Unit test integration
- Integrated web server
- Multiple tabs
- Better Keyboard Shortcuts
- Browsing history improvements
- Bookmarks


## Trademarks

All product and company names are trademarks™ or registered® trademarks of their respective holders. Use of them does not imply any affiliation with or endorsement by them.

OnBase® is a registered trademark of Hyland Software.

StinkyPete™ is an open-source project sponsored by [OneLink.net](http://www.onelink.net).

## License

StinkyPete is released under the [GNU GPL v3.0 License](http://opensource.org/licenses/GPL-3.0).
