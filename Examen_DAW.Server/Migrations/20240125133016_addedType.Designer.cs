﻿// <auto-generated />
using System;
using Examen_DAW.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen_DAW.Server.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240125133016_addedType")]
    partial class addedType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examen_DAW.Server.Models.Materie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materii");
                });

            modelBuilder.Entity("Examen_DAW.Server.Models.Profesor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profesori");
                });

            modelBuilder.Entity("Examen_DAW.Server.Models.ProfesorMaterie", b =>
                {
                    b.Property<Guid>("ProfesorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaterieId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProfesorId", "MaterieId");

                    b.HasIndex("MaterieId");

                    b.ToTable("ProfesorMaterie");
                });

            modelBuilder.Entity("Examen_DAW.Server.Models.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Examen_DAW.Server.Models.ProfesorMaterie", b =>
                {
                    b.HasOne("Examen_DAW.Server.Models.Materie", "Materie")
                        .WithMany("ProfesorMaterii")
                        .HasForeignKey("MaterieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen_DAW.Server.Models.Profesor", "Profesor")
                        .WithMany("ProfesoriMaterii")
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materie");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("Examen_DAW.Server.Models.Materie", b =>
                {
                    b.Navigation("ProfesorMaterii");
                });

            modelBuilder.Entity("Examen_DAW.Server.Models.Profesor", b =>
                {
                    b.Navigation("ProfesoriMaterii");
                });
#pragma warning restore 612, 618
        }
    }
}
