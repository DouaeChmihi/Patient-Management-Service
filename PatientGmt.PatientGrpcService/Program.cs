using Microsoft.EntityFrameworkCore;
using PatientGmt.PatientGrpcService.Services;
using PatientMgmt.Infrastracture.Abstractions;
using PatientMgmt.Infrastracture.EF;
using PatientMgmt.Infrastracture.EF.Patients;
using PatientMgmt.Services;
using PatientMgmt.Services.Abstractions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

// Register the service
builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();

// Configure the DbContext with the connection string from appsettings.json
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<PatientServiceGrpc>();
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();