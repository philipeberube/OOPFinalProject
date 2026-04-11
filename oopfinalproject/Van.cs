using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public class Van : Vehicle
    {
        private bool isElectric;
        private static int vanId = 3000;

        public Van(int id, string name, DateTime createdDate, double speed, double maxCapacity, double currentLoad, bool isAvailable, bool isElectric) : base(id, name, createdDate, speed, maxCapacity, currentLoad, isAvailable)
        {
            vanId++;
            id=vanId;
            this.SetName(name);
            this.SetMaxCapacity(maxCapacity);
            this.SetIsAvailable(isAvailable);
            this.SetCurrentLoad(currentLoad);
            this.SetSpeed(speed);
            this.isElectric = isElectric;
        }

        public void SetIsElectric(bool isElectric)
        {
            this.isElectric = isElectric;
        }
        public bool GetIsElectric()
        {
            return isElectric;
        }

        public override void Deliver(List<Package> packages)
        {
            if (packages == null || packages.Count == 0)
            {
                throw new ArgumentException("no packages to deliver");
            }
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Console.WriteLine("     ---- Display --- ");
            Console.WriteLine($"Id: {SetID}");
            Console.WriteLine($"Capacity: {SetCapacity}");
            Console.WriteLine($"Electric: {isElectric}");
            Console.WriteLine($"Available: {SetIsAvailable}");
            Console.WriteLine($"Speed: {SetSpeed}");
            Console.WriteLine($"Current Load: {SetCurrentLoad}");
            Console.WriteLine($"Max Capacity: {SetMaxCapacity}");
        }
    }
}
