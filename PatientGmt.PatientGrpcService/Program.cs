using Microsoft.EntityFrameworkCore;
using PatientGmt.PatientGrpcService.Services;
using PatientMgmt.Infrastracture.Abstractions;
using PatientMgmt.Infrastracture.EF;
using PatientMgmt.Infrastracture.EF.Patients;
using PatientMgmt.Services;
using PatientMgmt.Services.Abstractions;
using Steeltoe.Discovery.Client;
using Steeltoe.Extensions.Configuration.ConfigServer;

var builder = WebApplication.CreateBuilder(args);

// Add Steeltoe Discovery Eureka for service registration
builder.Services.AddDiscoveryClient(builder.Configuration);
// Add services to the container.
builder.Services.AddGrpc();

// Add configuration from Spring Cloud Config Server
builder.Configuration.AddConfigServer();

// Register the service
builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();

builder.Services.AddHttpClient<IAppointmentService, AppointmentService>();

// Configure the DbContext with the connection string from appsettings.json
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// You can now access the configuration values
var configValue = builder.Configuration["spring.cloud.config.uri"];

Console.WriteLine($"Config Value: {configValue}");
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<PatientServiceGrpc>();
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();