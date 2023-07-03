using Microsoft.Extensions.DependencyInjection;
using CryptoApi.Application.Services;
using CryptoApi.Domain.Repositories;
using CryptoApi.Domain.Services;
using CryptoApi.Infra.Repositories;

namespace CryptoApi.Ioc
{
    public static class ContainerConfigurator
    {
        public static void AddApplicationDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IWeatherForecastRepository, WeatherForecastRepository>();

            serviceCollection.AddTransient<IWeatherService, WeatherServiceManager>();
        }
    }
}
