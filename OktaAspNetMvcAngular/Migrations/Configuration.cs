using OktaAspNetMvcAngular.Models;

namespace OktaAspNetMvcAngular.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OktaAspNetMvcAngular.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OktaAspNetMvcAngular.Data.ApplicationDbContext";
        }

        protected override void Seed(OktaAspNetMvcAngular.Data.ApplicationDbContext context)
        {
            context.JoggingRecords.AddOrUpdate(x => x.Id,
                new JoggingRecord { Id = 1, Description = "Friday Evening", Distance = 5.5f, CreatedAt = new DateTime(2018, 5, 1) },
                new JoggingRecord { Id = 2, Description = "Saturday morning", Distance = 6.15f, CreatedAt = new DateTime(2018, 4, 4) },
                new JoggingRecord { Id = 3, Description = "Marathon", Distance = 20, CreatedAt = new DateTime(2018, 5, 13) },
                new JoggingRecord { Id = 4, Description = "Short one", Distance = 3.5f, CreatedAt = new DateTime(2018, 6, 6) }
            );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
