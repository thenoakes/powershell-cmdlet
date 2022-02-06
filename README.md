Build to `bin`
```shell
dotnet build
```

Then just import the resulting dll and run it for testing purposes

```powershell
Import-Module ./bin/Debug/netstandard2.0/powershell.dll # Will expose Get-Sample command
Get-Sample 2
```
https://docs.microsoft.com/en-us/powershell/scripting/dev-cross-plat/writing-portable-modules?view=powershell-7.2