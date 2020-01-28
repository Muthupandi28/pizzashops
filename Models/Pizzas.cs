using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pizzashops.Models
{
    public class Pizzas
    {
        [Key]
        public int pizzaid { get; set; }
        [Display(Name = "Name")]
        public string pizzaname { get; set; }
        public int rate { get; set; }

    }
}