using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebDesafio.Application.Conta;
using WebDesafio.Repository;
using WebDesafio.Repository.model;

namespace WebDesafio.Application.saldo
{
    public class SaldoService
    {

        private readonly DesafioContext _context;

        public SaldoService(DesafioContext context)
        {
            _context = context;
        }


        public SaldoResponse PegarSaldo(SaldoRequest request)
        {
            var DadosExiste = _context.Corrente.FirstOrDefault(x => x.conta == request.conta && x.agencia == request.agencia);
            if (DadosExiste != null)
            {

                var getSaldo = _context.conta.FirstOrDefault(x => x.IdContaCorrente == DadosExiste.id);

                var responder = new SaldoResponse();
                {
                    responder.saldo = getSaldo.saldo;
                }
                return responder;
            }
            else
            {

                return null;
            }
        }
    }
}
