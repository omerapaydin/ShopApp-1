using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Models;

namespace Shop.Data
{
    public static class ProductRepository
    {
        private static List<Product> _product = null;

        static ProductRepository()
        {
            _product = new List<Product>
            {
 new Product{ProductId=1, Name="Iphone 8",Price=3200,Description="İyi telefon",IsApproved=true,ImageUrl="1.jpeg",CategoryId=1},
                new Product{ProductId=2,Name="Iphone 10",Price=1300,Description="Fena telefon",IsApproved=true,ImageUrl="2.jpeg",CategoryId=1},
                new Product{ProductId=3,Name="Iphone 15",Price=4300,Description="Güzel telefon",IsApproved=true,ImageUrl="3.jpeg",CategoryId=1},
                new Product{ProductId=4,Name="Iphone 17",Price=36200,Description="Eh telefon",IsApproved=true,ImageUrl="4.jpeg",CategoryId=1},
                new Product{ProductId=9,Name="Iphone 19",Price=36200,Description="eh telefon",IsApproved=true,ImageUrl="1.jpeg",CategoryId=1},
                new Product{ProductId=2,Name="Iphone 10",Price=1300,Description="Fena telefon",IsApproved=true,ImageUrl="2.jpeg",CategoryId=1},
                new Product{ProductId=5, Name="Lenova 8",Price=3200,Description="İyi bilgisayar",IsApproved=true,ImageUrl="5.jpeg",CategoryId=2},
                new Product{ProductId=6,Name="Lenova 10",Price=1300,Description="Fena bilgisayar",IsApproved=true,ImageUrl="6.jpeg",CategoryId=2},
                new Product{ProductId=7,Name="Lenova 15",Price=4300,Description="Oh bilgisayar",IsApproved=true,ImageUrl="7.jpeg",CategoryId=2},
                new Product{ProductId=8,Name="Lenova 18",Price=36200,Description="eh bilgisayar",IsApproved=true,ImageUrl="8.jpeg",CategoryId=2},
                new Product{ProductId=6,Name="Lenova 10",Price=1300,Description="Fena bilgisayar",IsApproved=true,ImageUrl="6.jpeg",CategoryId=2},
                new Product{ProductId=7,Name="Lenova 15",Price=4300,Description="Oh bilgisayar",IsApproved=true,ImageUrl="7.jpeg",CategoryId=2}
            };

        }

        public static List<Product> Products
        {
            get
            {
                return _product;
            }
        }

        public static void AddProduct(Product product)
        {
            _product.Add(product);
        }
        public static Product GetProductById(int id)
        {
            return _product.FirstOrDefault(p => p.ProductId.Equals(id));
        }

        public static void EditProduct(Product product)
        {
            foreach (var p in _product)
            {
                if (p.ProductId == product.ProductId)
                {
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.ImageUrl = product.ImageUrl;
                    p.Description = product.Description;
                    p.IsApproved = product.IsApproved;
                    p.CategoryId = product.CategoryId;
                }
            }
        }

    }
}