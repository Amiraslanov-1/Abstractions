using System;
using System.Collections.Generic;
using System.Text;

namespace Task18march
{
    abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public double Millage;
        public abstract void Drive(double km);



        public virtual void ShowInfo()
        {
            Console.WriteLine($"Color - {this.Color}\nBrand - {this.Brand}\nMillage - {this.Millage}");
        }






    }
}
