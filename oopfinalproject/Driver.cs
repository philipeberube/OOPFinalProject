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

        public Driver(int id, string name, DateTime createdDate, string licenceType) : base(id, name, createdDate)
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
            throw new NotImplementedException();
        }

        public override void Performace()
        {
            throw new NotImplementedException();
        }
    }
}
