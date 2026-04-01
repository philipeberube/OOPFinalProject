using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public class Driver : Vehicle
    {
        private string licenceType;

        public void SetLicenceType(string licenceType)
        {
            this.licenceType = licenceType;
        }
        public string GetLicenceType()
        {
            return licenceType;
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
