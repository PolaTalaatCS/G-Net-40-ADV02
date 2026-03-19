using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV02
{
    public class Search
    {
        public static List<Product> SearchProduct(List<Product> products, Func<Product, bool> selector)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in products)
            {
                if (selector(product))
                {
                    result.Add(product);
                }
                
            }
            return result;
        }
    }
}
