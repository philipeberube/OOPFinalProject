using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public class Loader : Worker
    {
        private double maxLiftWeight;

        public Loader(int experienceYears, int tasksCompleted, bool isAvailable, double maxLiftWeight) : base(experienceYears, tasksCompleted, isAvailable)
        {
            this.maxLiftWeight = maxLiftWeight;
        }

        public double GetMaxLiftWeight()
        {
            return maxLiftWeight;
        }
        public void SetMaxLiftWeight(double maxLiftWeight)
        {
            this.maxLiftWeight = maxLiftWeight;
        }
        

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override void Performace()
        {
            throw new NotImplementedException();
        }
    }
}
