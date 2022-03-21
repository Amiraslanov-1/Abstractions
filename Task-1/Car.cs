using System;
using System.Collections.Generic;
using System.Text;

namespace Task18march
{
    class Car:Vehicle
    {
        private double _fuelCapacity;
        private double _fuelForOneKm;
        private double _currentFuel;

        public Car(double Millage, double FuelCapacity, double FuelForOneKm, double CurrentFuel)
        {
            this.Millage = Millage;
            this.FuelCapacity = FuelCapacity;
            this.FuelForOneKm = FuelForOneKm;
            this.CurrentFuel = CurrentFuel;
        }

        public double FuelCapacity
        {
            get { return _fuelCapacity; }
            set {
                if (value>0&&value<=60)
                {
                    this._fuelCapacity = value;
                }
            
            }
        }
        public double FuelForOneKm
        {
            get { return _fuelForOneKm; }
            set
            {
                if (value >=0 )
                {
                    this._fuelForOneKm = value;
                }

            }
        }
        public double CurrentFuel
        {
            get { return _currentFuel; }
            set
            {
                if (value > 0)
                {
                    this._currentFuel = value;
                }

            }
        }

        public override void Drive(double km)
        {

            if (CurrentFuel <= FuelCapacity)
            {


                if (CurrentFuel / FuelForOneKm >= km)
                {
                    Millage += km;
                    CurrentFuel -= FuelForOneKm * km;
                }
                 Console.WriteLine("Fuel is not enough!!!");
            }
                Console.WriteLine("FuelCapacity < CurrentFuel   A miracle   ");
        }




        public string GetInfo()
        {
            return  $"Color - {this.Color}\nBrand - {this.Brand}\nMillage - {this.Millage}\nFuel Capacity - {this.FuelCapacity}";
        }
    }
}
