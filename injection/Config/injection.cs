using injection.Logic;
using Microsoft.Extensions.DependencyInjection;

namespace injection.Config
{
    public static class Injection
    {
        public static IServiceCollection AddNewCar(this IServiceCollection services)
        {
            var svc = services.AddTransient<iCar, Car>();
            return svc;
        }
    }
}
