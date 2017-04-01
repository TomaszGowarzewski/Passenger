using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    class DailyRoute
    {
        public Guid Id { get; protected set; }

        public Route Route { get; protected set; }

        public IEnumerable<PassengerNode> PassengerNodes { get; protected set; }

        public DailyRoute(Route Route, IEnumerable<PassengerNode> PassengerNodes)
        {
            Id = Guid.NewGuid();
            this.Route = Route;
            this.PassengerNodes = PassengerNodes; //todo Validation
        }

        protected DailyRoute()
        {

        }
    }
}
