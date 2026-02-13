using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Logistics
{
    // 9. ISP: Interface Segregation Principle

    // Violated: ShippingService is forced to implement billing and notfication functions
    public interface ILogisticsManagement
    {
        void Ship();
        void GenerateBill();
        void SendNotification();
    }
    public class ShippingService : ILogisticsManagement
    {
        public void GenerateBill()
        {
            // Not required
        }

        public void SendNotification()
        {
            // Not required
        }

        public void Ship()
        {
            Console.WriteLine("Shipping package");
        }
    }

    // Fixed: Make each class depend only on what it needs
    public interface IShippingService
    {
        void Ship();
    }
    public interface IBillingService
    {
        void GenerateBill();
    }
    public interface INotificationService
    {
        void SendNotification();
    }

    public class ShippingServie : IShippingService
    {
        public void Ship()
        {
            Console.WriteLine("Shipping package");
        }
    }
}
