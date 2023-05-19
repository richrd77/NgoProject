namespace Application.Migrations
{
    using Application.Common.Enum;
    using Domain.Models.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Application.NgoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NgoDbContext context)
        {
            AddRolesSeed(context);
            AddTransactionsSeed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }

        private void AddRolesSeed(NgoDbContext context)
        {
            context.Set<Role>().AddOrUpdate(new Role { Type = RoleEnum.Member.ToString() });
            context.Set<Role>().AddOrUpdate(new Role { Type = RoleEnum.Volunteer.ToString() });
            context.Set<Role>().AddOrUpdate(new Role { Type = RoleEnum.Administrator.ToString() });
            context.Set<Role>().AddOrUpdate(new Role { Type = RoleEnum.FundRaiser.ToString() });
            context.Set<Role>().AddOrUpdate(new Role { Type = RoleEnum.Donor.ToString() });
        }

        private void AddTransactionsSeed(NgoDbContext context)
        {
            context.Set<Transaction>().AddOrUpdate(new Transaction { Type = TransactionTypeEnum.Donation.ToString() });
            context.Set<Transaction>().AddOrUpdate(new Transaction { Type = TransactionTypeEnum.FundRaise.ToString() });
        }
    }
}
