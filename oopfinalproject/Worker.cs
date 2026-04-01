using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public abstract class Worker(int id, int experienceYears, int tasksCompleted, bool isAvailable) : Entity(id, "Worker", DateTime.Now)
    {
        private int experienceYears = experienceYears;
        private int tasksCompleted = tasksCompleted;
        private bool isAvailable = isAvailable;

        protected Worker(int experienceYears, int tasksCompleted, bool isAvailable)
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
            tasksCompleted = tc;
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
            else if (ey < 3 && tc < 15)
            {
                Console.WriteLine("Intermediate");
                return 5;
            }
            else if (ey < 5 && tc < 15)
            {
                Console.WriteLine("Senior");
                return 5;
            }
            else if (ey < 8 && tc < 15)
            {
                Console.WriteLine("Lead");
                return 5;
            }
            else if (ey < 12 && tc < 15)
            {
                Console.WriteLine("Architect");
                return 5;
            }
            else
            {
                return 5;
            }

        }
        public abstract void Performace();

    }
}
