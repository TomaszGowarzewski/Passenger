using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    class Driver
    {
        public Guid Id { get; protected set; }

        public Guid UserId { get; protected set; }

        public Vehicle Vehicle { get; protected set; }

        public IEnumerable<Route> Routes { get; protected set; }

        public IEnumerable<DailyRoute> DailyRoutes { get; protected set; }

        public Driver(Guid UserId, Vehicle Vehicle, IEnumerable<Route> Routes, IEnumerable<DailyRoute> DailyRoutes)
        {
            Id = Guid.NewGuid();
            this.UserId = UserId;
            this.Vehicle = Vehicle;
            this.Routes = Routes;
            this.DailyRoutes = DailyRoutes;
        }

        protected Driver()
        {
                
        }

    }
}
