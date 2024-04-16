using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_OOP.Models
{
    public class Product
    {
        public string Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Product(string id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
