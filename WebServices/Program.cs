using Aplicacion.Services;
using Infraestructura.Context;
using Microsoft.EntityFrameworkCore;
using WebServices.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

const string AllowAllOriginsPolicy = "AllowAllOriginsPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowAllOriginsPolicy,
        x =>
        {
            x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });
});

string conectionString = builder.Configuration.GetConnectionString("conectionDataBase");

builder.Services.AddDbContext<MyContext>(
        dbContextOption => dbContextOption.UseSqlServer(conectionString), ServiceLifetime.Transient
    );

builder.Services.AddTransient<IDataContext, MyContext>();
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<SecurityAplicationService>();

builder.Services.AddTransient<GlobalExceptionHandlingMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<GlobalExceptionHandlingMiddleware>();

app.MapControllers();

app.Run();
