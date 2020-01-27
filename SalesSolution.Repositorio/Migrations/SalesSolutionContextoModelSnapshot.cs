﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesSolution.Repositorio.Contexto;

namespace SalesSolution.Repositorio.Migrations
{
    [DbContext(typeof(SalesSolutionContexto))]
    partial class SalesSolutionContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesSolution.Dominio.Entidades.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int")
                        .HasMaxLength(20);

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("ItensPedidos");
                });

            modelBuilder.Entity("SalesSolution.Dominio.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataPrevisaoEntrega")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EnderecoCompleto")
                        .IsRequired()
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4")
                        .HasMaxLength(250);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<int>("FormaPagamentoId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroEndereco")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormaPagamentoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("SalesSolution.Dominio.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(350) CHARACTER SET utf8mb4")
                        .HasMaxLength(350);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("SalesSolution.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SalesSolution.Dominio.ObjetoValor.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(350) CHARACTER SET utf8mb4")
                        .HasMaxLength(350);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("FormaPagamento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Forma de Pagamento Boleto",
                            Nome = "Boleto"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Forma de Pagamento Cartão de Cretido",
                            Nome = "Cartão de Crédito"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Forma de Pagamento Depósito",
                            Nome = "Despósito "
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Forma de Pagamento Débito",
                            Nome = "Cartão de Débito "
                        });
                });

            modelBuilder.Entity("SalesSolution.Dominio.Entidades.ItemPedido", b =>
                {
                    b.HasOne("SalesSolution.Dominio.Entidades.Pedido", null)
                        .WithMany("ItensPedido")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("SalesSolution.Dominio.Entidades.Pedido", b =>
                {
                    b.HasOne("SalesSolution.Dominio.ObjetoValor.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesSolution.Dominio.Entidades.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
