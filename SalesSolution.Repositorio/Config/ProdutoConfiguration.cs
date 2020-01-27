using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesSolution.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSolution.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .HasMaxLength(100)
                .IsRequired();
       

            builder
              .Property(p => p.Descricao)
              .HasMaxLength(350)
              .IsRequired();
             

            builder
              .Property(p => p.Preco)
              .IsRequired();
             
        }
    }
}
