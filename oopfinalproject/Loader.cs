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
            Console.WriteLine("     ---- Display --- ");
            Console.WriteLine($"Id: {SetID}");
            Console.WriteLine($"Name: {SetName}");
            Console.WriteLine($"Max Lift Weight: {maxLiftWeight}");
            Console.WriteLine($"Tasks Completed: {SetTasksCompleted}");
            Console.WriteLine($"Available: {SetIsAvailable}");
            Console.WriteLine($"Experience in years: {SetExperienceYears}");
        }

        public override void Performace()
        {
            double performance = maxLiftWeight;

            if (performance == 0)
            {
                Console.WriteLine("broken");
            }
            else if (performance <= 100)
            {
                Console.WriteLine("fair condition");
            }
            else if (performance <= 200 && performance >= 500)
            {
                Console.WriteLine("barely used");
            }
            else
            {
                Console.WriteLine("Standard");
            }
        }
    }
}
