using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QueryFilterEFCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

#region Connection String
 builder.Services.AddDbContext<EmployeeContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
