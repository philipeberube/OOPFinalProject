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
            if (id < 0 || id != null)
            {
                throw new ArgumentException("Id cannot be empty or less then 0");
            }
            else
            {
                this.id = id;
            }
        } 

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("name cannot be empty");
            }
            else
            {
                this.name = name;
            }
        }
         public DateTime GetCreatedDate() { return createdDate; }

        public string GetName()
        {
            return name;
        }

        public virtual bool Validate()
        {
            return true;
        }//validate?
  

        public abstract void Display();

    }
}
