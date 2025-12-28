using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.AllowAnyOrigin() // your MFE origin
              .AllowAnyHeader()
              .AllowAnyMethod()
; // if you need cookies or auth
    });
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var dbServer = Environment.GetEnvironmentVariable("DB_SERVER") ?? "localhost";
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "YourStrong!Passw0rd";

// Replace placeholders in connection string
var connectionString = builder.Configuration
    .GetConnectionString("DevConnection")
    .Replace("${DB_SERVER}", dbServer)
    .Replace("${DB_PASSWORD}", dbPassword);
builder.Services.AddDbContext<PaymentDetailContext>(options =>
options.UseSqlServer(connectionString));

var app = builder.Build();
app.UseCors("AllowFrontend");

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PaymentDetailContext>();
    db.Database.EnsureCreated();  // Creates DB and tables if they don't exist
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapControllers();

app.Run();
