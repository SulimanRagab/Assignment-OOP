using OOP_Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal class InternationalShipment : Shipment , ITrackable, IInsurable
    {
        private string DestinationCountry;
        private decimal CustomsFee;
        public string ShipmentType = "International";
        public string destinationCountry
        {
            get { return DestinationCountry; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    DestinationCountry = value;
                }
            }
        }

        public decimal customsFee
        {
            get { return CustomsFee; }
            private set
            {
                if (value >= 0)
                {
                    CustomsFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public InternationalShipment()
        {
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Name Shipment: InternationalShipment");
            Console.WriteLine("\n");
            Console.WriteLine($"TrackingCode: {TrackingCode}");      
            Console.WriteLine($"Destination Country: {destinationCountry}");
            Console.WriteLine($"EstimatedCost: {EstimatedCost} EGP");
            Console.WriteLine("==========================================");
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("GenerateCustomsReport virtual ");
        }

        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }

        public override Shipment CopyShipment()
        {
            throw new NotImplementedException();
        }

        public override Shipment ShallowCopy()
        {
            throw new NotImplementedException();
        }

        public override Shipment DeepCopy()
        {
            throw new NotImplementedException();
        }

        public override string GetSummary()
        {
            return $"{trackingCode} | {ShipmentType} | {Weight} KG | {GetTrackingStatus()} ";
        }
    }
}

