using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public abstract class Entity
    {
        private int id;
        private string name;
        private DateTime createdDate;

        public Entity(int id, string name, DateTime createdDate)
        {
            this.id = id;
            this.name = name;
            this.createdDate = createdDate;
        }

        public int GetID()
        {
            return id;
        }
        public void SetID(int id)
        {
            this.id = id;
        } // needs validation still

        public void SetName(string name)
        {
            this.name = name;
        } // needs validation still
         public DateTime GetCreatedDate() { return createdDate; }

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
