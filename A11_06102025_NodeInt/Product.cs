using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class Product
    {
        private int Id;
        private string Name;
        private double Price;
        public Product(int id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        
       

        public void SetId(int id)
        { this.Id = id; }
        public int GetId()
        { return this.Id; }
        public void SetName(string name)
        { this.Name = name; }
        public string GetName()
        { return this.Name; }
        public void SetPrice(double price)
        { this.Price = price; }
        public double GetPrice()
        { return this.Price; }
        public override string ToString()
        {
            return "Id:" + Id + ", Name:" + Name + ", Price:" + Price;
        }
    }
}
