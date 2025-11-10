using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class NodeString
    {
        private string value;
        private NodeString next;

        public NodeString(string value, NodeString next)
        {
            this.value = value;
            this.next = next;
        }

        public NodeString(string value)
        {
            this.value = value;
            this.next = null;
        }

        public void SetValue(string value)
        { this.value = value; }
        public string GetValue()
        { return this.value; }

        public void SetNext(NodeString next)
        { this.next = next; }
        public NodeString GetNext()
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
            return "value:" + value;
        }
    }
}
