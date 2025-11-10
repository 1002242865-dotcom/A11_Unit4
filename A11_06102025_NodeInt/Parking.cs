using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class Parking
    {
        private string name;
        private Car[] cars;
        public const int MAX = 100;

        public Parking(string name)
        {
            this.name = name;
            cars=new Car[MAX];
        }

        //اضافة سيارة الى اول مكان فارغ، اذا تم تعيد صدق والا كذب
        public bool Add(Car c1)
        {
            //how to add the car to the first empty place?
            for (int i = 0; i < cars.Length; i++)
                if (cars[i] == null)
                {
                    cars[i] = c1;
                   return true;
                }
                   
            return false;
        }

        //تقوم بحذف السيارة التي رقمها مطابق للمتلقاة، 
        //اذا تم تعيد صدق والا كذب
        public bool Remove(Car c1)
        {
            for (int i = 0; i < MAX; i++)
                if (cars[i] != null && cars[i].GetNum() == c1.GetNum() )
                {
                    cars[i] = null;
                    return true;
                }
                    
            return false;
        }

        public int Count(int y,string str)
        {
            int c = 0;
            Car cr;
            for(int i=0;i<cars.Length;i++)
            {
                if (cars[i]!=null)
                {
                    cr = cars[i];
                    if (cr.GetYear() == y && cr.GetColor().CompareTo(str) == 0 && cr.GetIsSport())
                        c++;
                }
            }
            return c;
        }

        //تعيد عدد الاماكن الفارغة في الموقف
        public int Free()
        {
            int c = 0;
            for (int i = 0; i < cars.Length; i++)
                if (cars[i] == null)
                    c++;
            return c;
        }


        
    }
}
