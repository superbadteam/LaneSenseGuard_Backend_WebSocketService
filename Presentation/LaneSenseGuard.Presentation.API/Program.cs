using BuildingBlock.Presentation.API.Extensions;
using BuildingBlock.Presentation.API.Hosts;
using BuildingBlock.Presentation.API.Middlewares;
using LaneSenseGuard.Core.Application;
using LaneSenseGuard.Core.Domain;
using LaneSenseGuard.Infrastructure.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseDefaultHosts(builder.Configuration);

builder.Services.AddDefaultExtensions(builder.Configuration);

await builder.Services.AddDefaultModuleExtensionsAsync<ApplicationAssemblyReference,
        DomainAssemblyReference,
        DbContext>(builder.Configuration);

builder.Host.UseDefaultHosts(builder.Configuration);

var app = builder.Build();

await app.UseDefaultMiddlewares(app.Environment, builder.Configuration);

app.MapControllers();

app.Run();