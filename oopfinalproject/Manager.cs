using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public class Manager : Worker
    {
        private int teamSize;

        public Manager(int experienceYears, int tasksCompleted, bool isAvailable, int teamSize) : base(experienceYears, tasksCompleted, isAvailable)
        {
            this.teamSize = teamSize;
        }

        public int GetTeamSize()
        {
            return teamSize;
        }

        public void SetTeamSize(int teamSize)
        {
            this.teamSize = teamSize;
        }

        public override void Display()
        {
            Console.WriteLine("     ---- Display --- ");
            Console.WriteLine($"Id: {SetID}");
            Console.WriteLine($"Name: {SetName}");
            Console.WriteLine($"Team Size: {teamSize}");
            Console.WriteLine($"Tasks Completed: {SetTasksCompleted}");
            Console.WriteLine($"Available: {SetIsAvailable}");
            Console.WriteLine($"Experience in years: {SetExperienceYears}");
        }

        public override void Performace()
        {
            throw new NotImplementedException();
        }
    }
}
