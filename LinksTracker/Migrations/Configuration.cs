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
                new ApplicationUser { Id = "1", UserName = "cole570", PasswordHash = "Pass123", Email = "cole570@hotmail.com" }
            };

            users.ForEach(u => context.Users.AddOrUpdate(u));
            context.SaveChanges();

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

            var holes = new List<Hole>
            {
                new Hole { Id = 1, CourseId = 3, Number = 1, Par = 3, Yardage = 217, CreatedAt = DateTime.Now },
                new Hole { Id = 2, CourseId = 3, Number = 2, Par = 4, Yardage = 253, CreatedAt = DateTime.Now },
                new Hole { Id = 3, CourseId = 3, Number = 3, Par = 4, Yardage = 275, CreatedAt = DateTime.Now },
                new Hole { Id = 4, CourseId = 3, Number = 4, Par = 3, Yardage = 187, CreatedAt = DateTime.Now },
                new Hole { Id = 5, CourseId = 3, Number = 5, Par = 5, Yardage = 347, CreatedAt = DateTime.Now },
                new Hole { Id = 6, CourseId = 3, Number = 6, Par = 4, Yardage = 266, CreatedAt = DateTime.Now },
                new Hole { Id = 7, CourseId = 3, Number = 7, Par = 3, Yardage = 154, CreatedAt = DateTime.Now },
                new Hole { Id = 8, CourseId = 3, Number = 8, Par = 4, Yardage = 314, CreatedAt = DateTime.Now },
                new Hole { Id = 9, CourseId = 3, Number = 9, Par = 5, Yardage = 443, CreatedAt = DateTime.Now },
            };

            holes.ForEach(h => context.Holes.AddOrUpdate(h));
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
