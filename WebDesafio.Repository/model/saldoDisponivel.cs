using System;

namespace WebDesafio.Repository.model
{
    public class saldoDisponivel
    {
        public int id { get; set; }
        public decimal saldo { get; set; }
        public int IdContaCorrente { get; set; }
    }
}
