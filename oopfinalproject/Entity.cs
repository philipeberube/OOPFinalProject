using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    abstract class Entity
    {
        private int id;
        private string name;
        private DateTime createdDate;


        public void SetName(string name)
        {
            this.name = name;
        } // needs validation still


        public string GetName()
        {
            return name;
        }

        public virtual bool Validate()
        {
            return true;
        } // needs validation still

        public abstract void Display();

    }
}
