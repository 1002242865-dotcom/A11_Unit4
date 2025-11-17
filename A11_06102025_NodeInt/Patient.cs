using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class Patient
    {
        private int Id;
        private int Pripority;

        public Patient(int Id, int Pripority)
        {
            this.Id = Id;
            this.Pripority = Pripority;
        }

        public int GetId()
        {
            return Id;
        }
        public int GetPripority()
        {
            return Pripority;
        }

        public void SetPripority(int Pripority)
        {
            this.Pripority = Pripority;
        }

        public void SetId(int Id)
        {
            this.Id = Id;
        }


    }
}
