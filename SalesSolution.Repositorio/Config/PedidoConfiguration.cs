using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesSolution.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSolution.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.EnderecoCompleto)
                .HasMaxLength(250)
                .IsRequired();
               

            builder
                .Property(p => p.NumeroEndereco)
                .HasMaxLength(50)
                .IsRequired();
               

            builder
                .Property(p => p.Cidade)
                .HasMaxLength(50)
                .IsRequired();
              

            builder
             .Property(p => p.Estado)
             .HasMaxLength(10)
             .IsRequired();
            

            builder
             .Property(p => p.CEP)
             .HasMaxLength(50)
             .IsRequired();
             


            builder
             .Property(p => p.DataPedido)
             .IsRequired();

            builder
             .Property(p => p.DataPrevisaoEntrega)
             .IsRequired();








        }
    }
}
