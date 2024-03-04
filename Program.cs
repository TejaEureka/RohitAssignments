using dotnet_jan_24_mac.Interfaces;
using dotnet_jan_24_mac.Services;
using dotnet_jan_24_mac.Providers;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IStocksService, StocksService>();
builder.Services.AddScoped<IStocksProvider, StocksProvider>();
builder.Services.AddScoped<ISectorService, SectorService>();
builder.Services.AddScoped<ISectorProvider, SectorProvider>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

