using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    public class Queue<T>
    {
        private Node<T> first;
        private Node<T> last;


        public Queue()
        {
            this.first = null;
            this.last = null;
        }
        public void Insert(T x)
        {
            Node<T> temp = new Node<T>(x);
            if (first == null)
                first = temp;
            else
                last.SetNext(temp);
            last = temp;
        }
        public T Remove()
        {
            T x = first.GetValue();
            first = first.GetNext();
            if (first == null)
                last = null;
            return x;
        }
        public T Head()
        {
            return first.GetValue();
        }
        public bool IsEmpty()
        {
            return first == null;
        }
        public String ToString()
        {
            String s = "[";
            Node<T> p = this.first;
            while (p != null)
            {
                s = s + p.GetValue().ToString();
                if (p.GetNext() != null)
                    s = s + ",";
                p = p.GetNext();
            }
            s = s + "]";
            return s;
        }


    }
}
