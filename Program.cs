using Endpoint_TwoToFour.Services.Mini2;
using Endpoint_TwoToFour.Services.Mini3;
using Endpoint_TwoToFour.Services.Mini4;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAddingNumbers, AddingNumbers>();
builder.Services.AddScoped<IWakeUp, WakeUp>();
builder.Services.AddScoped<ICompare, Compare>();

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
