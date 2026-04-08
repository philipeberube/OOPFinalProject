using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

        public virtual bool Validate(string val)
        {
            switch (val)
            {
                case "id":
                    if (id <= 0)
                    {
                        throw new ArgumentException("id cannot be less then 0 or 0 ");
                    }
                    if(id >= 5000)
                    {
                        throw new ArgumentException("id cannot be greater than 5000");
                    }
                    if(id == null)
                    {
                        throw new ArgumentException("id cannot be null");
                    }
                    break;
                case "name":
                    if (string.IsNullOrEmpty(name))
                    {
                        throw new ArgumentException("name cannot be empty");
                    }
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!char.IsLetter(name[i]) && !char.IsWhiteSpace(name[i]))
                        {
                            throw new ArgumentException("name can only contain letters and spaces");
                        }
                    }
                    for(int i = 0; i < name.Length; i++)
                    {
                        if (char.IsWhiteSpace(name[i]) && char.IsWhiteSpace(name[i + 1]))
                        {
                            throw new ArgumentException("name connot contain multiple spaces ");
                        }
                    }
                    for(int i = 0; i < name.Length; i++)
                    {
                        if (char.IsWhiteSpace(name[0]) || char.IsWhiteSpace(name[name.Length - 1]))
                        {
                            throw new ArgumentException("name cannot start or end with a space");
                        }
                    }
                    break;
                case "createdDate":
                    if (createdDate == null)
                    {
                        throw new ArgumentException("date cannot be null");
                    }
                    if(createdDate > DateTime.Now)
                    {
                        throw new ArgumentException("date cannot be in the future");
                    }
                    break;

            }
            return true;
        }
  

        public abstract void Display();

    }
}
