using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoApi.Domain.Entities
{
    public class ResultadoOperacaoRetornoErro
    {
        public string IdRequisicao { get; set; }
        public DateTime DataHoraEnvio { get; set; }
        public DateTime DataHoraProcessamento { get; set; }
        public ResultadoOperacaoRetornoBase ResultadoOperacao { get; set; }
    }
}
