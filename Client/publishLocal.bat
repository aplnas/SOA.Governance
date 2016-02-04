msbuild Client.csproj /target:Rebuild /property:Configuration=Debug
nuget pack Client.csproj -Symbols -Prop Configuration=Debug
move *.nupkg C:\LocalNuget

 