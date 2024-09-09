﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyectoef;

#nullable disable

namespace proyectoef.Migrations
{
    [DbContext(typeof(TareaContext))]
    partial class TareaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("proyectoef.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategorioaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("CategorioaId");

                    b.ToTable("CAtegoria", (string)null);

                    b.HasData(
                        new
                        {
                            CategorioaId = new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904ccc"),
                            Nombre = "Actividades pendientes",
                            Peso = 20
                        },
                        new
                        {
                            CategorioaId = new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904c02"),
                            Nombre = "Actividades personales",
                            Peso = 50
                        });
                });

            modelBuilder.Entity("proyectoef.Models.Tarea", b =>
                {
                    b.Property<Guid>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrioridadTarea")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("TareaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            TareaId = new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904c10"),
                            CategoriaId = new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904ccc"),
                            FechaCreacion = new DateTime(2024, 9, 3, 20, 37, 18, 264, DateTimeKind.Local).AddTicks(6757),
                            PrioridadTarea = 1,
                            Titulo = "Pago de servicios publicos"
                        },
                        new
                        {
                            TareaId = new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904c11"),
                            CategoriaId = new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904c02"),
                            FechaCreacion = new DateTime(2024, 9, 3, 20, 37, 18, 264, DateTimeKind.Local).AddTicks(6790),
                            PrioridadTarea = 0,
                            Titulo = "Terminar de ver pelicula en netflix"
                        });
                });

            modelBuilder.Entity("proyectoef.Models.Tarea", b =>
                {
                    b.HasOne("proyectoef.Models.Categoria", "Categoria")
                        .WithMany("Tareas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("proyectoef.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
