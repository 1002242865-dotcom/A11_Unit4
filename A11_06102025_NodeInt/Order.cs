using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class Order
    {
        private int Num;
        private int C_Id;
        private Node<Product> products;
        private static int counter = 0;
        private Node<Product> last; //pointer to the last node of the list

        public Order(int c_Id)
        {
            counter++;
            this.Num = counter;
            this.C_Id = c_Id;
            this.products = null;
            this.last = null;
        }

        //AddProduct: add the p product to the end of the list
        //public void AddProductV1(Product p)
        //{
        //    if(products==null)
        //        products = new Node<Product>(p);
        //    else
        //    {
        //        Node<Product> pos = products;
        //        while(pos.HasNext())
        //            pos=pos.GetNext();

        //        pos.SetNext(new Node<Product>(p));
        //    }

        //}

        public void AddProduct(Product p)
        {
            if (products == null) //the first product
            {
                products = new Node<Product>(p);
                last = products;
            }
            else //from the second product
            {
                last.SetNext(new Node<Product>(p));
                last = last.GetNext();
            }
        }

        public double TotalCost()
        {
            double total = 0;
            Node<Product> pos = products;
            while (pos != null)
            {
                total += pos.GetValue().GetPrice();
                pos = pos.GetNext();
            }
            return total;
        }

        public void Reset()
        {

            products = null;

            last = null;//msh elzami
        }

        public void Remove(Product p)  
        {
            Node<Product> tmp = null;
            Node<Product> pos = products;
            while (pos!=null)
            {
                if (pos.GetValue().GetId()!=p.GetId())
                {
                    tmp = new Node<Product>(pos.GetValue(), tmp);
                }
                pos = pos.GetNext();
            }

            products = tmp;

            last = products;
            while(last!=null && last.HasNext())
                last=last.GetNext();

            
        }
    }
}
