using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Models
{
    public class Stock
    {
        public int ID { get; set; }

        [Display(Name = "Product")]
        public int? ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        public decimal Amount { get; set; }
    }
}
