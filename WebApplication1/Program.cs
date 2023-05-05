using WebApplication1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<Middleware>();

app.MapGet("/", () => "Hello World from net7!");

app.Run();
