using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Logistics
{
    // 4. KISS : Keep it simple, stupid
    // Unnecessary methods for estimating delivery
    public static class ComplexDeliveryEstimator
    {
        public static DateTime Estimate(DateTime pickup)
        {
            return AddDays(pickup);
        }

        public static DateTime AddDays(DateTime date)
        {
            return date.AddDays(5);
        }
    }
    // Simple delivery estimator
    public class SimpleDeliveryEstimator
    {
        public DateTime Estimate(DateTime pickup)
        {
            return pickup.AddDays(5);
        }
    }

    // 5. DRY: Do not repeat yourself
    // below status is checked twice instead reuse a common method which will check the status
    public class Notification
    {
        public void Print(string status)
        {
            if(status == "Delivered")
                Console.WriteLine("Shipment deliverd");
        }

        public void Notify(string status)
        {
            if(status == "Delivered")
                Console.WriteLine("Notification sent");
        }
    }

    public class NotificationHelper
    {
        public bool isDelivered(string status)
        {
            if (status == "Delivered")
                return true;
            return false;
        }
    }
}
