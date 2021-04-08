using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GadgetHub.Models
{
    public class Products
    {
        public int ProductsID { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Product Brand")]
        public string ProductBrand { get; set; }
        public string Supplier { get; set; }
    }
}