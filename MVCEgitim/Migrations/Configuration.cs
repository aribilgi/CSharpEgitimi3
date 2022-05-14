namespace MVCEgitim.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCEgitim.Models.UrunDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // otomatik yükseltmeyi kabul ettik
            AutomaticMigrationDataLossAllowed = true; // db deki data kayýplarýný kabul ettik
        }

        protected override void Seed(MVCEgitim.Models.UrunDbContext context)
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
        }
    }
}
