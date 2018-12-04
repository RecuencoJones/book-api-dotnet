# Book API

## Development

```
dotnet watch run
```

## Production

```
dotnet publish -c Release -o out
dotnet ./out/book-api.dll
```

## Dockerize

```
docker build -t book-api .
docker run -dit --name book-api -p 5000:80 book-api
```
