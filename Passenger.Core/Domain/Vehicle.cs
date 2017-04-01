namespace Passenger.Core.Domain
{
    public class Vehicle
    {
        public string Name { get; protected set; }

        public string Brand { get; protected set; }

        public int Seats { get; protected set; }

        public Vehicle(string Name, string Brand, int Seats)
        {
            this.Name = Name;
            this.Brand = Brand;
            this.Seats = Seats;
        }

        private Vehicle()
        {

        }

    }
}