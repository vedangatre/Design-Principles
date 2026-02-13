using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics
{
    // 10. DIP: Dependency Inversion Principle
    // Violated: DService directly depends on truck, if we want to use Ship, etc we must modify DService
    public class Vehicle
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by truck");
        }
    }

    public class DService
    {
        private Vehicle _truck = new Vehicle();
        public void StartDelivery()
        {
            _truck.Deliver();
        }
    }

    // Fixed: Loose Coupling, which allows switching between Ship/Van/Truck, etc
    public interface IVehicle 
    {
        void Deliver();
    }
    public class Ship : IVehicle
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by ship");
        }
    }
    public class Van : IVehicle
    {
        public void Deliver()
        {
			Console.WriteLine("Delivering by van");
		}
    }

    public class DeliveryService 
    {
        private IVehicle _vehicle;
        public DeliveryService(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void StartDelivery()
        {
            _vehicle.Deliver();
        }
    }
}
