![.NET Core](https://github.com/aimenux/StringCliDemo/workflows/.NET%20Core/badge.svg)
# StringCliDemo
```
Playing with net core global tools
```
> In this demo, i m building a dummy global cli tool that allows to manipulate string texts
>
> The tool is based on one main command and three sub commmands :
> - Use sub command `PalindromeStringCli` to check if text is palindrome
> - Use sub command `ReverseStringCli` to reverse text
> - Use sub command `SortStringCli` to sort text
>
> In order to run the demo, type the following commands in your favorite terminal : 
> - `.\App.exe PalindromeStringCli "TEXT"`
> - `.\App.exe ReverseStringCli "TEXT"`
> - `.\App.exe SortStringCli "TEXT"`
>
> To install, run, uninstall global tool from a local source path, type commands :
> - `dotnet tool install -g --add-source ./app/cli-tools string-cli`
> - `string-cli -h`
> - `dotnet tool uninstall string-cli -g`

**`Tools`** : vs19, net core 3.1