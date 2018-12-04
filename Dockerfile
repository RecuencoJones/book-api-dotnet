FROM microsoft/dotnet:aspnetcore-runtime

WORKDIR /app

COPY ./BookApi/out .

ENTRYPOINT ["dotnet", "BookApi.dll"]
