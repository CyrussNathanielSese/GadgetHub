using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GadgetHub.Models
{
    public class Sales
    {
        public int SalesID { get; set; }
        public int ProductsID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeesID { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public Products Products { get; set; }
        public Employees Employees { get; set; }
    }
}
