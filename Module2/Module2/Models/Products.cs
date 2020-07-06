using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Module2.Models
{
    public class Products
    {
        [Key]
        public int Product_Id { get; set; }

        //[Required]
        public string Product_Name { get; set; }

        public string Product_Price { get; set; }
    }
}
