using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GadgetHub.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Display(Name = "First Name")]
        public string CustomerFirstname { get; set; }
        [Display(Name = "Last Name")]
        public string CustomerLastname { get; set; }
        [Display(Name = "Customer Address")]
        public string CustomerAddress { get; set; }
        public int Postcode { get; set; }
        [Display(Name = "Contact Number")]
        public int CustomerContactNumber { get; set; }

    }
}
