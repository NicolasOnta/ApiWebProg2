﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apitest4.Models;

namespace apitest4.Migrations
{
    [DbContext(typeof(CRUDContext))]
    partial class CRUDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("apitest4.Models.Bus", b =>
                {
                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<bool>("Asientos_discapacitados")
                        .HasColumnType("bit");

                    b.Property<bool>("Baño")
                        .HasColumnType("bit");

                    b.Property<string>("Cedula_Asistente")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Cedula_Chofer")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Cooperativa")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Correo_Asistente")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Correo_Chofer")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Nombres_Asistente")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Nombres_Chofer")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<bool>("TV")
                        .HasColumnType("bit");

                    b.Property<bool>("Wifi")
                        .HasColumnType("bit");

                    b.HasKey("Placa");

                    b.ToTable("Bus");
                });

            modelBuilder.Entity("apitest4.Models.Parada", b =>
                {
                    b.Property<int>("ParadaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusPlaca")
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal?>("Costo")
                        .HasColumnType("money");

                    b.Property<string>("IdBus")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Sector")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("ParadaId");

                    b.HasIndex("BusPlaca");

                    b.ToTable("Parada");
                });

            modelBuilder.Entity("apitest4.Models.Reporte", b =>
                {
                    b.Property<int>("ReporteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Acoso")
                        .HasColumnType("bit");

                    b.Property<string>("BusPlaca")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("IdBus")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("Mala_Conduccion")
                        .HasColumnType("bit");

                    b.Property<string>("Nota")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ReporteId");

                    b.HasIndex("BusPlaca");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Reporte");
                });

            modelBuilder.Entity("apitest4.Models.Resena", b =>
                {
                    b.Property<int>("ResenaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusPlaca")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("Calificacion")
                        .HasColumnType("int");

                    b.Property<string>("IdBus")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nota")
                        .HasColumnType("text");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ResenaId");

                    b.HasIndex("BusPlaca");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Resena");
                });

            modelBuilder.Entity("apitest4.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Administrador")
                        .HasColumnType("bit");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("Fecha_Nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("apitest4.Models.Parada", b =>
                {
                    b.HasOne("apitest4.Models.Bus", "Bus")
                        .WithMany("Parada")
                        .HasForeignKey("BusPlaca");
                });

            modelBuilder.Entity("apitest4.Models.Reporte", b =>
                {
                    b.HasOne("apitest4.Models.Bus", "Bus")
                        .WithMany("Reporte")
                        .HasForeignKey("BusPlaca");

                    b.HasOne("apitest4.Models.Usuario", "Usuario")
                        .WithMany("Reporte")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("apitest4.Models.Resena", b =>
                {
                    b.HasOne("apitest4.Models.Bus", "Bus")
                        .WithMany("Resena")
                        .HasForeignKey("BusPlaca");

                    b.HasOne("apitest4.Models.Usuario", "Usuario")
                        .WithMany("Resena")
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}