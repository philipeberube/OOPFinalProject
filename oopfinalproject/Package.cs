using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public class Package
    {
        private int id;
        private double weight;
        private int priorityLevel; // 1 to 5, 1 being the highest priority
        private string destination;
        private string status; // "Pending", "Assigned", "Delivered"
        
        public Package(int id, double weight, int priorityLevel, string destination)
        {
            this.id = id;
            this.weight = weight;
            this.priorityLevel = priorityLevel;
            this.destination = destination;
            this.status = "Pending"; // Default status
        }

        public int GetPackageID()
        {
            return id;
        }
        public void SetPackageID(int id)
        {
            this.id = id;
        }

        public string GetDestination()
        {
            return destination;
        }

        public void SetDestination(string destination)
        {
            this.destination = destination;
        }

        public string GetStatus()
        {
            return status;
        }

        public void SetStatus(string status)
        {
            this.status = status;
        }
        public double CalculatePriorityScore()
        {
            if (priorityLevel < 1 || priorityLevel > 5)
            {
                throw new Exception("Priority level must be between 1 and 5.");
            }
            if (weight <= 0)
            {
                throw new Exception("Weight must be greater than zero.");
            }
            double priorityScore = (6 - priorityLevel) * weight; // Higher priority level gets a higher score
            return priorityScore;
        }

        public void UpdateStatus(string newStatus)
        {
            if (newStatus != "Pending" && newStatus != "Assigned" && newStatus != "Delivered")
            {
                throw new Exception("Invalid status. Status must be 'Pending', 'Assigned', or 'Delivered'.");
            }
            status = newStatus;
        }

        public bool IsHeavy()
        {
            return weight > 100; // Arbitrary threshold for heavy packages
        }
    }
}
