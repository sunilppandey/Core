namespace Core.Data.Migrations
{
    using Entities;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Core.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Core.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var manager = new ApplicationUserManager(new ApplicationUserStore(new ApplicationDbContext()));
 
            var user = new ApplicationUser()
            {
                UserName = "sunilp",
                Email = "sunilppandey@gmail.com",
                EmailConfirmed = true,
                FirstName = "Sunil",
                LastName = "Pandey",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-3)
            };
 
            manager.Create(user, "Password@123");
        }
    }
}
