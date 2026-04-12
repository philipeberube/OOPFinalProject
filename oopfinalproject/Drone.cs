using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public class Drone : Vehicle
    {
        private double maxDistance;
        private static int droneId = 5000;

        public Drone(int id, string name, DateTime createdDate, double speed, double maxCapacity, double currentLoad, bool isAvailable, double maxDistance) : base(id, name, createdDate, speed, maxCapacity, currentLoad, isAvailable)
        {
            droneId++;
            id=droneId;
            this.SetName(name);
            this.SetMaxCapacity(maxCapacity);
            this.SetIsAvailable(isAvailable);
            this.SetCurrentLoad(currentLoad);
            this.SetSpeed(speed);
            this.maxDistance = maxDistance;
        }

        public void SetMaxDistance(double maxDistance)
        {
            this.maxDistance = maxDistance;
        }
        public double GetMaxDistance()
        {
            return maxDistance;
        }

        public override void Deliver(List<Package> packages)
        {
            if(packages == null || packages.Count == 0)
            {
                throw new ArgumentException("no packages to deliver");
            }
            foreach (Package package in packages)
            {
                if (GetCurrentLoad() + package.GetWeight() > GetMaxCapacity())
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
            Console.WriteLine($"Id: {SetID}");
            Console.WriteLine($"Capacity: {SetCapacity}");
            Console.WriteLine($"Max Distance: {maxDistance}");
            Console.WriteLine($"Available: {SetIsAvailable}");
            Console.WriteLine($"Speed: {SetSpeed}");
            Console.WriteLine($"Current Load: {SetCurrentLoad}");
            Console.WriteLine($"Max Capacity: {SetMaxCapacity}");
        }
    }
}
