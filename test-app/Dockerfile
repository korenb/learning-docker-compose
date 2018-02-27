FROM microsoft/aspnetcore-build:2.0 AS builder
WORKDIR /src
COPY *.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish --configuration Release --output /app

FROM microsoft/aspnetcore:2.0
WORKDIR /app
ENV ASPNETCORE_URLS=http://0.0.0.0:5000
EXPOSE 5000
COPY --from=builder /app .
ENTRYPOINT ["dotnet", "test-app.dll"]
