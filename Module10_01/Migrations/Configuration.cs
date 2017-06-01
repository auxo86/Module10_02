namespace Module10_01.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Module10_01.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            //�U���O�ɷ|�۰ʥh�P�_���ǬO�s�W����Ʈw���c
            AutomaticMigrationsEnabled = true;
            ContextKey = "Module10_01.Models.ApplicationDbContext";
        }

        protected override void Seed(Module10_01.Models.ApplicationDbContext context)
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
