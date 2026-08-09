using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight, double deliveryFee) : base(trackingCode, description, weight, deliveryFee)
        {

        }
    }
}
