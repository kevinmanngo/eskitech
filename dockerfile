FROM mcr.microsoft.com/dotnet/runtime:5.0
WORKDIR /app
COPY ./tommy/eskitech .
CMD ["dotnet", "myapp.dll"]
