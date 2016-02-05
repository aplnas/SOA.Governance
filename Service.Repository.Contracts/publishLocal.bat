msbuild Service.Repository.Contracts.csproj /target:Rebuild /property:Configuration=Debug
nuget pack Service.Repository.Contracts.csproj -Symbols -Prop Configuration=Debug
move *.nupkg C:\LocalNuget

 