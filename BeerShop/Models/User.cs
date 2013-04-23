using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace BeerShop.Models
{
    abstract public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        [RegularExpression(".+@.+")]
        public string email { get; set; }
        
        [Required]
        public string password { get; set; }
        
        public string phone { get; set; }
        public string address { get; set; }

        [Required]
        public DateTime birth { get; set; }

        public bool locked { get; set; }
    }

}