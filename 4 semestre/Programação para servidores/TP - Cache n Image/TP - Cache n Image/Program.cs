using Microsoft.EntityFrameworkCore;
using TTP___Cache_n_Image

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapControllers();
app.UseStaticFiles();

app.Run();
