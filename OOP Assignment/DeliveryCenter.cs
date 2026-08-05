using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal struct DliveryCenter
    {
        private Shipment[] Shipments;

        public DliveryCenter()
        {
            Shipments = new Shipment[10];
        }

        public Shipment this[int index]
        {
            get
            {
               if (index >= 0 && index < 10)
               return Shipments[index];
                return new Shipment();
               
            }
            set 
            {
                if (index >= 0 && index < 10)
                {
                    Shipments[index] = value;
                }
                else
                {
                 new Shipment();
                }
                
            }
        }

        public Shipment this[string trackingcode]
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(trackingcode))
                    for (int i = 0; i < Shipments.Length; i++)
                        if (trackingcode == Shipments[i].TrackingCode)
                            return Shipments[i];
                         return new Shipment();
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(trackingcode))
                    for (int i = 0; i < Shipments.Length; i++)
                        if (trackingcode == Shipments[i].TrackingCode)
                        {
                            Shipments[i] = value;
                            break;
                        }
            }
        }

        public void AddShipment(Shipment shipment)
        {
          for (int i = 0; i< Shipments.Length; i++)
            {
                if (Shipments[i].TrackingCode == null)
                {
                    Shipments[i] = shipment;
                    break;
                }
            }         
        }
    }
    
}
