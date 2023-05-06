using Domain.Models.Entity;
using System.Data.Entity;

namespace Application
{
    class NgoDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User").HasKey(u => u.Id);
        }
    }
}
