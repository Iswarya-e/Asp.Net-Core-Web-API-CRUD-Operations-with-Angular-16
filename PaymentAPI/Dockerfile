FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
COPY /PaymentAPI .
RUN dotnet restore
RUN dotnet publish -c Release -o ddls


FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/ddls .
EXPOSE 8081
CMD ["dotnet", "PaymentAPI.dll"]