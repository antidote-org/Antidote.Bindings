# Collection of Fable and Feliz bindings! :heart:
Github Repo [link](https://github.com/antidote-org/Antidote.Bindings)

## Overview

This is the collection of bindings currently being developed and used for our Antidote-AI tools.


## Installation

```
## using nuget
dotnet add package Antidote.Bindings
```

## or with paket

```
paket add Antidote.Bindings --project /path/to/project.fsproj
```


## To publish

*For maintainers only*

```ps1
cd Fable.Form.Antidote
dotnet pack -c Release
dotnet nuget push .\bin\Release\Antidote.Bindings.X.X.X.snupkg -s nuget.org -k <nuget_key>
dotnet nuget push .\bin\Release\Antidote.Bindings.X.X.X.nupkg -s nuget.org -k <nuget_key>
```
