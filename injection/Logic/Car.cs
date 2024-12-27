using injection.Model; 
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace injection.Logic
{
    public class Car : iCar
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        public Car(IConfiguration configuration, ILogger logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public void Start()
        {
            Console.WriteLine("Car is running...");
            _logger.LogDebug("Stared the car");
            // get config 
            var config = _configuration?.GetSection("Features").Get<Features>();
            Console.WriteLine($"Car Color: {config?.External?.Color}");
        }
    }
}
