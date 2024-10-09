using EstoqueTechTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstoqueTechTest.Data.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed de dados para a entidade Produto
            modelBuilder.Entity<Product>().HasData(
                new Product { Category = "SMARTPHONE", Name = "SAMSUNG GALAXY S22", Description = "Smartphone Samsung Galaxy S22 5G SM-S901 128GB Câmera Tripla", Price = 296910, StockQuantity= 10},
                new Product { Category = "SMARTPHONE", Name = "APPLE IPHONE 15  ", Description = "Smartphone Apple iPhone 15 128GB Câmera Dupla", Price = 469900, StockQuantity = 7 },
                new Product { Category = "NOTEBOOK", Name = "DELL INSPIRION I7", Description = "Dell Laptop Inspiron 15 3501 15,6 FHD i7 - Intel Core i7-1165G7, RAM DDR4 16GB, SSD 512GB", Price = 419900, StockQuantity = 2 },
                new Product { Category = "MATERIAL ESCRITORIO", Name = "CADERNO TILIBRA ", Description = "Tilibra 305421 Universitário 10 Matérias Zip - Caderno Espiral, Capa Dura, 160 Folhas, Preto ", Price = 001945, StockQuantity = 30 }
            );
        }
    }
}
