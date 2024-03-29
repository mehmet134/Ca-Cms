using Ca.Cms.Infrastructure.Persistence;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddWebApiServices(builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    await app.InitializeDb();
}

app.UseHttpsRedirection();
////app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
