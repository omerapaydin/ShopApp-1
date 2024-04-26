using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Models;

namespace Shop.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category {CategoryId=1, Name = "Telefon", ImageUrl="1.jpeg", Description = "Tlf" },
                new Category {CategoryId=2, Name = "Bilgisayar",ImageUrl="2.jpeg", Description = "Tlf" },
                new Category {CategoryId=3, Name = "Elektronik",ImageUrl="6.jpeg", Description = "Tlf" },
                new Category {CategoryId=4, Name = "Kitap",
                ImageUrl="5.jpeg",Description = "Kitap" }
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategoryById(int id)
        {
            return _categories.FirstOrDefault(c => c.CategoryId.Equals(id));
        }

    }
}