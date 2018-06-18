namespace EmployeeData.Migrations
{
    using EmployeeData.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeData.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeData.Models.ApplicationDbContext context)
        {

            var emp = new List<Employee> {
                new Employee(){Name = "Kapil",Contact="9811846441",Email="kap@jan.com",Age=34,Gender="M"},
                new Employee(){Name = "Kapil1",Contact="9811846442",Email="kap1@jan.com",Age=35,Gender="M"},
                new Employee(){Name = "Kapil2",Contact="9811846443",Email="kap2@jan.com",Age=36,Gender="M"},
            };

            emp.ForEach(e => context.Employees.AddOrUpdate(p => p.Id, e));
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
