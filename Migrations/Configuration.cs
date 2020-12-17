namespace EmployeeAPI.Migrations
{
    using EmployeeAPI.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeAPI.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeAPI.Data.AppDbContext context)
        {
            //Seed data for Departments and Employees provided here
            IList<Department> departments = new List<Department>();

            departments.Add(new Department() { Name = "Finance" });
            departments.Add(new Department() { Name = "HR" });

            IList<Employee> employees = new List<Employee>();

            employees.Add(new Employee()
            {
                Code = "EC-1",
                Address = "110, Birmingham Street, Ludhiana, Pb",
                DepartmentId = 1,
                Name = "Surinder Kaur",
                Gender = "Female"
            });
            employees.Add(new Employee()
            {
                Code = "EC-2",
                Address = "945, Mall Road, Shimla, H.P.",
                DepartmentId = 2,
                Name = "Ravi Sharma",
                Gender = "Male"
            });

            context.Departments.AddRange(departments);
            context.Employees.AddRange(employees);
            base.Seed(context);
        }
    }
}
