using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebDesafio.Application.Conta;
using WebDesafio.Repository.model;

namespace WebDesafio.Repository
{
    public class DesafioContext : DbContext
    {
        public DesafioContext(DbContextOptions<DesafioContext> options) : base(options) { }

        public DbSet<saldoDisponivel> conta { get; set; }
        public DbSet<ContaCorrente> Corrente { get; set; }
        public DbSet<DadosCartao> DadosCartao { get; set; }
        public DbSet<HistoricoTransacao> historico { get; set; }

        public DbSet<pessoa> pessoa { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<saldoDisponivel>().ToTable("saldoDisponivel");
            modelBuilder.Entity<ContaCorrente>().ToTable("ContaCorrente");
            modelBuilder.Entity<DadosCartao>().ToTable("DadosCartao");
            modelBuilder.Entity<HistoricoTransacao>().ToTable("HistoricoTransacao");
            modelBuilder.Entity<pessoa>().ToTable("pessoa");
        }
    }
}
