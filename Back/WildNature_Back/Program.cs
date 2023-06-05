using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WildNature_Back.Configuration;
using WildNature_Back.Context;
using WildNature_Back.LocalControllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IClassController, ClassController>();
builder.Services.AddDbContext<db_a9a6f8_fowon21908Context>(options => {
options.UseSqlServer(

    builder.Configuration.GetConnectionString("dbconn"),

    b => b.MigrationsAssembly(typeof(db_a9a6f8_fowon21908Context).Assembly.FullName));
});

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
