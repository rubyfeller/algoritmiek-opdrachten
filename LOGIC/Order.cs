using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithm
{
    public class Order
    {
        Product product = new Product();

        public double GiveMaximumPrice()
        {
            var list = product.GetProducts();

            double maxPrice = 0;
            foreach (var item in list)
            {
                if (item.Price > maxPrice)
                {
                    maxPrice = item.Price;
                }
            }

            return maxPrice;
        }

        public double GiveAveragePrice()
        {
            var list = product.GetProducts();

            // Get average price of product the hard way
            double sum = 0;
            foreach (var item in list)
            {
                sum += item.Price;
            }
            double avgPrice = sum / list.Count;

            return avgPrice;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = product.GetProducts();
            return products;
        }

        public List<Product> SortProductsByPrice()
        {
            var list = product.GetProducts();

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].Price < list[j].Price)
                    {
                        var temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            return list;
        }
    }
}
