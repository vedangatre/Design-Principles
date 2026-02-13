using System;

namespace Logistics
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("\n====================================");
				Console.WriteLine(" LOGISTICS DESIGN PRINCIPLES ");
				Console.WriteLine("====================================");
				Console.WriteLine("1. Encapsulation");
				Console.WriteLine("2. Inheritance");
				Console.WriteLine("3. Polymorphism");
				Console.WriteLine("4. KISS Principle");
				Console.WriteLine("5. DRY Principle");
				Console.WriteLine("6. Single Responsibility Principle");
				Console.WriteLine("7. Open/Closed Principle");
				Console.WriteLine("8. Liskov Substitution Principle");
				Console.WriteLine("9. Interface Segregation Principle");
				Console.WriteLine("10. Dependency Inversion Principle");
				Console.WriteLine("0. Exit");
				Console.WriteLine("====================================");
				Console.Write("Enter your choice: ");

				string choice = Console.ReadLine();
				Console.WriteLine();

				switch (choice)
				{
					case "1":
						RunEncapsulation();
						break;

					case "2":
						RunInheritance();
						break;

					case "3":
						RunPolymorphism();
						break;

					case "4":
						RunKISS();
						break;

					case "5":
						RunDRY();
						break;

					case "6":
						RunSRP();
						break;

					case "7":
						RunOCP();
						break;

					case "8":
						RunLSP();
						break;

					case "9":
						RunISP();
						break;

					case "10":
						RunDIP();
						break;

					case "0":
						Console.WriteLine("Exiting...");
						return;

					default:
						Console.WriteLine("Invalid choice. Try again.");
						break;
				}
			}
		}

		// ============================
		// 1. Encapsulation
		// ============================
		static void RunEncapsulation()
		{
			Console.WriteLine("ENCAPSULATION Example");

			var shipment = new Shipment(50);
			Console.WriteLine($"Initial Status: {shipment.Status}");
			shipment.MarkInTransit();
			shipment.MarkDelivered();
			Console.WriteLine($"Final Status: {shipment.Status}");
		}

		// ============================
		// 2. Inheritance
		// ============================
		static void RunInheritance()
		{
			Console.WriteLine("INHERITANCE Example");

			BaseShipment air = new AirShipment(30);
			BaseShipment road = new RoadShipment(40);
		}

		// ============================
		// 3. Polymorphism
		// ============================
		static void RunPolymorphism()
		{
			Console.WriteLine("POLYMORPHISM Example");

			// Polymorphism
			IShipmentCost airCost = new Air();
			IShipmentCost roadCost = new Road();

			Console.WriteLine($"Air Cost: {airCost.CalculateCost()}");
			Console.WriteLine($"Road Cost: {roadCost.CalculateCost()}");

			// Function Overloading Example
			CostCalculator calc = new CostCalculator();

			Console.WriteLine("\n--- Function Overloading Demonstration ---");
			Console.WriteLine($"Basic Cost (weight): {calc.CalculateCost(50)}");
			Console.WriteLine($"Cost (weight + distance): {calc.CalculateCost(50, 200)}");
			Console.WriteLine($"Cost (weight + distance + priority): {calc.CalculateCost(50, 200, 1.5)}");
		}


		// ============================
		// 4. KISS
		// ============================
		static void RunKISS()
		{
			Console.WriteLine("KISS Example");

			var simple = new SimpleDeliveryEstimator();
			Console.WriteLine($"Delivery ETA: {simple.Estimate(DateTime.Now)}");
		}

		// ============================
		// 5. DRY
		// ============================
		static void RunDRY()
		{
			Console.WriteLine("DRY Example");

			var notification = new Notification();
			notification.Print("Delivered");
			notification.Notify("Delivered");

			var helper = new NotificationHelper();
			Console.WriteLine($"isDelivered: {helper.isDelivered("Delivered")}");
		}

		// ============================
		// 6. SRP
		// ============================
		static void RunSRP()
		{
			Console.WriteLine("SRP Example");

			var driverService = new DriverService();
			driverService.AddDriver();

			var salaryService = new SalaryService();
			salaryService.CalculateSalary();
		}

		// ============================
		// 7. OCP
		// ============================
		static void RunOCP()
		{
			Console.WriteLine("OCP Example");

			IPayment upi = new UpiPayment();
			IPayment card = new CardPayment();

			upi.Pay(500);
			card.Pay(1500);
		}

		// ============================
		// 8. LSP
		// ============================
		static void RunLSP()
		{
			Console.WriteLine("LSP Example");

			Truck truck = new Truck();
			truck.Refuel();

			Truck eTruck = new ElectricTruck();
			eTruck.Refuel();

			IFuelTruck dieselTruck = new DieselTruck();
			dieselTruck.Refuel();

			var electric = new ETruck();
			electric.Charge();
		}

		// ============================
		// 9. ISP
		// ============================
		static void RunISP()
		{
			Console.WriteLine("ISP Example");

			IShippingService shipping = new ShippingServie();
			shipping.Ship();
		}

		// ============================
		// 10. DIP
		// ============================
		static void RunDIP()
		{
			Console.WriteLine("DIP Example");

			var oldService = new DService();
			oldService.StartDelivery();

			var shipDelivery = new DeliveryService(new Ship());
			shipDelivery.StartDelivery();

			var vanDelivery = new DeliveryService(new Van());
			vanDelivery.StartDelivery();
		}
	}
}