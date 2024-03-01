﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eskitech.Data;

#nullable disable

namespace eskitech.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240301152052_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eskitech.Models.Produkter", b =>
                {
                    b.Property<int>("ProduktID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProduktID"));

                    b.Property<int>("Kategori")
                        .HasColumnType("int");

                    b.Property<int>("LagerSaldo")
                        .HasColumnType("int");

                    b.Property<string>("Namn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pris")
                        .HasColumnType("int");

                    b.Property<string>("Storlek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProduktID");

                    b.ToTable("Produkter");
                });
#pragma warning restore 612, 618
        }
    }
}
