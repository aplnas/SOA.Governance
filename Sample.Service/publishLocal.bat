msbuild Service.csproj /target:Rebuild /property:Configuration=Debug
nuget pack Service.csproj -Symbols -Prop Configuration=Debug
move *.nupkg C:\LocalNuget

 