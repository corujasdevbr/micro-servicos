FROM microsoft/dotnet:2.2-aspnetcore-runtime AS build-env

LABEL version="1.0" maintainer="Senai Vagas"

WORKDIR /app

# Build da aplicacao
COPY ./dist .
RUN dotnet publish -c Release -o out

# Build da imagem
FROM microsoft/aspnetcore:2.2-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "CorujasDev.Vagas.Web.Api.dll"]
