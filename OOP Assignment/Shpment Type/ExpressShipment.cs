using OOP_Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal class ExpressShipment : Shipment , ITrackable, IInsurable
    {
        private decimal ExtraFee;
        public string ShipmentType = "Express";
        public decimal extraFee
        {
            get { return ExtraFee; }
            set
            {
                if (value >= 0)
                {
                    ExtraFee = value;
                }
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        static ExpressShipment()
        {
            TotalShipmentsCreated++;

        }

        public ExpressShipment()
        {
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Name Shipment: ExpressShipment");
            Console.WriteLine("\n");
            Console.WriteLine($"TrackingCode: {TrackingCode}");
            Console.WriteLine($"ExtraFee: {extraFee} EGP");
            Console.WriteLine($"EstimatedCost: {EstimatedCost} EGP");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
        }

        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode}  is Out for Delivery";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
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
