using System;
using System.Collections.Generic;
using System.Text;

namespace WebDesafio.Application.Compra
{
    public class ComprarRequest
    {
        public int numeroCartao { get; set; }
        public DateTime DataValidade { get; set; }
        public int cvv { get; set; }
        public int contaCorrente { get; set; }
        public decimal ValorCompra { get; set;  }
        public string FormaPagamento { get; set;}



    }
}
