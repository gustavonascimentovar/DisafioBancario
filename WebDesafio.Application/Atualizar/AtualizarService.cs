using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebDesafio.Repository;

namespace WebDesafio.Application.Atualizar
{
    public class AtualizarService
    {

        private readonly DesafioContext _context;
        public AtualizarService(DesafioContext context)
        {
            _context = context;
        }

        public bool AtualizarCartão (AtualizarRequest request)
        {
            var ExisteContaCorrente = _context.Corrente.FirstOrDefault(x => x.id == request.contaCorrente);
            var DadosCartao = _context.DadosCartao.FirstOrDefault(x => x.ContaCorrente == request.contaCorrente);
            if(ExisteContaCorrente != null)
            {
                DadosCartao.ContaCorrente = request.contaCorrente;
                DadosCartao.cvv = request.cvv;
                DadosCartao.NumeroCartao = request.NumeroCartao;
                DadosCartao.DataValidade = request.DataValidade;

                _context.DadosCartao.Update(DadosCartao);
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
