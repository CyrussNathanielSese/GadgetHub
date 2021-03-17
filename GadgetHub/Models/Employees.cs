using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GadgetHub.Models
{
    public class Employees
    {
        public int EmployeesID { get; set; }
        [Display(Name = "First Name")]
        public string EmployerFirstname { get; set; }
        [Display(Name = "Last Name")]
        public string EmployerLastname { get; set; }
        [Display(Name = "Address")]
        public string EmployerAddress { get; set; }
        [Display(Name = "Contact Number")]
        public int EmployerContactNumber { get; set; }

    }
}
