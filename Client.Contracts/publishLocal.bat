msbuild Client.Contracts.csproj /target:Rebuild /property:Configuration=Debug
nuget pack Client.Contracts.csproj -Symbols -Prop Configuration=Debug
move *.nupkg C:\LocalNuget

 