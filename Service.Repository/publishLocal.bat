msbuild Service.Repository.csproj /target:Rebuild /property:Configuration=Debug
nuget pack Service.Repository.csproj -Symbols -Prop Configuration=Debug
move *.nupkg C:\LocalNuget

 