using GadgetHub.Data;
using GadgetHub.Models;
using System;
using System.Linq;

namespace GadgetHub.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GadgetHubContext context)
        {
            context.Database.EnsureCreated();

            // Look for any customer.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
              new Customer { CustomerFirstname = "Aryan", CustomerLastname = "Shah", CustomerAddress = "45 Great North Road", CustomerContactNumber = "02182374932" },
              new Customer { CustomerFirstname = "Brooklyn", CustomerLastname = "Eti", CustomerAddress = "27 Brook Street", CustomerContactNumber = "02342058462" },
              new Customer { CustomerFirstname = "Zara", CustomerLastname = "Colaco", CustomerAddress = "35 Delta Avenue", CustomerContactNumber = "02324839583" },
              new Customer { CustomerFirstname = "Kian", CustomerLastname = "Chico", CustomerAddress = "7 Titirangi Road", CustomerContactNumber = "02103284396" },
              new Customer { CustomerFirstname = "Faith", CustomerLastname = "Dahunan", CustomerAddress = "85 Glen Eden Road", CustomerContactNumber = "02103859485" },
              new Customer { CustomerFirstname = "Jarred", CustomerLastname = "Malijan", CustomerAddress = "19 New North Road", CustomerContactNumber = "02105866934" },
            };

            context.Customer.AddRange(customers);
            context.SaveChanges();

            var employees = new Employees[]
            {
               new Employees { EmployerFirstname = "Cyruss", EmployerLastname = "Sese", EmployerAddress = "60 Holly Street", EmployerContactNumber = "02108044689" },
               new Employees { EmployerFirstname = "Ivan", EmployerLastname = "Lee", EmployerAddress = "	10 Kelwyn Road", EmployerContactNumber = "02134940294" },
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();

            var products = new Products[]
            {
              new Products { ProductName = "Iphone 11", ProductBrand = "Apple", Supplier =  "Apple Inc." },
              new Products { ProductName = "Iphone 11 Pro", ProductBrand = "Apple", Supplier =  "Apple Inc." },
              new Products { ProductName = "Iphone 12 ", ProductBrand = "Apple", Supplier =  "Apple Inc." },
              new Products { ProductName = "Iphone 12 Pro", ProductBrand = "Apple", Supplier =  "Apple Inc." },
              new Products { ProductName = "Iphone 12 Pro Max", ProductBrand = "Apple", Supplier =  "Apple Inc." },
              new Products { ProductName = "Samsung Galaxy S21 5G", ProductBrand = "Samsung", Supplier =  "Samsung Inc." },
              new Products { ProductName = "Samsung Galaxy S21 Ultra 5G", ProductBrand = "Samsung", Supplier =  "Samsung Inc." },
              new Products { ProductName = "Huawei Nova 5T", ProductBrand = "Huawei", Supplier =  "Huawei Inc." },
              new Products { ProductName = "Huawei Mate 40 Pro", ProductBrand = "Huawei", Supplier =  "Huawei Inc." },
              new Products { ProductName = "Asus Zenfone 5", ProductBrand = "Asus", Supplier =  "Asus Inc." },
              new Products { ProductName = "Rog Phone 5", ProductBrand = "Asus", Supplier =  "Asus Inc." },
              new Products { ProductName = "Rog Phone 5 Ultimate", ProductBrand = "Asus", Supplier =  "Asus Inc." },
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var sales = new Sales[]
            {
                new Sales { ProductsID = products.Single(s => s.ProductName == "Huawei Nova 5t").ProductsID,
                            CustomerID = customers.Single(s => s.CustomerFirstname == "Aryan").CustomerID,
                            EmployeesID = employees.Single(s => s.EmployerFirstname == "Cyruss").EmployeesID}
               
            };

            context.Sales.AddRange(sales);
            context.SaveChanges();
        }
    }
}