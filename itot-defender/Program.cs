using itot_defender.Infrastructure.Data;
using itot_defender.Infrastructure.Repositories;
using itot_defender.Domain.Interfaces;
using itot_defender.Infrastructure.Extension;
using Microsoft.EntityFrameworkCore;
using itot_defender.Service.Services;
using Microsoft.FeatureManagement;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Register Swagger services
builder.Services.AddLogging();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Setup CORS
app.UseCors(options =>
    options.WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod());

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseSwagger(); // Use Swagger middleware
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "itot_defender v1")); // Configure Swagger UI
app.MapControllers();
app.Run();
