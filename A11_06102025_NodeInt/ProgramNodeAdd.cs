using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class ProgramNodeAdd
    {
        static void Main999(string[] args)
        {
            int[] a = { -20, -10, 6, 20, 4000 };
            Node<int> n1 = ArrayToNode(a);



           // n1 = null;
            PrintChain(n1);
            Console.WriteLine("Enter x value");
            int x=int.Parse(Console.ReadLine());
            n1=AddSorted2(n1, x);


            PrintChain(n1);


        }


        public static void AddSorted1(Node<int> n1,int x)
        {
            if (n1 == null)
                n1 = new Node<int>(x);
            else if (x < n1.GetValue())
                n1 = new Node<int>(x, n1);
            else
            {
                Node<int> pos = n1;
                Node<int> tmp = null;  
                while (pos.HasNext() && tmp == null)
                {
                    if (x > pos.GetValue() && x < pos.GetNext().GetValue())
                    {
                        tmp = pos.GetNext();
                        pos.SetNext(new Node<int>(x, tmp));
                    }
                    pos = pos.GetNext();
                }

                if (tmp == null) // reached end without inserting
                    pos.SetNext(new Node<int>(x));
            }
        }



        public static Node<int> AddSorted2(Node<int> n1, int x)
        {
            if (n1 == null) // empty list
                return new Node<int>(x);

            if (x < n1.GetValue()) // insert at head
                return new Node<int>(x, n1);

            // insert in middle or end
            Node<int> pos = n1;
            while (pos.HasNext())
            {
                // insert between pos and pos.GetNext()
                if (x > pos.GetValue() && x < pos.GetNext().GetValue())
                {
                    pos.SetNext(new Node<int>(x, pos.GetNext()));
                    return n1;
                }
                pos = pos.GetNext();
            }
                   
            pos.SetNext(new Node<int>(x));
            return n1;
             
        }

        public static Node<int> ArrayToNode(int[] arr)
        {
            Node<int> tmp = null;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                tmp = new Node<int>(arr[i], tmp);
            }
            return tmp;
        }
           
        

    public static void PrintChain<T>(Node<T> head)
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.GetValue() + "  -> ");
                current = current.GetNext();
            }
            Console.WriteLine("null");
        }
    }
    }
