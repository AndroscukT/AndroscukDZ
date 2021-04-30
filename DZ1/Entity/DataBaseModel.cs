using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DZ1.Entity
{
    public partial class DataBaseModel : DbContext
    {
        public DataBaseModel()
            : base("name=DataBaseModel1")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ListOfProductsInOrder> ListOfProductsInOrder { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<UserOfClient> UserOfClient { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Client)
                .HasForeignKey(e => e.ClientId);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.ListOfProductsInOrder)
                .WithRequired(e => e.Orders)
                .HasForeignKey(e => e.OrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.ListOfProductsInOrder)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserOfClient>()
                .HasMany(e => e.Client)
                .WithRequired(e => e.UserOfClient)
                .HasForeignKey(e => e.IdUserOfClient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserOfClient>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.UserOfClient)
                .HasForeignKey(e => e.IdUserOfClient)
                .WillCascadeOnDelete(false);
        }
    }
}
