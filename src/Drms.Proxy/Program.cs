using AspNetCore.Metrics;
using AspNetCore.RabbitMQ;
using CRM.HttpClient;
using Drms.Proxy;
using DRMS.HttpClient;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

builder.Host.UseSerilog((ctx, lc) => lc
        .ReadFrom.Configuration(configuration));

var environment = builder.Environment;

builder.Services.AddPrometheusMetrics(configuration);

builder.Services.Configure<CommonOptions>(configuration.GetSection(CommonOptions.SectionName));
builder.Services.AddDRMSHttpClient(configuration);
builder.Services.AddCRMHttpClient(configuration);
builder.Services.AddTransient<ICRMIntegration, CRMIntegration>();

//builder.Services
//    .AddRabbitMQClient(configuration, environment)
//    .AddEventConsumer<NewCaseCreatedConsumer>();

var app = builder.Build();


app.UseHttpsRedirection();

app.Use(async (context, next) =>
{
    context.Request.EnableBuffering(10000000);
    await next();
});

app.UseProxyMiddleware();

app.Run();
