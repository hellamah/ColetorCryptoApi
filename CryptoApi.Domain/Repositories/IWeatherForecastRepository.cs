using CryptoApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptoApi.Domain.Repositories
{
    public interface IWeatherForecastRepository
    {
        Task<ResultadoOperacao<IEnumerable<WeatherForecast>>> Get();
    }
}
