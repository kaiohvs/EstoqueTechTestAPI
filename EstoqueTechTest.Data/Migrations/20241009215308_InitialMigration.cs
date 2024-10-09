using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EstoqueTechTest.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("0237deba-e1ee-4368-81bc-e07a0109bf5c"), "MATERIAL ESCRITORIO", "Tilibra 305421 Universitário 10 Matérias Zip - Caderno Espiral, Capa Dura, 160 Folhas, Preto ", "CADERNO TILIBRA ", 1945m, 30 },
                    { new Guid("0607be89-30f4-4654-908e-e32e6864b319"), "SMARTPHONE", "Smartphone Samsung Galaxy S22 5G SM-S901 128GB Câmera Tripla", "SAMSUNG GALAXY S22", 296910m, 10 },
                    { new Guid("4672b80f-244b-455d-aae9-dcc93addc170"), "NOTEBOOK", "Dell Laptop Inspiron 15 3501 15,6 FHD i7 - Intel Core i7-1165G7, RAM DDR4 16GB, SSD 512GB", "DELL INSPIRION I7", 419900m, 2 },
                    { new Guid("64f78b14-2c61-47cc-a3bf-749e989f137e"), "SMARTPHONE", "Smartphone Apple iPhone 15 128GB Câmera Dupla", "APPLE IPHONE 15  ", 469900m, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
