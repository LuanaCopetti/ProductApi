using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure database
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite("Data Source=products.db");
});

var app = builder.Build();

// ...

app.Run();
