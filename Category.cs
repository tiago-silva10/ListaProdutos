using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avaliacao.Models
{
    public class Category
    {
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}