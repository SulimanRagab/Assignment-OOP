using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal abstract class Shipment
    {
        #region fields
        public string trackingCode;
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
   
        public abstract decimal EstimatedCost{ get; }

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
        public abstract Shipment CopyShipment();
        public abstract Shipment ShallowCopy();


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }
        public void weightupdate(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
                // انا استخدمت Weight بتاع ال بروبرتي علشان استخدم الفاليديشن 
            }
        }
        // MEthod Overloding
        public void weightupdate(decimal newWeight ,decimal packingWeight)
        {
            if (newWeight > 0 && packingWeight > 0)
            {
                Weight = newWeight + packingWeight;
                
            }
        }


        public abstract void PrintShipment();
        
        public virtual void GenerateCustomsReport()
        {

        }

        #endregion

    }
}
