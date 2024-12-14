using PatientMgmt.PatientGrpcService.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc(options =>
{
    options.EnableDetailedErrors = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<PatientService>(); // Le service PatientService est mappé à gRPC

app.Run("http://localhost:5000"); // Le serveur gRPC écoute sur http://localhost:5000