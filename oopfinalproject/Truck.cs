using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public class Truck : Vehicle
    {
        private double fuelConsumption;

        public Truck(int id, string name, DateTime createdDate, double speed, double maxCapacity, double currentLoad, bool isAvailable, double fuelConsumption) : base(id, name, createdDate, speed, maxCapacity, currentLoad, isAvailable)
        {
            this.SetID(id);
            this.SetName(name);
            this.SetCapacity(maxCapacity);
            this.SetIsAvailable(isAvailable);
            this.set
            this.fuelConsumption = fuelConsumption;
        }

        public void SetFuelConsumption(double fuelConsumption)
        {
            this.fuelConsumption = fuelConsumption;
        }
        public double GetFuelConsumption()
        {
            return this.fuelConsumption;
        }

        public override void Deliver(List<Package> packages)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Console.WriteLine($"Fuel Consumption: {fuelConsumption}");
            Console.WriteLine($"Id: {SetID}");
            Console.WriteLine($"Max Capacity: {SetCapacity}");
        }
    }
}
