using System;
using System.Collections.Generic;
using System.Text;

namespace WebDesafio.Application.Atualizar
{
    public class AtualizarRequest
    {
        public int contaCorrente { get; set; }

        public int NumeroCartao { get; set; }
        public int cvv { get; set; }
        public DateTime DataValidade {get ; set; }



    }
}
