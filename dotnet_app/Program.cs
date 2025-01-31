var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var app = builder.Build();

app.MapGet("/hello", () =>
{
    var message = "Hello, World!";
    return new { message };
});

app.Run();