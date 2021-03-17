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
        [Required]
        public string EmployerFirstname { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string EmployerLastname { get; set; }
        [Display(Name = "Address")]
        [Required]
        public string EmployerAddress { get; set; }
        [Display(Name = "Contact Number")]
        [Required]
        [Phone]
        public string EmployerContactNumber { get; set; }

    }
}
