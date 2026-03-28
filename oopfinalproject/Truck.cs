using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public class Truck : Vehicle
    {
        double fuelConsumption;

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
            throw new NotImplementedException();
        }
    }
}
