# Book API

## Development

```
dotnet watch -p BookApi run
```

## Tests

```
dotnet test BookApi.Tests
```

## Production

```
dotnet publish BookApi -c Release -o out
dotnet ./BookApi/out/book-api.dll
```

## Dockerize

```
docker build -t book-api .
docker run -dit --name book-api -p 5000:80 book-api
```
