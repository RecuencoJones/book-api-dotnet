FROM microsoft/dotnet:aspnetcore-runtime

WORKDIR /app

COPY ./out .

ENTRYPOINT ["dotnet", "book-api.dll"]
