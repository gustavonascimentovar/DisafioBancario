using System;
using System.Collections.Generic;
using System.Text;

namespace WebDesafio.Application.AtualizarCartao
{
    public class DeletarRequest
    {


        public int NumeroCartao { get; set; }
        public int cvv { get; set; }

        public DateTime DataValidade { get; set; }


    }
}
