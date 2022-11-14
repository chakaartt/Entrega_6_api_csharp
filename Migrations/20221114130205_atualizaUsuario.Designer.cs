﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_myProjet.DataBase;

#nullable disable

namespace api_myProjet.Migrations
{
    [DbContext(typeof(UsuarioDbContext))]
    [Migration("20221114130205_atualizaUsuario")]
    partial class atualizaUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("api_myProjet.model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("cliente", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
