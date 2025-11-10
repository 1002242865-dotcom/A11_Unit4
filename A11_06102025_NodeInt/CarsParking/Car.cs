using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt.CarsParking
{
    internal class Car
    {
        private int num;
        private int year;
        private string color;
        private bool isSport;
        public Car(int num, int year, string color, bool isSport)
        {
            this.num = num;
            this.year = year;
            this.color = color;
            this.isSport = isSport;
        }

        public void SetNum(int num)
        { this.num = num; }
        public int GetNum() 
        { return num; }

        public void SetYear(int year)
        { this.year = year; }
        public int GetYear() 
        { return year; }

        public void SetColor(string color) 
        { this.color = color; }
        public string GetColor() 
        { return color; }

        public void SetIsSport(bool isSpprt) { isSport = isSport; }
        public bool GetIsSport() 
        { return isSport; }

        public override string ToString()
        {
            return "Num:"+num+", Year:"+year+", Color:"+color+", IsSport:"+isSport;
        }
    }
} 
