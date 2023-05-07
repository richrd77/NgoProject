using Domain.Models.Entity;
using System.Data.Entity;

namespace Application
{
    class NgoDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User").HasKey(u => u.Id).HasRequired(u => u.Role).WithMany(r => r.Users);
            modelBuilder.Entity<Role>().ToTable("Role").HasKey(u => u.Id).HasMany(r => r.Users).WithRequired(u => u.Role);
            modelBuilder.Entity<Money>().ToTable("Money").HasKey(u => u.Id).HasRequired(u => u.TransactionType).WithMany(r => r.Transactions);
            modelBuilder.Entity<Transaction>().ToTable("Transaction").HasKey(u => u.Id).HasMany(r => r.Transactions).WithRequired(u => u.TransactionType);
            modelBuilder.Entity<Event>().ToTable("Event").HasKey(u => u.Id);
        }
    }
}
