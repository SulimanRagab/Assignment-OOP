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
            set 
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
            set
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
    }
}
