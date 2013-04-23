using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BeerShop.Models
{
    public class Customer : User
    {
        
        // public Basket basket { get; set; }
        // public List<Order> ordersList { get; set; }
    }
    public class CustomersDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}