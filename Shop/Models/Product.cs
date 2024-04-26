using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public String Name { get; set; }
        public double? Price { get; set; }
        public String ImageUrl { get; set; }
        public String Description { get; set; }
        public bool IsApproved { get; set; }
        public int? CategoryId { get; set; }
    }
}