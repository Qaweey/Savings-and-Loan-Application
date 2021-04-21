#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SavingandLoanProject/SavingandLoanProject.csproj", "SavingandLoanProject/"]
RUN dotnet restore "SavingandLoanProject/SavingandLoanProject.csproj"
COPY . .
WORKDIR "/src/SavingandLoanProject"
RUN dotnet build "SavingandLoanProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SavingandLoanProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SavingandLoanProject.dll"]