using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee) : base(trackingCode, description, weight, deliveryFee)
        {

        }
    }
}
