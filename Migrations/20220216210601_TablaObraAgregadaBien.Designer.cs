// <auto-generated />
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
    [Migration("20220216210601_TablaObraAgregadaBien")]
    partial class TablaObraAgregadaBien
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

                    b.Property<byte[]>("ARL")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<byte[]>("Cedula")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<byte[]>("EPS")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<byte[]>("Pension")
                        .IsRequired()
                        .HasColumnType("image");

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

                    b.Property<int>("Responsable")
                        .HasColumnType("int");

                    b.Property<string>("ins_mod_elim")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.HasIndex("Responsable");

                    b.ToTable("Subcontratista");
                });

            modelBuilder.Entity("Contratistas.Models.Trabajador", b =>
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

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Estado_ingreso")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("NIT_Contratista")
                        .HasColumnType("int");

                    b.Property<int>("NIT_Subcontratista")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Observaciones")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Responsable")
                        .HasColumnType("int");

                    b.Property<string>("ins_mod_elim")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.HasIndex("NIT_Contratista");

                    b.HasIndex("NIT_Subcontratista");

                    b.HasIndex("Responsable");

                    b.ToTable("Trabajador");
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

            modelBuilder.Entity("Contratistas.Models.Subcontratista", b =>
                {
                    b.HasOne("Contratistas.Models.Administrador", "Administradores")
                        .WithMany()
                        .HasForeignKey("Responsable")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administradores");
                });

            modelBuilder.Entity("Contratistas.Models.Trabajador", b =>
                {
                    b.HasOne("Contratistas.Models.Contratista", "Contratistas")
                        .WithMany()
                        .HasForeignKey("NIT_Contratista")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Contratistas.Models.Subcontratista", "Subcontratistas")
                        .WithMany()
                        .HasForeignKey("NIT_Subcontratista")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Contratistas.Models.Administrador", "Administradores")
                        .WithMany()
                        .HasForeignKey("Responsable")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administradores");

                    b.Navigation("Contratistas");

                    b.Navigation("Subcontratistas");
                });
#pragma warning restore 612, 618
        }
    }
}
