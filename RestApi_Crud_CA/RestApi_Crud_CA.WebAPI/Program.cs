using DefaultCorsPolicyNugetPackage;
using RestApi_Crud_CA.Application;
using RestApi_Crud_CA.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();


builder.Services.AddDefaultCors();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddProblemDetails();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseExceptionHandler();

app.MapControllers();


app.Run();
