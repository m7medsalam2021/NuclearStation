using Microsoft.EntityFrameworkCore;
using PowerStationMonitoring.Core.Model;
using PowerStationMonitoring.Core.Services;
using PowerStationMonitoring.Infrastructure.Data;
using PowerStationMonitoring.Infrasturcture.IRepository;
using PowerStationMonitoring.Infrasturcture.Repository;

var builder = WebApplication.CreateBuilder(args);

#region Configure Services

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(ISensorDataRepo), typeof(SensorDataRepo));
builder.Services.AddScoped(typeof(ISensorRepo), typeof(SensorRepo));
builder.Services.AddScoped<SensorService>();
builder.Services.AddScoped<SensorDataService>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection"))
);

#endregion

var app = builder.Build();

#region Configure Kestrel

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseCors("AllowFrontend");

app.UseAuthorization();

app.MapControllers();
//app.Use(async (context, next) => {
//    context.Response.Headers.Add("Content-Type", "application/json");
//    await next();
//});

#endregion

app.Run();
