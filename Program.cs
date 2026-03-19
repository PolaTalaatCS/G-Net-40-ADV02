namespace G_Net_40_ADV02
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            List<Product> catalog = new()
            {
               new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
                new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
                new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
                new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
            };
            var electorncs = Search.SearchProduct(catalog, p => p.Category == "Electronics");
            var underfifydollar = Search.SearchProduct(catalog, p => p.Price < 50);
            var Instok = Search.SearchProduct(catalog, p => p.Stock > 0);
            var clothingprice = Search.SearchProduct(catalog, p => p.Price < 100 && p.Category == "Clothing");
            Console.WriteLine("===============Electronics=============");
                foreach(var item  in electorncs)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("========= Under 50 =======");
            foreach (var item in underfifydollar)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("========= In Stock=======");
            foreach (var item in Instok)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("=========Clothing < 100=======");
            foreach (var item in clothingprice)
            {
                Console.WriteLine(item.Name);
            }

            #endregion
            #region Task 3.1 
            Console.WriteLine("Short report");
            Report.Printreport(catalog, p => Console.WriteLine($"{p.Name} - {p.Price}\n"));
            Console.WriteLine("detailed report");
                Report.Printreport(catalog, p => Console.WriteLine($" [{p.Category}]{p.Name} | {p.Price} | {p.Stock}"));

            #endregion

        }
    }
}

    




