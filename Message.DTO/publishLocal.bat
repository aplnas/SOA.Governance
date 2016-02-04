msbuild Message.DTO.csproj /target:Rebuild /property:Configuration=Debug
nuget pack Message.DTO.csproj -Symbols -Prop Configuration=Debug
move *.nupkg C:\LocalNuget

 