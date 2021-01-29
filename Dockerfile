  FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
  #COPY bin/Release/netcoreapp3.1/publish/ App/
  COPY out/ App/
  WORKDIR /App
  ENTRYPOINT ["dotnet", "recipositoryApi.dll"]