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
        private static int managerId =0;
        public Manager(int id, string name, DateTime createdDate, int experienceYears, int tasksCompleted, bool isAvailable, int teamSize) : base(id, name, createdDate, experienceYears, tasksCompleted, isAvailable)
        {
            managerId++;
            id=managerId;
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
            if (GetID() == null || GetName() == null)
            {
                throw new ArgumentException("No employee(s) added yet");
            }

            int performance = teamSize;

            if (performance == 0)
            {
                Console.WriteLine("Beginner");
            }
            else if (performance <= 5)
            {
                Console.WriteLine("Junior");
            }
            else if (performance <= 10)
            {
                Console.WriteLine("Intermediate");
            }
            else if (performance <= 15)
            {
                Console.WriteLine("Senior");
            }
            else if (performance <= 20)
            {
                Console.WriteLine("Lead");
            }
            else if (performance <= 25)
            {
                Console.WriteLine("Architect");
            }
            else
            {
                Console.WriteLine("Expert");
            }
        }
    }
}
