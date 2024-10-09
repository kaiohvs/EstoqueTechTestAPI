﻿// <auto-generated />
using System;
using EstoqueTechTest.Data.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstoqueTechTest.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20241009215308_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EstoqueTechTest.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0607be89-30f4-4654-908e-e32e6864b319"),
                            Category = "SMARTPHONE",
                            Description = "Smartphone Samsung Galaxy S22 5G SM-S901 128GB Câmera Tripla",
                            Name = "SAMSUNG GALAXY S22",
                            Price = 296910m,
                            StockQuantity = 10
                        },
                        new
                        {
                            Id = new Guid("64f78b14-2c61-47cc-a3bf-749e989f137e"),
                            Category = "SMARTPHONE",
                            Description = "Smartphone Apple iPhone 15 128GB Câmera Dupla",
                            Name = "APPLE IPHONE 15  ",
                            Price = 469900m,
                            StockQuantity = 7
                        },
                        new
                        {
                            Id = new Guid("4672b80f-244b-455d-aae9-dcc93addc170"),
                            Category = "NOTEBOOK",
                            Description = "Dell Laptop Inspiron 15 3501 15,6 FHD i7 - Intel Core i7-1165G7, RAM DDR4 16GB, SSD 512GB",
                            Name = "DELL INSPIRION I7",
                            Price = 419900m,
                            StockQuantity = 2
                        },
                        new
                        {
                            Id = new Guid("0237deba-e1ee-4368-81bc-e07a0109bf5c"),
                            Category = "MATERIAL ESCRITORIO",
                            Description = "Tilibra 305421 Universitário 10 Matérias Zip - Caderno Espiral, Capa Dura, 160 Folhas, Preto ",
                            Name = "CADERNO TILIBRA ",
                            Price = 1945m,
                            StockQuantity = 30
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
