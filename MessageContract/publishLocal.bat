msbuild Message.Contract.csproj /target:Rebuild /property:Configuration=Debug
nuget pack Message.Contract.csproj -Symbols -Prop Configuration=Debug
move *.nupkg C:\LocalNuget

 