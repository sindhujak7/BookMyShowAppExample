using BookMyShow.Data;
using BookMyShowApp.API.Interface;
using BookMyShowApp.API.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
;

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BookMyShowContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddScoped<ICities, Cities>();
builder.Services.AddScoped<ITheatres, TheatreService>();
builder.Services.AddScoped<ICustomer, CustomerService>();
builder.Services.AddScoped<IBookingDetails, BookingService>();
builder.Services.AddScoped<IMovies,MovieService>();
builder.Services.AddScoped<ILanguages,LanguageService>();
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

