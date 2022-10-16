using Glance.Api;
using Glance.Application;
using Glance.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPresentation()
                .AddApplication()
                .AddInfrastructure();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
