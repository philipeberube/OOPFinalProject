using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public class Driver : Worker
    {
        private string licenceType;

        public Driver(int id, string name, DateTime createdDate, int experienceYears, int tasksCompleted, bool isAvailable, string licenceType) : base(id, name, createdDate, experienceYears, tasksCompleted, isAvailable)
        {
            this.licenceType = licenceType;
        }

        public void SetLicenceType(string licenceType)
        {
            this.licenceType = licenceType;
        }
        public string GetLicenceType()
        {
            return licenceType;
        }
        

        public override void Display()
        {
            Console.WriteLine("     ---- Display --- ");
            Console.WriteLine($"Id: {SetID}");
            Console.WriteLine($"Name: {SetName}");
            Console.WriteLine($"LicenceType: {licenceType}");
            Console.WriteLine($"Tasks Completed: {SetTasksCompleted}");
            Console.WriteLine($"Available: {SetIsAvailable}");
            Console.WriteLine($"Experience in years: {SetExperienceYears}");
        }

        public override void Performace()
        {
            int performance = GetExperienceYears();

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
