using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public abstract class Vehicle : Entity
    {
        private double speed;
        private double maxCapacity;
        private double currentLoad;
        private bool isAvailable;

        public void SetCapacity(double capacity)
        {
            this.maxCapacity = capacity;
        }

        public double GetRemainingCapacity()
        {
            return maxCapacity - currentLoad;
        }

        public virtual double CalculateFuelEfficiency()
        {
            return 0; // Placeholder for fuel efficiency calculation
        }

        public abstract void Deliver(List<Package> packages); //List of <Pakage> to be done still
    }
}
