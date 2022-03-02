using AspNetCore.Metrics;
using CRM.HttpClient;
using Drms.Proxy;
using DRMS.HttpClient;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

builder.Host.UseSerilog((ctx, lc) => lc
        .ReadFrom.Configuration(configuration));

IWebHostEnvironment environment = builder.Environment;

builder.Services.AddPrometheusMetrics(configuration);

builder.Services.Configure<CommonOptions>(configuration.GetSection(CommonOptions.SectionName));
builder.Services.AddDRMSHttpClient(configuration);
builder.Services.AddCRMHttpClient(configuration);
builder.Services.AddTransient<ICRMIntegration, CRMIntegration>();


var app = builder.Build();


app.UseHttpsRedirection();

app.Use(async (context, next) =>
{
    context.Request.EnableBuffering(10000000);
    await next();
});



app.UseProxyMiddleware();

app.Run();
