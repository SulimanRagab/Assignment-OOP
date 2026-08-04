using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal struct Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private double deliveryFee;
        public DeliveryAddress Destination { get; set; }
        public string TrackingCode
        {
            get { return trackingCode; }
            private set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                  trackingCode = value;
                }
                
            }
        }
        public string Description
        {
            get { return description; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
                
            }
        }

        public double Weight
        {
            get { return weight;}
            set
            {
                if(value > 0)
                {
                    weight = value;
                }
            }
        }
        public double DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if(value > 0)
                {
                    deliveryFee = value;
                }
            }
        }
   
        public double EstimatedCost
        {
            get
            {
                return deliveryFee + (weight * 5);
            }
        }

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = Destination;
        }
        public Shipment(string trackingCode, string description,double weight,double deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee ;
            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = (double)newFee;
            }
        }
        public void PrintShipment()
        {
            Console.WriteLine($"TrackingCode: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"DeliveryFee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"EstimatedCost: {EstimatedCost}");
        }
    }
}
