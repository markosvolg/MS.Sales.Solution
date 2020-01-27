﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesSolution.Dominio.Entidades;

namespace SalesSolution.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder
           .Property(u => u.Nome)
           .IsRequired()
           .HasMaxLength(100);
         


            builder
             .Property(u => u.Sobrenome)
             .IsRequired()
             .HasMaxLength(100);
   


            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);


            builder
             .Property(u => u.Senha)
             .IsRequired()
             .HasMaxLength(200);
     
            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);



        }
    }
}
