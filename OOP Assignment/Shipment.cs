using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal class Shipment
    {
        #region fields
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        public DeliveryAddress Destination { get; set; }
        #endregion

        #region properties
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

        public decimal Weight
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
        public decimal DeliveryFee
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
   
        public virtual decimal EstimatedCost
        {
            get
            {
                return deliveryFee + (weight * 5);
            }
        }

        #endregion

        #region Constructors
        public Shipment()
        {
            
        }
        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = Destination;
        }
        public Shipment(string trackingCode, string description,decimal weight,decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee ;
            Destination = destination;
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee) : this(trackingCode)
        {
        }

        #endregion

        #region Methods
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }
        public virtual void PrintShipment()
        {
            Console.WriteLine($"TrackingCode: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"DeliveryFee: {DeliveryFee} EGP");
            Console.WriteLine($"EstimatedCost: {EstimatedCost} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
        }

        #endregion

    }
}
