using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV02
{
    #region Task 3.1
    public class Report
    {
        public static void Printreport(List<Product> products, Action<Product> action)
        {
            foreach (Product product in products)
            {
                action(product);
            }
        }
    #endregion
        #region Task 3.2
        public static List<T> TransformProducts<T>(List<Product> products, Func<Product, T> transformer)
        {
            List<T> result = new List<T>();

            foreach (var product in products)
            {
                result.Add(transformer(product)); 
            }

            return result;
        }
        #endregion
    }
    }


