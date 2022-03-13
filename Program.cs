using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Customer1.Data;
var builder = WebApplication.CreateBuilder(args);
var corsPolicy = "corsPolicy";

builder.Services.AddDbContext<Customer1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Customer1Context")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// to be changed
builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: corsPolicy,
        builder =>
        {
            builder.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(corsPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
