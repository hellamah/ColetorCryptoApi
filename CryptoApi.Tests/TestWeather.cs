using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using CryptoApi.Application.Services;
using CryptoApi.Domain.Entities;
using CryptoApi.Infra.Repositories;
using System.Collections.Generic;
using CryptoApi.Api.Controllers;
using System.Threading.Tasks;

namespace CryptoApi.Tests
{
    public class TestsWeather
    {
        private WeatherServiceManager _weatherServiceManager;
        private WeatherForecastRepository _weatherForecastRepository;
        private WeatherForecastController _controller;
        private ILogger<WeatherForecast> _logger;

        [SetUp]
        public void Setup()
        {
            _weatherForecastRepository = new WeatherForecastRepository();
            _weatherServiceManager = new WeatherServiceManager(_weatherForecastRepository);
            ILoggerFactory loggerFactory = new Loggeractory();
            _logger = loggerFactory.CreateLogger<WeatherForecast>();
            _controller = new WeatherForecastController(_weatherServiceManager, _logger);
        }

        [Test]
        public async Task TesteWeather()
        {
            var result = await _controller.Get();
            if (result.StatusCode == 200)
            {
                ResultadoOperacao<IEnumerable<WeatherForecast>> value = (ResultadoOperacao<IEnumerable<WeatherForecast>>) result.Value;
                if (value.ExecutouComSucesso)
                    Assert.Pass();
            }
            else
            {
                ResultadoOperacaoRetornoErro value = (ResultadoOperacaoRetornoErro)result.Value;
                Assert.Fail(value.ResultadoOperacao.Detalhamento);
            }
        }

    }
}