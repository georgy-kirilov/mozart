var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogging();

var app = builder.Build();

app.MapGet("/", () =>
{
    Console.WriteLine("Endpoint has been hit.");
    return "Hello World";
});

app.Run();
