using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    class PassengerNode
    {
        public Node Node { get; protected set; }
        public Passenger Passenger { get; set; }

        public PassengerNode(Node Node, Passenger Passenger)
        {
            this.Node = Node;
            this.Passenger = Passenger;
        }

        protected PassengerNode()
        {

        }
    }
}
