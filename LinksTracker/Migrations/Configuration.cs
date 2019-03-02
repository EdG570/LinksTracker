namespace LinksTracker.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LinksTracker.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LinksTracker.Models.ApplicationDbContext context)
        {
            var users = new List<ApplicationUser>
            {
                new ApplicationUser { Id = "1", UserName = "cole570", PasswordHash = "Pass123" }
            };

            users.ForEach(u => context.Users.AddOrUpdate(u));

            var courses = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Name = "Morgan Hills",
                    Address = "123 Hillside Drive",
                    City = "Hunlock Township",
                    State = "PA",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "cole570",
                    TotalHoles = 9,
                    Par = 72,
                    Rating = 1.23,
                    Slope = 1.564
                }
            };

            courses.ForEach(c => context.Courses.AddOrUpdate(c));

            context.SaveChanges();

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
        }
    }
}
