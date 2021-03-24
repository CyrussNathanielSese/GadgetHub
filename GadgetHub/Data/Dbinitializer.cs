using GadgetHub.Data;
using GadgetHub.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GadgetHubContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
              new Customer { CustomerFirstname = "Aryan", CustomerLastname = "Shah", CustomerAddress = "45 Great North Road", CustomerContactNumber = "02182374932" }
            };

            context.Customer.AddRange(customers);
            context.SaveChanges();

            var employees = new Employees[]
            {
               
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();

            var products = new Products[]
            {
              
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var sales = new Sales[]
            {

            };

            context.Sales.AddRange(sales);
            context.SaveChanges();
        }
    }
}