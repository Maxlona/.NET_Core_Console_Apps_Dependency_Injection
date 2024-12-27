using injection.Logic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace injection.Logging
{
    public static class Logging
    {
        public static IServiceCollection AddCustomLogging(this IServiceCollection services)
        {
            using var loggerFactory = LoggerFactory.Create(static builder =>
            {
                builder
                    .AddFilter("Microsoft", LogLevel.Warning)
                    .AddFilter("System", LogLevel.Warning)
                    .AddFilter("LoggingConsoleApp.Program", LogLevel.Debug)
                    .AddConsole();
            });

            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogDebug("Hello {Target}", "Everyone");

           return services.AddSingleton(typeof(ILogger), logger);
        }
    }
}
