using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeripteroClasses
{
    class ProductsPerFridge
    {
        public Mark Brand { get; set; }
        public List<Product> Products { get; set; }


        public ProductsPerFridge(Mark brand, List<Product> proionta)
        {
            Brand = brand;
            Products = new List<Product>(proionta);

        }


        public void ShowFridgeProducts()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"~ ~ ~ ~ ~ ~ ~ ~ ~ ~< FRIDGE  {Brand} > ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**********************************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine($"Fridge: {Brand}  has these products: ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in Products)
            {
                Console.WriteLine($"{item.Name} priced {item.Price} euro");
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("**********************************************************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }




    }
}
