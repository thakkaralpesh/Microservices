using Microsoft.EntityFrameworkCore;
using PlatformService.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(opt =>
{
   opt.UseInMemoryDatabase("InMem"); 
});

builder.Services.AddScoped<IPlatformRepo, PlatformRepo>();

var app = builder.Build();
app.UseHttpsRedirection();
app.Run();