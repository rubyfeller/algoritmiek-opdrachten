using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithm
{
    public class Product
    {
        public string Name { get; set; }
        public Double Price { get; set; }
        
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Lifejacket", Price = 48.95 });
            products.Add(new Product { Name = "Soccer ball", Price = 19.50 });
            products.Add(new Product { Name = "Corner flag", Price = 34.95 });

            return products;
        }
    }
}
