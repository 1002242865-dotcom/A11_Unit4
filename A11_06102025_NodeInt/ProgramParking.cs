using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class ProgramParking
    {
        static void Main3(string[] args)
        {
            //Good Morning A11 09/10/2025

            Parking p1 = new Parking("Ahleya");
            Console.WriteLine(p1.Free());

            Car c1 = new Car(11122333, 2020, "White", false);
            Console.WriteLine(c1);
            bool flag = p1.Add(c1);
            if(flag)
                Console.WriteLine("Ok, empty places:"+p1.Free());
            else
                Console.WriteLine("Not Inserted");

             flag = p1.Add(c1);
            if (flag)
                Console.WriteLine("Ok, empty places:" + p1.Free());
            else
                Console.WriteLine("Not Inserted");


            bool flag2=p1.Remove(c1);
            flag2 = p1.Remove(c1);
        }
    }
}
