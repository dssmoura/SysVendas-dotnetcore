﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;
using SysVendas.Data.Context;

namespace SysVendas.Data.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("SysVendas.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Codigo");

                    b.Property<string>("Bairro")
                        .HasColumnName("Bairro");

                    b.Property<string>("Cidade")
                        .HasColumnName("Cidade");

                    b.Property<string>("Email")
                        .HasColumnName("Email");

                    b.Property<string>("Estado")
                        .HasColumnName("Estado");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome");

                    b.Property<int>("Numero")
                        .HasColumnName("Numero");

                    b.Property<string>("Rua")
                        .HasColumnName("Rua");

                    b.HasKey("Codigo");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SysVendas.Domain.Entities.Fornecedor", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Codigo");

                    b.Property<string>("Bairro")
                        .HasColumnName("Bairro");

                    b.Property<string>("Cidade")
                        .HasColumnName("Cidade");

                    b.Property<string>("Email")
                        .HasColumnName("Email");

                    b.Property<string>("Estado")
                        .HasColumnName("Estado");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome");

                    b.Property<int>("Numero")
                        .HasColumnName("Numero");

                    b.Property<string>("Rua")
                        .HasColumnName("Rua");

                    b.HasKey("Codigo");

                    b.ToTable("FORNECEDOR");
                });
#pragma warning restore 612, 618
        }
    }
}
