using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Logistics
{
    // 8. LSP: Liskov Substitiution Principle

    // Violated: Electric truck changes the meaning of Refuel(). Hence not substitutable
    public class Truck
    {
        public virtual void Refuel()
        {
            Console.WriteLine("Refueling diesel");
        }
    }

    public class ElectricTruck : Truck
    {
        public override void Refuel()
        {
            Console.WriteLine("Electric truck cannot use diesel");
        }
    }

    // Fixed: Etruck is not forced to implement Refueling behaviour
    // Hence substitution works correctly
    public interface IFuelTruck
    {
        void Refuel();
    }
    public class DieselTruck : IFuelTruck
    {
        public void Refuel()
        {
            Console.WriteLine("Refueling Diesel");
        }
    }

    public class ETruck
    {
        public void Charge()
        {
            Console.WriteLine("Charging battery");
        }
    }
}
