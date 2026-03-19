using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV02
{
    public class Search
    {
        public static List<Product> SearchProduct(List<Product> products, Func<Product, bool> select)
        {
            List<Product> Result = new List<Product>();
            foreach (Product aproduct in products)
            {
                if (select(aproduct))
                {
                    Result.Add(aproduct);
                }
                
            }
            return Result;
        }
    }
}
