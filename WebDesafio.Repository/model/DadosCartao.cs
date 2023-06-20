using System;
using System.Collections.Generic;
using System.Text;

namespace WebDesafio.Repository.model
{
    public class DadosCartao
    {
        public int id { get; set; }
        public int ContaCorrente { get; set; }
        public int NumeroCartao { get; set; }
        public int cvv { get; set; }

        public DateTime DataValidade { get; set; }
    }
}