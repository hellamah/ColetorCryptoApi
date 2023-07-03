using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoApi.Domain.Entities
{
    public class ResultadoOperacao<TResultObject> where TResultObject : class
    {
        public string Codigo { get; set; }
        public string MensagemRetorno { get; set; }
        public string Detalhe { get; set; }
        public TResultObject Resultado { get; set; }
        public bool ExecutouComSucesso { get; set; }
    }
}
