using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt.Mains
{
    internal class ProgramNodeInt
    {
        static void Main4(string[] args)
        {
            NodeInt n1 = new NodeInt(10);
            NodeInt n2 = new NodeInt(20);
            NodeInt n3 = new NodeInt(30, n2);
            n1.SetValue(-100);
            Console.WriteLine(n2.GetValue());
            n3.GetNext().SetValue(900);
            n2.SetNext(n1);
            Console.WriteLine(n3);

            Console.WriteLine(n1.HasNext());
            Console.WriteLine(n2.HasNext());
            Console.WriteLine(n3.HasNext());
        }

    } 

}
