using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    class Passenger
    {
        public Guid Id { get; protected set; }

        public Guid UserId { get; protected set; }

        public Node Address { get; protected set; }

        public Passenger(Guid UserId, Node Address)
        {
            Id = Guid.NewGuid();
            this.UserId = UserId;
            this.Address = Address;
        }

        protected Passenger()
        {

        }


    }
}
