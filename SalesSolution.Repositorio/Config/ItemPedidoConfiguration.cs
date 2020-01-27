using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesSolution.Dominio.Entidades;
using System;

namespace SalesSolution.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.Quantidade)
                .HasMaxLength(20)
                .IsRequired();

            builder
              .Property(i => i.ProdutoId)
              .HasMaxLength(20)
              .IsRequired();



        }
    }
}
