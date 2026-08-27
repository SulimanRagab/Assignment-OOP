using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return shipment.GetSummary();
        }
        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.GetTrackingStatus().Contains("Delivered") ? true :false;
            // هنا انا استخدمت ميثود Contains() اللي بتحقق من وجود كلمات ف المكان اللي ببحث فيه و استخدمت الميثود دي لأن نظام تتبع الشحنات عندي  من نوع Method 
        }
    }
}
