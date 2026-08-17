using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal class ExpressShipment : Shipment , ITrackable, IInsurable
    {
        private decimal extraFee;
        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + extraFee;
            }
        }
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal ExtraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Name Shipment: ExpressShipment");
            Console.WriteLine(" \n ");
            Console.WriteLine($"TrackingCode: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"DeliveryFee: {DeliveryFee} EGP");
            Console.WriteLine($"ExtraFee: {extraFee} EGP");
            Console.WriteLine($"EstimatedCost: {EstimatedCost} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode}  is Out for Delivery";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}
