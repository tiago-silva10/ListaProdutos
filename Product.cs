using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avaliacao.Models
{
    public class Product
    {
        public Product()
        {
            Id = 0;
        }
        public Product(int id, string name, decimal price, IEnumerable<Category> categories, IEnumerable<string> tags, bool isDisabled = false)
        {
            Id = id;
            Name = name;
            Price = price;
            Categories = categories.ToList();
            Tags = tags.ToList();
            IsDisabled = isDisabled;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<Category> Categories { get; set; }
        public List<string> Tags { get; set; }
        public bool IsDisabled { get; set; }
    }
}