using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebDesafio.Application.AtualizarCartao;
using WebDesafio.Repository;

namespace WebDesafio.Application.DeletarDados
{
    public class DeletarService
    {

        private readonly DesafioContext _context;
        public DeletarService(DesafioContext context)
        {
            _context = context;
        }

        public bool deletarDadosCartao(DeletarRequest request) 
        { 
            
            var existe = _context.DadosCartao.FirstOrDefault(x => x.DataValidade == request.DataValidade && x.NumeroCartao == request.NumeroCartao && x.cvv == request.cvv);
            if(existe !=null)
            {

                var DadosCartao = _context.DadosCartao.FirstOrDefault(x => x.ContaCorrente == existe.ContaCorrente);

                _context.DadosCartao.Remove(DadosCartao);
                _context.SaveChanges();


                return true;
            }
            else
            {
               return false;
            }
        }
    }
}
