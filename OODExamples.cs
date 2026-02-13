using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics
{
    // 1. Encapsulation
    // - Weight can't be negative
    // - Status changed through method
    public class Shipment
    {
        public double Weight { get; set; }
        public string Status { get; private set; }

        public Shipment(double weight)
        {
            if( weight > 0)
                Weight = weight;
            Status = "Created";
        }

        public void MarkInTransit()
        {
            if (Status == "Created")
                Status = "In Transit";
        }

        public void MarkDelivered()
        {
            if (Status == "In Transit")
                Status = "Delivered";
        }
    }

    // 2. Inheritance
    // - AirShipment and RoadShipment inherit from BaseShipment

    public class BaseShipment
    {
        public double Weight { get; }
        public BaseShipment(double weight)
        {
            Weight = weight;
        }
    }

    public class AirShipment : BaseShipment
    {
        public AirShipment(double weight) : base(weight)
        {
            Console.WriteLine("Air shipment cost: 1000");
        }
    }

    public class RoadShipment : BaseShipment
    {
        public RoadShipment(double weight) : base(weight)
        {
			Console.WriteLine("Road shipment cost: 200");
		}
    }

    // 3. Polymorphism
    // - Different Shipments calculate cost differently

    // Overriding
    public interface IShipmentCost
    {
        public double CalculateCost();
    }

    public class Air : IShipmentCost
    {
        public double CalculateCost()
        {
            return 1000.0d;
        }
    }

    public class Road : IShipmentCost
    {
        public double CalculateCost()
        {
            return 200.0d;
        }
    }

	// Overloading
	public class CostCalculator
	{
		// Overload 1: Only weight
		public double CalculateCost(double weight)
		{
			return weight * 10;
		}

		// Overload 2: Weight + distance
		public double CalculateCost(double weight, double distance)
		{
			return (weight * 10) + (distance * 5);
		}

		// Overload 3: Weight + distance + priority factor
		public double CalculateCost(double weight, double distance, double priority)
		{
			return ((weight * 10) + (distance * 5)) * priority;
		}
	}

}
