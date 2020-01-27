using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesSolution.Dominio.ObjetoValor;
using System;

namespace SalesSolution.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .Property(f => f.Nome)
                .HasMaxLength(100)
                .IsRequired();


            builder
                .Property(f => f.Descricao)
                .HasMaxLength(350)
                .IsRequired();
              

        }
    }
}
