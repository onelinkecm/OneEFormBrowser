

## Developer Tools
- http://stackoverflow.com/questions/1917314/is-there-a-way-to-enable-the-ie8-developer-tools-from-inside-webbrowser-control-i
- IE Dev Tools not possible
- Listening for browser errors
```cs
//peusdo code
  webBrowser.DocumentCompleted += (o, e) =>
  {
    webBrowser.Document.Window.Error += (w, we) =>
    {
      we.Handled = true;

      // Do something with the error...
      Debug.WriteLine(
        string.Format(
          "Error: {1}\nline: {0}\nurl: {2}",
          we.LineNumber, //#0
          we.Description, //#1
          we.Url));  //#2
    };
  };
```

## Icon
http://commons.wikimedia.org/wiki/File:Gold_prospector.jpg
