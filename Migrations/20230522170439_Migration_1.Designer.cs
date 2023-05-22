﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RtoNR.Models;

#nullable disable

namespace RtoNR.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230522170439_Migration_1")]
    partial class Migration_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RtoNR.Models.Registro", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PadreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PadreId");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("RtoNR.Models.RegistroNR", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Hijos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RegistrosNR");
                });

            modelBuilder.Entity("RtoNR.Models.Registro", b =>
                {
                    b.HasOne("RtoNR.Models.Registro", "Padre")
                        .WithMany()
                        .HasForeignKey("PadreId");

                    b.Navigation("Padre");
                });
#pragma warning restore 612, 618
        }
    }
}
