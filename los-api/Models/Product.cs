using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
        public List<Stock> Stock { get; set; }
    }
}
