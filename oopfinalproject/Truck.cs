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
        private static int truckId = 4000;
        public Truck(int id, string name, DateTime createdDate, double speed, double maxCapacity, double currentLoad, bool isAvailable, double fuelConsumption) : base(id, name, createdDate, speed, maxCapacity, currentLoad, isAvailable)
        {
            truckId++;
            id=truckId;
            this.SetName(name);
            this.SetMaxCapacity(maxCapacity);
            this.SetIsAvailable(isAvailable);
            this.SetCurrentLoad(currentLoad);
            this.SetSpeed(speed);
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
            if (packages == null || packages.Count == 0)
            {
                throw new ArgumentException("no packages to deliver");
            }
            foreach(Package package in packages)
            {
                if(GetCurrentLoad() + package.GetWeight() > GetMaxCapacity())
                {
                    throw new InvalidOperationException("exceeding max capacity");
                }
                else
                {
                    SetCurrentLoad(GetCurrentLoad() + package.GetWeight());
                    package.SetStatus("Delevered");
                }
            }

        }

        public override void Display()
        {
            Console.WriteLine("     ---- Display --- ");
            Console.WriteLine($"Fuel Consumption: {fuelConsumption}");
            Console.WriteLine($"Id: {SetID}");
            Console.WriteLine($"Capacity: {SetCapacity}");
            Console.WriteLine($"Available: {SetIsAvailable}");
            Console.WriteLine($"Speed: {SetSpeed}");
            Console.WriteLine($"Current Load: {SetCurrentLoad}");
            Console.WriteLine($"Max Capacity: {SetMaxCapacity}");
        }
    }
}
