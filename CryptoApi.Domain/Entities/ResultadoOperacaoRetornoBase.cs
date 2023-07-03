using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoApi.Domain.Entities
{
    public class ResultadoOperacaoRetornoBase
    {
        public string Codigo { get; set; }
        public string MensagemRetorno { get; set; }
        public string Detalhamento { get; set; }
    }
}
