using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal class InternationalShipment : Shipment , ITrackable, IInsurable
    {
        private string destinationCountry;
        private decimal customsFee;
        public string DestinationCountry
        {
            get { return destinationCountry; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            private set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + customsFee;
            }
        }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string DestinationCountry, decimal CustomsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Name Shipment: InternationalShipment");
            Console.WriteLine(" \n ");
            Console.WriteLine($"TrackingCode: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"DeliveryFee: {DeliveryFee} EGP");         
            Console.WriteLine($"Destination Country: {destinationCountry}");
            Console.WriteLine($"CustomsFee: {customsFee} EGP");
            Console.WriteLine($"EstimatedCost: {EstimatedCost} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("GenerateCustomsReport virtual ");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}

