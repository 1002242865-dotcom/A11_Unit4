using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt.Store
{
    internal class Product
    {
        private int Id;
        private string Name;
        private double Price;
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        
       

        public void SetId(int id)
        { Id = id; }
        public int GetId()
        { return Id; }
        public void SetName(string name)
        { Name = name; }
        public string GetName()
        { return Name; }
        public void SetPrice(double price)
        { Price = price; }
        public double GetPrice()
        { return Price; }
        public override string ToString()
        {
            return "Id:" + Id + ", Name:" + Name + ", Price:" + Price;
        }
    }
}
