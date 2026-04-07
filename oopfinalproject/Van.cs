using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public class Van : Vehicle
    {
        private bool isElectric;

        public Van(int id, string name, DateTime createdDate, double speed, double maxCapacity, double currentLoad, bool isAvailable, bool isElectric) : base(id, name, createdDate, speed, maxCapacity, currentLoad, isAvailable)
        {
            this.isElectric = isElectric;
        }

        public void SetIsElectric(bool isElectric)
        {
            this.isElectric = isElectric;
        }
        public bool GetIsElectric()
        {
            return isElectric;
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
