using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class ProgramOrder
    {
        static void Main(string[] args)
        {
            Order a1 = new Order(790);
            Order a2 = new Order(474);

            Product p1 = new Product(9888, "Milk", 7.5);
            a2.AddProduct(p1);
            a2.AddProduct(new Product(9777, "Juice", 10.9));
            a2.AddProduct(new Product(9666, "Bread", 5.3));
            a2.AddProduct(p1);
            Console.WriteLine(a2.TotalCost());
            a2.Remove(p1);
            Console.WriteLine(a2.TotalCost());
            a2.Reset();
            Console.WriteLine(a2.TotalCost());

            Console.WriteLine();
            a1.AddProduct(new Product(1234, "Eggs", 15.0));
            a1.AddProduct(new Product(2345, "Cheese", 25.0));
            Console.WriteLine(a1.TotalCost());


            Order a3=null;
            a3.AddProduct(p1);
        }
    }
}
