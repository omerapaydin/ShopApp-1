using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String Name { get; set; }
        public String ImageUrl { get; set; }
        public String Description { get; set; }
    }
}