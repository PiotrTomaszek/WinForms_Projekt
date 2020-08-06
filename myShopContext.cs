using System;
using System.Data.Entity;
using System.Linq;
using P4_Projekt.Model;

namespace P4_Projekt
{
    public class myShopContext : DbContext
    {
        /// <summary>
        /// W App.config znajdujê siê Connection String do faktycznej bazy danych (localhost).
        /// </summary>
        public myShopContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<myShopContext, P4_Projekt.Migrations.Configuration>());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Chart> Charts { get; set; }

        /// <summary>
        /// Ca³a konfiguracja bazy.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Klucze g³ówne
            modelBuilder.Entity<Category>().HasKey(key => key.IdCategory);
            modelBuilder.Entity<Product>().HasKey(key => key.IdProduct);
            modelBuilder.Entity<Order>().HasKey(key => key.IdOrder);
            modelBuilder.Entity<Client>().HasKey(key => key.IdClient);
            modelBuilder.Entity<Chart>().HasKey(key => new { key.IdOrder, key.IdProduct });

            // Tworzenie tabel
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Chart>().ToTable("Chart");

            // Tworzenie relacji
            modelBuilder.Entity<Product>()
                .HasRequired<Category>(p => p.Category)
                .WithMany(c => c.Product)
                .HasForeignKey<int>(x => x.IdCategory);

            // Z³e
            //modelBuilder.Entity<Chart>()
            //    .HasRequired<Product>(p => p.Product)
            //    .WithOptional(c => c.Chart);

            //modelBuilder.Entity<Chart>()
            //    .HasRequired<Order>(o => o.Order)
            //    .WithMany(c => c.Charts)
            //    .HasForeignKey<int>(key => key.IdOrder);

            modelBuilder.Entity<Order>()
                .HasRequired<Client>(c => c.Client)
                .WithMany(o => o.Orders)
                .HasForeignKey<int>(key => key.IdClient);
         
            // Nowe
            modelBuilder.Entity<Order>()
                .HasMany(e => e.Charts)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Chart)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

        }
    }
}