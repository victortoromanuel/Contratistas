﻿// <auto-generated />
using System;
using Contratistas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Contratistas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220225201929_TablaSolicitudObraEnDB")]
    partial class TablaSolicitudObraEnDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Contratistas.Models.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Administrador");
                });

            modelBuilder.Entity("Contratistas.Models.Contratista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdOperador")
                        .HasColumnType("int");

                    b.Property<int>("IdSolicitudRegistro")
                        .HasColumnType("int");

                    b.Property<string>("NIT")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Observacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Razon_social")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("Responsable")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("ingresoPortal")
                        .HasColumnType("bit");

                    b.Property<string>("ins_mod_elim")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.HasIndex("IdOperador");

                    b.HasIndex("IdSolicitudRegistro");

                    b.HasIndex("Responsable");

                    b.ToTable("Contratista");
                });

            modelBuilder.Entity("Contratistas.Models.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ARL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EPS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Trabajador")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Trabajador");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("Contratistas.Models.Obra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("obrCodigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("obrId")
                        .HasColumnType("int");

                    b.Property<string>("obrNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Obra");
                });

            modelBuilder.Entity("Contratistas.Models.Operador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Operador");
                });

            modelBuilder.Entity("Contratistas.Models.SolicitudObra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdTrabajador")
                        .HasColumnType("int");

                    b.Property<int>("ObrId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTrabajador");

                    b.HasIndex("ObrId");

                    b.ToTable("SolicitudObra");
                });

            modelBuilder.Entity("Contratistas.Models.SolicitudRegistro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NIT")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NumeroOperador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Operador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Razon_social")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Transaccion")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("SolicitudRegistro");
                });

            modelBuilder.Entity("Contratistas.Models.Subcontratista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NIT")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Razon_social")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Subcontratista");
                });

            modelBuilder.Entity("Contratistas.Models.Trabajador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ARLValida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CedulaValida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EPSValida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EstadoIngreso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaIngresoObra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdContratista")
                        .HasColumnType("int");

                    b.Property<int?>("IdSubcontratista")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Observacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PensionValida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonaContacto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("TelefonoContacto")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdContratista");

                    b.HasIndex("IdSubcontratista");

                    b.ToTable("Trabajador");
                });

            modelBuilder.Entity("Contratistas.Models.TrabajadorXObra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdSolicitudObra")
                        .HasColumnType("int");

                    b.Property<int>("IdTrabajador")
                        .HasColumnType("int");

                    b.Property<int>("ObrId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdSolicitudObra");

                    b.HasIndex("IdTrabajador");

                    b.HasIndex("ObrId");

                    b.ToTable("TrabajadorXObra");
                });

            modelBuilder.Entity("Contratistas.Models.Contratista", b =>
                {
                    b.HasOne("Contratistas.Models.Operador", "Operadores")
                        .WithMany()
                        .HasForeignKey("IdOperador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Contratistas.Models.SolicitudRegistro", "SolicitudRegistros")
                        .WithMany()
                        .HasForeignKey("IdSolicitudRegistro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Contratistas.Models.Administrador", "Administradores")
                        .WithMany()
                        .HasForeignKey("Responsable")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administradores");

                    b.Navigation("Operadores");

                    b.Navigation("SolicitudRegistros");
                });

            modelBuilder.Entity("Contratistas.Models.Documento", b =>
                {
                    b.HasOne("Contratistas.Models.Trabajador", "Trabajadores")
                        .WithMany()
                        .HasForeignKey("Trabajador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trabajadores");
                });

            modelBuilder.Entity("Contratistas.Models.SolicitudObra", b =>
                {
                    b.HasOne("Contratistas.Models.Trabajador", "Trabajadores")
                        .WithMany()
                        .HasForeignKey("IdTrabajador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Contratistas.Models.Obra", "Obras")
                        .WithMany()
                        .HasForeignKey("ObrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Obras");

                    b.Navigation("Trabajadores");
                });

            modelBuilder.Entity("Contratistas.Models.Trabajador", b =>
                {
                    b.HasOne("Contratistas.Models.Contratista", "Contratistas")
                        .WithMany()
                        .HasForeignKey("IdContratista")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Contratistas.Models.Subcontratista", "Subcontratistas")
                        .WithMany()
                        .HasForeignKey("IdSubcontratista");

                    b.Navigation("Contratistas");

                    b.Navigation("Subcontratistas");
                });

            modelBuilder.Entity("Contratistas.Models.TrabajadorXObra", b =>
                {
                    b.HasOne("Contratistas.Models.SolicitudObra", "SolicitudObras")
                        .WithMany()
                        .HasForeignKey("IdSolicitudObra");

                    b.HasOne("Contratistas.Models.Trabajador", "Trabajadores")
                        .WithMany()
                        .HasForeignKey("IdTrabajador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Contratistas.Models.Obra", "Obras")
                        .WithMany()
                        .HasForeignKey("ObrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Obras");

                    b.Navigation("SolicitudObras");

                    b.Navigation("Trabajadores");
                });
#pragma warning restore 612, 618
        }
    }
}