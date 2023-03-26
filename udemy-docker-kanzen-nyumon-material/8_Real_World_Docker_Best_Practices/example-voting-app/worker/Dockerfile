# ビルドステージ
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder

WORKDIR /Worker
COPY src/Worker/Worker.csproj .
RUN dotnet restore

COPY src/Worker/ .
RUN dotnet publish -c Release -o /out Worker.csproj

# アプリケーションイメージ
FROM mcr.microsoft.com/dotnet/runtime:6.0
#FROM mcr.microsoft.com/dotnet/aspnet:6.0
#FROM mcr.microsoft.com/dotnet/core/runtime:3.1

WORKDIR /app
ENTRYPOINT ["dotnet", "Worker.dll"]

COPY --from=builder /out .
