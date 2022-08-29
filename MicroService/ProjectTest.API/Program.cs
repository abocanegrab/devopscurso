var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.


app.MapGet("/", () =>
{
    app.Logger.LogInformation("Initial Home Get");
    return "Prueba aaron";
});

app.MapPost("/", () =>
{
    app.Logger.LogInformation("Initial Home Post");
    return "POST - Net 6 Running ... 22042022-v1.0.0 CI/CD in AKS v1.0.0 AFORO255";
});

app.Run();

