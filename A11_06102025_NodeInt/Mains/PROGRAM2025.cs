using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt.Mains
{
    internal class PROGRAM2025
    {
        static void Main22(string[] args)
        {
        }

        public static bool Exist(Node<int> n1,int x)
        {
            while (n1 != null)
            {
                if (n1.GetValue() == x)
                    return true;
                n1=n1.GetNext();
            }
            return false;
        }

        public static Node<int> CreateUnion(Node<int> lst1,Node<int> lst2)
        {
            Node<int> lst3 = null;
            int x;
            while (lst1 != null)
            {
                x = lst1.GetValue();
                if(!Exist(lst3,x))
                    lst3 = new Node<int>(x, lst3);
                lst1=lst1.GetNext();
            }

            while (lst2 != null)
            {
                x = lst2.GetValue();
                if (!Exist(lst3, x))
                    lst3 = new Node<int>(x, lst3);
                lst2 = lst2.GetNext();
            }
            return lst3;
        }
    }
}
