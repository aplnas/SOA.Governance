msbuild Service.Core.csproj /target:Rebuild /property:Configuration=Debug
nuget pack Service.Core.csproj -Symbols -Prop Configuration=Debug
move *.nupkg C:\LocalNuget

 