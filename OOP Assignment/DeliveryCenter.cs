using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal class DliveryCenter
    {
        #region fields
         private Shipment[] Shipments;
        private string CenterName;
        #endregion

        #region Constructors
        public DliveryCenter()
        {
            Shipments = new Shipment[20];
        }
        #endregion

        #region Indexers
        public Shipment this[int index]
        {
            get
            {
               if (index >= 0 && index < Shipments.Length)
               return Shipments[index];
                return new Shipment();
               
            }
            set 
            {
                if (index >= 0 && index < Shipments.Length)
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
                        if (Shipments[i] != null && trackingcode == Shipments[i].TrackingCode)
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
        #endregion

        #region Methods
     public void AddShipment(Shipment shipment)
        {
          for (int i = 0; i< Shipments.Length; i++)
            {
                if (Shipments[i] == null)
                {
                    Shipments[i] = shipment;
                    break;
                }
            }         
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] != null && Shipments[i].TrackingCode == trackingCode)
                {
                    Shipments[i] = null;
                    return true;
                }
            }
            return false;
        }
        #endregion

    }
    
}
