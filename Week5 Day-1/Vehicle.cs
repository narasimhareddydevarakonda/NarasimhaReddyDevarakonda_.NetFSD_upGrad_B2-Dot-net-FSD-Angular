using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day_1
{
    class Vehicle
    {
        public string Brand { get; set; }
        public double RentalRatePerDay { get; set; }

        public Vehicle(string brand, double rate)
        {
            Brand = brand;
            RentalRatePerDay = rate;
        }

        // Virtual Method
        public virtual double CalculateRental(int days)
        {
            return RentalRatePerDay * days;
        }
    }

    // Derived Class: Car
    class Car : Vehicle
    {
        public Car(string brand, double rate) : base(brand, rate) { }

        public override double CalculateRental(int days)
        {
            double total = RentalRatePerDay * days;
            return total + 500; // Insurance charge
        }
    }

    // Derived Class: Bike
    class Bike : Vehicle
    {
        public Bike(string brand, double rate) : base(brand, rate) { }

        public override double CalculateRental(int days)
        {
            double total = RentalRatePerDay * days;
            return total - (total * 0.05); // 5% discount
        }
    }
}
