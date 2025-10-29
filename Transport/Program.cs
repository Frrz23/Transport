using Microsoft.EntityFrameworkCore;
using Transport.Data;
using Transport.Data.Repositories;
using Transport.Data.Repositories.IRepositories;
using Transport.Service;
using Transport.Service.IService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TransportDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbcs")));

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.Scan(scan => scan
    .FromAssembliesOf(typeof(IBiltyService)) // base interfaces
    .AddClasses(classes => classes.InNamespaces("Transport.Service"))
    .AsImplementedInterfaces()
    .WithScopedLifetime());



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
