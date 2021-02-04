﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_UsuarioF.DAL;

namespace ProyectoReguistroUsuario.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Proyecto_UsuarioF.Entidades.Roll", b =>
                {
                    b.Property<int>("RolliD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fechacreacion")
                        .HasColumnType("TEXT");

                    b.HasKey("RolliD");

                    b.ToTable("Roll");
                });

            modelBuilder.Entity("Proyecto_UsuarioF.Entidades.Usuario", b =>
                {
                    b.Property<int>("IdR")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("RolId")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UsuarioNombre")
                        .HasColumnType("TEXT");

                    b.HasKey("IdR");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
