FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

# Copy project file
COPY ["LongestIncreasingSubsequence.csproj", "./"]

# Restore dependencies
RUN dotnet restore "LongestIncreasingSubsequence.csproj"

# Copy source code
COPY . .

# Publish application
RUN dotnet publish "LongestIncreasingSubsequence.csproj" \
    -c Release \
    -o /app/publish \
    /p:UseAppHost=false


FROM mcr.microsoft.com/dotnet/runtime:8.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "LongestIncreasingSubsequence.dll"]