using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string DestinationCountry, decimal CustomsFee) : base(trackingCode, description, weight, deliveryFee, destination, DestinationCountry, CustomsFee)
        {

        }
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("التقارير النهائية");
            Console.WriteLine("  ممنوع حد يعمل override للميثود دي تاني ويغير فيها  ");
        }


    }
}
