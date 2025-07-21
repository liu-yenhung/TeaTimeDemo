using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TeaTimeDemo.Models;
using TeaTimeDemo.Models.Models;

namespace TeaTimeDemo.DataAccess.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){ }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "茶飲", DisplayOrder = 1 },
                new Category { Id = 2, Name = "水果茶", DisplayOrder = 2 },
                new Category { Id = 3, Name = "咖啡", DisplayOrder = 3 }
                );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "台灣水果茶",
                    Size = "大杯",
                    Description = "天然果飲",
                    Price = 60
                },

                new Product
                {
                    Id = 2,
                    Name = "鐵觀音",
                    Size = "中杯",
                    Description = "人生味道",
                    Price = 160
                },

                new Product
                {
                    Id = 3,
                    Name = "美式咖啡",
                    Size = "特大杯",
                    Description = "休閒時光",
                    Price = 260
                }


            );
        }


    }

}
