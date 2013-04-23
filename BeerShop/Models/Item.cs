using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace BeerShop.Models
{
    public class Item
    {
        [Key]
        public int ItemID { set; get; }

        [Required]
        public string name { set; get; }
        // TODO add image field
        
        public string description { set; get; }

        [Range(0, int.MaxValue)]
        public int stockCount { set; get; }

        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        
        //public List<Categories> categoriesList;
        //public List<Comment> commentsList;

        [Required]
        public Boolean isStillOnSale { set; get; }
    }
    public class ItemDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}
