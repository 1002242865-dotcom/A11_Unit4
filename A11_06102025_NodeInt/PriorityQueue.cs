using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class PriorityQueue
    {
        private Queue<Patient> q=new Queue<Patient>();


        public void PriorityInsert(Patient p)
        {
            if (q.IsEmpty()) ///اول مريض ياتي
                q.Insert(p);
            else
            {
                Queue<Patient> temp = new Queue<Patient>();

                while (!q.IsEmpty() && q.Head().GetPripority() >= p.GetPripority())
                {
                    temp.Insert(q.Remove());
                }

                temp.Insert(p);

                while (!q.IsEmpty())
                {
                    temp.Insert(q.Remove());
                }

                //this.q = temp;//yes right
                //or
                while(!temp.IsEmpty())
                {
                    q.Insert( temp.Remove());
                }
            }
                
        }
    }
}
