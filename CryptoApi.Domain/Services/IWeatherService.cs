using CryptoApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptoApi.Domain.Services
{
    public interface IWeatherService
    {
        public Task<ResultadoOperacao<IEnumerable<WeatherForecast>>> Get();
    }
}
