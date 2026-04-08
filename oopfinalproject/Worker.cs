using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oopfinalproject
{
    public abstract class Worker : Entity
    {
        private int experienceYears;
        private int tasksCompleted;
        private bool isAvailable;

        public Worker(int id, string name, DateTime createdDate, int experienceYears, int tasksCompleted, bool isAvailable) : base(id, name, createdDate)
        {
            this.experienceYears = experienceYears;
            this.tasksCompleted = tasksCompleted;
            this.isAvailable = isAvailable;
        }

        public void SetIsAvailable(bool isAvailable)
        {
            this.isAvailable = isAvailable;
        }
        public bool GetIsAvailable()
        {
            return isAvailable;
        }
        public void SetTasksCompleted(int tasksCompleted)
        {
            this.tasksCompleted = tasksCompleted;
        }
        public int GetTasksCompleted()
        {
            return tasksCompleted;
        }
        public void SetExperienceYears(int experienceYears)
        {
            this.experienceYears = experienceYears;
        }
        public int GetExperienceYears()
        {
            return experienceYears;
        }
        public void AddTask(int tc)
        {
            tasksCompleted += tc;
        }
        public virtual double CalculatePerformace(int ey, int tc)
        {
            if (ey == 0 || tc == 0)
            {
                Console.WriteLine("Beginner");
                return 0;
            }
            else if (ey < 1 && tc < 15)
            {
                Console.WriteLine("Junior");
                return 5;
            }
            else if (ey >= 1 && ey < 3 && tc < 15)
            {
                Console.WriteLine("Intermediate");
                return 10;
            }
            else if (ey >= 3 && ey < 5 && tc < 15)
            {
                Console.WriteLine("Senior");
                return 15;
            }
            else if (ey >= 5 && ey < 8 && tc < 15)
            {
                Console.WriteLine("Lead");
                return 20;
            }
            else if (ey >= 8 && ey < 12 && tc < 15)
            {
                Console.WriteLine("Architect");
                return 25;
            }
            else
            {
                Console.WriteLine("Expert");
                return 30;
            }

        }
        public abstract void Performace();

    }
}
