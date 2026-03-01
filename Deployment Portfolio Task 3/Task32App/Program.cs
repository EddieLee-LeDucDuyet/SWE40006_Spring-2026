var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Simple endpoint for Task 3.2
app.MapGet("/", () => "Hello from my Task 3.2 C# web app on Azure (Windows)!");

app.Run();