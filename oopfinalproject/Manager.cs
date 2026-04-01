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
            throw new NotImplementedException();
        }

        public override void Performace()
        {
            throw new NotImplementedException();
        }
    }
}
