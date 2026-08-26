using OOP_Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal class StandardShipment : Shipment , ITrackable, IInsurable
    {
        public StandardShipment()
        {
        }

        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }


        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
      
        }

        public override Shipment CopyShipment() => new StandardShipment();

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready";
        }

        public override void PrintShipment()
        {
            {
                Console.WriteLine($"Name Shipment: StandardShipment");
                Console.WriteLine("\n");
                Console.WriteLine($"TrackingCode: {TrackingCode}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"EstimatedCost: {EstimatedCost} EGP");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
            }
        }

        public override StandardShipment ShallowCopy() => (StandardShipment)this.MemberwiseClone();
    }
}
