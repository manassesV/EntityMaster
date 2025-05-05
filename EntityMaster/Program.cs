using EntityMaster;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register the DbContext using connection string
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=socialNetwork;Integrated Security=True"));

var app = builder.Build();

// Optional: Add middleware or routes if you're building an API
app.MapGet("/", () => "EF Core is configured!");

app.Run();