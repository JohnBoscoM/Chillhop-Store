using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data.Models
{

    public class Cart
    {
        [Key]
        public int id { get; set; }
        public Product Product { get; set; } 
        public string Quantity { get; set; }

    }
}
