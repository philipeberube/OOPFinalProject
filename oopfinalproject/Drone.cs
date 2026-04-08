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

        public Drone(int id, string name, DateTime createdDate, double speed, double maxCapacity, double currentLoad, bool isAvailable, double maxDistance) : base(id, name, createdDate, speed, maxCapacity, currentLoad, isAvailable)
        {
            this.SetID(id);
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
            throw new NotImplementedException();
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
