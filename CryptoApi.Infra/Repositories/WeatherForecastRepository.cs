using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CryptoApi.Domain.Entities;
using CryptoApi.Domain.Repositories;

namespace CryptoApi.Infra.Repositories
{
    public class WeatherForecastRepository :    IWeatherForecastRepository
    {        
        public async Task<ResultadoOperacao<IEnumerable<WeatherForecast>>> Get()
        {
            ResultadoOperacao<IEnumerable<WeatherForecast>> resultadoOperacao = new ResultadoOperacao<IEnumerable<WeatherForecast>>();

            string[] Summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
            var rng = new Random();
            var res = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });

            resultadoOperacao.Resultado = res;
            resultadoOperacao.Detalhe = "";
            resultadoOperacao.Codigo = "1000";
            resultadoOperacao.MensagemRetorno = "";
            resultadoOperacao.ExecutouComSucesso = true;

            return resultadoOperacao;
        }
    }
}
