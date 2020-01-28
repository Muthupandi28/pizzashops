using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Pizzashops.Models;
namespace Pizzashops.Data
{
    public class PizzashopsContext : DbContext
    {
        
    
        public PizzashopsContext() : base("name=PizzashopsContext")
        {
        }

        public DbSet<Pizzas> Pizzas { get; set; }
    }
}
