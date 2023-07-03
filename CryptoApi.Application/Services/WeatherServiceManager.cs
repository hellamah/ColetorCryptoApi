using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CryptoApi.Domain.Entities;
using CryptoApi.Domain.Repositories;
using CryptoApi.Domain.Services;

namespace CryptoApi.Application.Services
{
    public class WeatherServiceManager : IWeatherService
    {
        private readonly IWeatherForecastRepository _weatherRepository;

        public WeatherServiceManager(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherRepository = weatherForecastRepository;
        }
        public Task<ResultadoOperacao<IEnumerable<WeatherForecast>>> Get()
        {
            var weather = _weatherRepository.Get();
            return weather;
        }
    }
}
