using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt.Mains
{
    internal class ProgramNodeString
    {
        static void Main0(string[] args)
        {
            NodeString names = new NodeString("Mohammad");
            names.SetNext(new NodeString("Yazan")); 
           
        }

    }
}
