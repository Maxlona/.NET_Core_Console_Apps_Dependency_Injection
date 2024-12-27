using injection.Config;
using injection.Logging;
using injection.Logic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


/// initialize
IServiceCollection services = ConfigureServices();
ServiceProvider serviceProvider = services.BuildServiceProvider();


//// create a custom dependency
static IServiceCollection ConfigureServices()
{
    string? env = Environment.GetEnvironmentVariable("Hosting:Environment")  ?? "dev";
    IServiceCollection services = new ServiceCollection();
    IConfiguration config = AddConfigs(env);
    services.AddSingleton(config);
    services.AddNewCar();
    services.AddCustomLogging();
    return services;
}

// Add Config
static IConfiguration AddConfigs(string env)
{
    return new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile($"appsettings.{env}.json")
        .AddEnvironmentVariables().Build();
}

var trainService = serviceProvider.GetService<iCar>();
trainService?.Start();
