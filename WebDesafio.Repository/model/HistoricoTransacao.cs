using System;
using System.Collections.Generic;
using System.Text;

namespace WebDesafio.Repository.model
{
    public class HistoricoTransacao
    {
        public int id { get; set; }
        public int ContaCorrente { get; set; }

        public DateTime Dia { get; set; }
        public string status { get; set; }

        public decimal ValorDaCompra { get; set; }

        public string FormaDePagamento { get; set; }  
    }
}
