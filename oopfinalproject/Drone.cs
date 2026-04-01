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
            throw new NotImplementedException();
        }
    }
}
