#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }  
        public string Lastname { get; set; }    
        public string PostCode { get; set; }
        public string City { get; set; } 
        public string Email { get; set; }
        public string? Phonenumber { get; set; }
    }
}
