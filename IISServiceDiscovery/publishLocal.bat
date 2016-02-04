msbuild IISServiceDiscovery.csproj /target:Rebuild /property:Configuration=Debug
nuget pack IISServiceDiscovery.csproj -Symbols -Prop Configuration=Debug
move *.nupkg C:\LocalNuget

 