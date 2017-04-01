using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
   public class Node
    {
        public string Address { get; protected set; }

        public double Longitude { get; protected set; }

        public double Latitude { get; protected set; }

        public Node(string Address, double Longitude, double Latitude)
        {
            this.Address = Address;
            this.Longitude = Longitude;
            this.Latitude = Latitude;
        }

        protected Node()
        {

        }

    }
}
