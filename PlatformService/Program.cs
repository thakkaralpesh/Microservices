using Microsoft.EntityFrameworkCore;
using PlatformService.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(opt =>
{
   opt.UseInMemoryDatabase("InMem"); 
});

builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IPlatformRepo, PlatformRepo>();

var app = builder.Build();
Prepdb.PrepPopulation(app);
app.UseHttpsRedirection();
app.MapControllers();
app.Run();