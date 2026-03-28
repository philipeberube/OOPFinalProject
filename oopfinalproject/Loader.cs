using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public class Loader : Vehicle
    {
        private double maxLiftWeight;

        public double GetMaxLiftWeight()
        {
            return maxLiftWeight;
        }
        public void SetMaxLiftWeight(double maxLiftWeight)
        {
            this.maxLiftWeight = maxLiftWeight;
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
