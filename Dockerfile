# Use the ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app
EXPOSE 5065

# Copy the published files to the container
COPY ./publish ./

# Command to run the gRPC service
CMD ["dotnet", "PatientGmt.PatientGrpcService.dll"]
