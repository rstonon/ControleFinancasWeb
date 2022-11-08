﻿// <auto-generated />
using System;
using ControleFinancasWeb.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleFinancasWeb.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ControleFinancasDbContext))]
    [Migration("20221108223521_Ajuste_DataVencimento_Contas")]
    partial class AjusteDataVencimentoContas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControleFinancasWeb.Core.Entities.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataQuitacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDetalhamento")
                        .HasColumnType("int");

                    b.Property<int>("IdTipo")
                        .HasColumnType("int");

                    b.Property<int?>("NumeroParcela")
                        .HasColumnType("int");

                    b.Property<int?>("QuantidadeParcelas")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdDetalhamento");

                    b.HasIndex("IdTipo");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("ControleFinancasWeb.Core.Entities.Detalhamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdTipo")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTipo");

                    b.ToTable("Detalhamentos");
                });

            modelBuilder.Entity("ControleFinancasWeb.Core.Entities.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("ControleFinancasWeb.Core.Entities.TipoDetalhamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdDetalhamento")
                        .HasColumnType("int");

                    b.Property<int>("IdTipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TipoDetalhamentos");
                });

            modelBuilder.Entity("ControleFinancasWeb.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ControleFinancasWeb.Core.Entities.Conta", b =>
                {
                    b.HasOne("ControleFinancasWeb.Core.Entities.Detalhamento", "Detalhamento")
                        .WithMany("Contas")
                        .HasForeignKey("IdDetalhamento")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ControleFinancasWeb.Core.Entities.Tipo", "Tipo")
                        .WithMany("Contas")
                        .HasForeignKey("IdTipo")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Detalhamento");

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("ControleFinancasWeb.Core.Entities.Detalhamento", b =>
                {
                    b.HasOne("ControleFinancasWeb.Core.Entities.Tipo", "Tipo")
                        .WithMany("Detalhamentos")
                        .HasForeignKey("IdTipo")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("ControleFinancasWeb.Core.Entities.Detalhamento", b =>
                {
                    b.Navigation("Contas");
                });

            modelBuilder.Entity("ControleFinancasWeb.Core.Entities.Tipo", b =>
                {
                    b.Navigation("Contas");

                    b.Navigation("Detalhamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
