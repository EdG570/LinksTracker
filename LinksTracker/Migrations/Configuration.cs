using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

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
            // USERS
            var store = new UserStore<ApplicationUser>(context);
            var manager = new UserManager<ApplicationUser>(store);
            var user = new ApplicationUser { UserName = "cole570", Email = "cole570@hotmail.com" };

            manager.Create(user, "Pass123!");

            //// COURSES
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


            //// HOLES
            var holes = new List<Hole>
            {
                new Hole { Id = 1, CourseId = 1, Number = 1, Par = 3, Yardage = 217, CreatedAt = DateTime.Now },
                new Hole { Id = 2, CourseId = 1, Number = 2, Par = 4, Yardage = 253, CreatedAt = DateTime.Now },
                new Hole { Id = 3, CourseId = 1, Number = 3, Par = 4, Yardage = 275, CreatedAt = DateTime.Now },
                new Hole { Id = 4, CourseId = 1, Number = 4, Par = 3, Yardage = 187, CreatedAt = DateTime.Now },
                new Hole { Id = 5, CourseId = 1, Number = 5, Par = 5, Yardage = 347, CreatedAt = DateTime.Now },
                new Hole { Id = 6, CourseId = 1, Number = 6, Par = 4, Yardage = 266, CreatedAt = DateTime.Now },
                new Hole { Id = 7, CourseId = 1, Number = 7, Par = 3, Yardage = 154, CreatedAt = DateTime.Now },
                new Hole { Id = 8, CourseId = 1, Number = 8, Par = 4, Yardage = 314, CreatedAt = DateTime.Now },
                new Hole { Id = 9, CourseId = 1, Number = 9, Par = 5, Yardage = 443, CreatedAt = DateTime.Now },
            };

            holes.ForEach(h => context.Holes.AddOrUpdate(h));
            context.SaveChanges();


            // STATS
            var stats = new List<Stats>
            {
                new Stats
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    FIR = true,
                    GIR = false,
                    HoleId = 2,
                    Penalties = 0,
                    Putts = 2,
                    Score = 4,
                    UpAndDown = true,
                    UserId = user.Id
                },
                new Stats
                {
                    Id = 2,
                    CreatedAt = DateTime.Now,
                    FIR = false,
                    GIR = true,
                    HoleId = 3,
                    Penalties = 1,
                    Putts = 3,
                    Score = 7,
                    UpAndDown = false,
                    UserId = user.Id
                },
                new Stats
                {
                    Id = 3,
                    CreatedAt = DateTime.Now,
                    FIR = false,
                    GIR = true,
                    HoleId = 4,
                    Penalties = 0,
                    Putts = 1,
                    Score = 4,
                    UpAndDown = true,
                    UserId = user.Id
                },
                new Stats
                {
                    Id = 4,
                    CreatedAt = DateTime.Now,
                    FIR = true,
                    GIR = true,
                    HoleId = 5,
                    Penalties = 0,
                    Putts = 1,
                    Score = 3,
                    UpAndDown = true,
                    UserId = user.Id
                },
                new Stats
                {
                    Id = 5,
                    CreatedAt = DateTime.Now,
                    FIR = true,
                    GIR = true,
                    HoleId = 6,
                    Penalties = 0,
                    Putts = 1,
                    Score = 4,
                    UpAndDown = true,
                    UserId = user.Id
                },
                new Stats
                {
                    Id = 6,
                    CreatedAt = DateTime.Now,
                    FIR = false,
                    GIR = false,
                    HoleId = 7,
                    Penalties = 1,
                    Putts = 4,
                    Score = 8,
                    UpAndDown = false,
                    UserId = user.Id
                },
                new Stats
                {
                    Id = 7,
                    CreatedAt = DateTime.Now,
                    FIR = true,
                    GIR = true,
                    HoleId = 8,
                    Penalties = 0,
                    Putts = 1,
                    Score = 2,
                    UpAndDown = true,
                    UserId = user.Id
                },
                new Stats
                {
                    Id = 8,
                    CreatedAt = DateTime.Now,
                    FIR = true,
                    GIR = false,
                    HoleId = 9,
                    Penalties = 0,
                    Putts = 2,
                    Score = 5,
                    UpAndDown = false,
                    UserId = user.Id
                },
                new Stats
                {
                    Id = 9,
                    CreatedAt = DateTime.Now,
                    FIR = false,
                    GIR = false,
                    HoleId = 10,
                    Penalties = 0,
                    Putts = 2,
                    Score = 5,
                    UpAndDown = true,
                    UserId = user.Id
                }
            };

            stats.ForEach(s => context.Stats.AddOrUpdate(s));
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
