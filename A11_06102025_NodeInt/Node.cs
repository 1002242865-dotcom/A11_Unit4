using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    public class Node<T>
    {
        private T value;
        private Node<T> next;

        public Node(T value) //*
        {
            this.value = value;
            this.next = null;
        }
        public Node(T value,Node<T> next) //** تحميل زائد
        {
            this.value = value;
            this.next = next;
        }
        public void SetValue(T value)
        {
            this.value = value;
        }
        public T GetValue()
        {
            return this.value;
        }

        public void SetNext(Node<T> next)
        {
            this.next = next;
        }
        public Node<T> GetNext()
            { 
            return this.next;
        }
        public bool HasNext()
        {
            return (this.next != null);
            //اذا في حلقة امامي
        }

        public override string ToString()
        {
            return "value: " + value;
        }

    }
}
