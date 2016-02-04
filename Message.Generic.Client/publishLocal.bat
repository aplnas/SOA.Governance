
msbuild Message.GenericClient.csproj /target:Rebuild /property:Configuration=Debug
nuget pack Message.GenericClient.csproj -Symbols -Prop Configuration=Debug
move *.nupkg C:\LocalNuget

 