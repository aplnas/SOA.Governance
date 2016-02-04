msbuild Infrastructure.Contracts.csproj /target:Rebuild /property:Configuration=Debug
nuget pack Infrastructure.Contracts.csproj -Symbols -Prop Configuration=Debug
move *.nupkg C:\LocalNuget

 