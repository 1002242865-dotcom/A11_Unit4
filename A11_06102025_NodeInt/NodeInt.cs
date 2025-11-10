using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class NodeInt
    {
        private int value;
        private NodeInt next;

        public NodeInt(int value, NodeInt next  )
        {
            this.value = value;
            this.next = next;
        }

        public NodeInt(int value)
        {
            this.value = value;
            this.next = null;
        }

        public void SetValue(int value)
        { this.value = value; }
        public int GetValue() 
        { return this.value; }

        public void SetNext(NodeInt next)
        { this.next = next; }
        public NodeInt GetNext()
        { return this.next; }

        public bool HasNext()
        {
            return this.next != null;
            //if(next==null) return false;
            //else
            //    return true;
        }

        public override string ToString()
        {
            return "value:"+value;
        }
    }
}
