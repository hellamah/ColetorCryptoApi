using Microsoft.Extensions.Logging;
using CryptoApi.Domain.Entities;
using CryptoApi.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CryptoApi.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WeatherForecastController : ControllerBase
    {        
        private readonly IWeatherService _weatherService;
        private readonly ILogger<WeatherForecast> _logger;

        public WeatherForecastController(IWeatherService weatherService,
                                         ILogger<WeatherForecast> logger)
        {
            _weatherService = weatherService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var result = await _weatherService.Get();
                return Ok(result);
            }
            catch (Exception ex)
            {
                ResultadoOperacaoRetornoErro resultadoErro = new ResultadoOperacaoRetornoErro();
                resultadoErro.IdRequisicao = Guid.NewGuid().ToString();
                resultadoErro.DataHoraEnvio = DateTime.Now;
                resultadoErro.DataHoraProcessamento = DateTime.Now;
                resultadoErro.ResultadoOperacao = new ResultadoOperacaoRetornoBase
                {
                    Codigo = "2000",
                    Detalhamento = ex.Message,
                    MensagemRetorno = "Erro durante a execução da operação de retorno de dados."
                };

                _logger.LogError(ex, @$"Ocorreu um erro durante a habilitação do dispositivo.");
                return StatusCode(StatusCodes.Status503ServiceUnavailable, resultadoErro);
            }
        }
    }
}
