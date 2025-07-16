using EmployeeManager.Repositories;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Repositories;
using WebApplication1.Services;


//TODO: як усе зробиш потр≥бно буде посортувати все по папкам Controllers, Shared, Domain, Application (пуста), Infrastructure

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("ManagerDb"));
});

builder.Services.AddScoped <IWorkerService, WorkerService>();
builder.Services.AddScoped <IWorkerRepository, WorkerRepository>();
builder.Services.AddScoped <IHourService, HourService>();
builder.Services.AddScoped <IHourRepository, HourRepository>();

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
