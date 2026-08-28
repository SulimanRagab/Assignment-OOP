using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal abstract partial class Shipment
    {
        public string trackingCode;
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
        public abstract string GetTrackingStatus();
    }
}
