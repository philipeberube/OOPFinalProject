
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

        public Vehicle(int id, string name, DateTime createdDate, double speed, double maxCapacity, double currentLoad, bool isAvailable) : base(id, name, createdDate)
        {
            this.speed = speed;
            this.maxCapacity = maxCapacity;
            this.currentLoad = currentLoad;
            this.isAvailable = isAvailable;
        }

       

        public void SetCapacity(double capacity)
        {
            if (capacity <= 0)
            {
                throw new Exception("Capacity must be greater than zero.");
            }
            maxCapacity = capacity;
        }

        public double GetRemainingCapacity()
        {
            return maxCapacity - currentLoad;
        }

        public bool GetIsAvailable()
        {
            return isAvailable;
        }

        public void SetIsAvailable(bool isAvailable)
        {
            this.isAvailable = isAvailable;
        }

        public virtual double CalculateFuelEfficiency()
        {
            if (speed <= 0)
            {
                throw new Exception("Speed must be greater than zero.");
            }
            if (currentLoad < 0 || currentLoad > maxCapacity)
            {
                throw new Exception("Current load must be between 0 and max capacity.");
            }

            double fuelEfficiency = ((currentLoad / maxCapacity) / speed)*7;

            if (fuelEfficiency < 0.1)
            {
                throw new Exception("Fuel efficiency is too low.");
            }

            return fuelEfficiency;
        }
        public virtual double CalculateFuelEfficiency(Package p)
        {
            if (speed <= 0)
            {
                throw new Exception("Speed must be greater than zero.");
            }
            if (currentLoad < 0 || currentLoad > maxCapacity)
            {
                throw new Exception("Current load must be between 0 and max capacity.");
            }

            double fuelEfficiency = ((currentLoad / maxCapacity) / speed) * 7;

            if (fuelEfficiency < 0.1)
            {
                throw new Exception("Fuel efficiency is too low.");
            }

            return fuelEfficiency;
        }
        public abstract void Deliver(List<Package> packages);
    }
}
