using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt.CarsParking
{
    internal class ParkingSuper
    {
        private string name;
        private Car[] cars;
        private int current; // كم سيارة الان في الموقف
        public const int MAX = 100;

        public ParkingSuper(string name)
        {
            this.name = name;
            current = 0;
            cars = new Car[MAX];
        }

        public int  Free()
        {
            return MAX - current;
        }

        public bool Add(Car c1)
        {
            if (current == MAX)
                return false;

            cars[current] = c1;
            current++;
            return true;
        }

        public bool Remove(Car c1)
        {
            {
                for(int i=0;i<current;i++)
                {
                    if (cars[i].GetNum()==c1.GetNum())
                    {
                        Car lastCar = cars[current - 1];
                        cars[i] = lastCar;
                        cars[current - 1] = null;
                        current--;
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
