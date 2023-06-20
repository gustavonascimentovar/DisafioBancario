using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebDesafio.Application.Conta;
using WebDesafio.Repository;
using WebDesafio.Repository.model;

namespace WebDesafio.Application.Compra
{


    public class comprarService
    {
        private readonly DesafioContext _context;
        public comprarService(DesafioContext context)
        {
            _context = context;
        }

        public bool TransacaoCompra(ComprarRequest request)
        {
            var ValidadarCartão = _context.DadosCartao.FirstOrDefault(x => x.DataValidade == request.DataValidade && x.NumeroCartao == request.numeroCartao && x.cvv == request.cvv && x.ContaCorrente == request.contaCorrente);
            if(ValidadarCartão != null)
            {
                var validarSaldo = _context.conta.FirstOrDefault(x => x.IdContaCorrente == ValidadarCartão.ContaCorrente);

                if (validarSaldo.saldo >= request.ValorCompra)
                {
                    validarSaldo.saldo = validarSaldo.saldo - request.ValorCompra;
                    _context.conta.Update(validarSaldo);
                    _context.SaveChanges();

                    var criarStatus = new HistoricoTransacao();
                    {
                        criarStatus.Dia = DateTime.Now;
                        criarStatus.status = "Transação Aprovada";
                        criarStatus.ContaCorrente = request.contaCorrente;
                        criarStatus.FormaDePagamento = request.FormaPagamento;
                        criarStatus.ValorDaCompra = request.ValorCompra;

                        
                    }
                    _context.historico.Add(criarStatus);
                    _context.SaveChanges();
                    
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            else
            {
                return false;
            }
        }

        

    }
}
