using Microsoft.EntityFrameworkCore;
using SalesSolution.Dominio.Entidades;
using SalesSolution.Dominio.ObjetoValor;
using SalesSolution.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSolution.Repositorio.Contexto
{
    public class SalesSolutionContexto : DbContext
    {
       
        public DbSet<Usuario> Usuarios  { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<ItemPedido> ItensPedidos { get; set; }

        public DbSet<FormaPagamento> FormaPagamento { get; set; }


        public SalesSolutionContexto( DbContextOptions options) : base(options)
        {

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());


            modelBuilder.Entity<FormaPagamento>().HasData(
                
                new FormaPagamento() { Id = 1, Nome = "Boleto", Descricao ="Forma de Pagamento Boleto" },
                new FormaPagamento() { Id = 2, Nome = "Cartão de Crédito", Descricao = "Forma de Pagamento Cartão de Cretido" },
                new FormaPagamento() { Id = 3, Nome = "Despósito ", Descricao = "Forma de Pagamento Depósito" },
                new FormaPagamento() { Id = 4, Nome = "Cartão de Débito ", Descricao = "Forma de Pagamento Débito" }
                 );

            base.OnModelCreating(modelBuilder);
        }


    }
}
