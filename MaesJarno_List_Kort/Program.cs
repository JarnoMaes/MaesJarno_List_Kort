using MaesJarno_List_Kort.Interface;
using MaesJarno_List_Kort.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaesJarno_List_Kort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProduct> products = new List<IProduct>();

            Product p1 = new Product("Cola","Zero","150 ml");
            products.Add(p1);
            Product p2 = new Product("Fanta", "Lemon", "1000 ml");
            products.Add(p2);
            Product p3 = new Product("Soda", "Gas", "150 ml");
            products.Add(p3);

            foreach (var item in products)
            {
                Console.WriteLine(item.GetCode());
            }
        }
    }
}
