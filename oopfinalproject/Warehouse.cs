using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    internal class Warehouse
    {
        private string name;
        private List<Package> packages;
        private List<Vehicle> vehicles;
        private List<Worker> workers;
    
        public void AddPackage(Package p)
        {
            packages.Add(p);
        }

        public void RemovePackage(int packageId)
        {
            foreach (Package package in packages)
            {
                if (package.GetPackageID() == packageId)
                {
                    packages.Remove(package);
                    break;
                }
            }
        }

        public Vehicle FindBestVehicle(Package p)
        {
            Vehicle bestVehicle = null;
            double bestEfficiency = double.MaxValue;

            foreach (Vehicle vehicle in vehicles)
            {
                double efficiency = vehicle.CalculateFuelEfficiency(p);
                if (efficiency < bestEfficiency)
                {
                    bestEfficiency = efficiency;
                    bestVehicle = vehicle;
                }
            }
            return bestVehicle;
        }

        public Worker AssignWorker()
        {
            Worker availableWorker = null;
            foreach (Worker worker in workers)
            {
                if (worker.GetIsAvailable())
                {
                    availableWorker = worker;
                    break;
                }
            }
            return availableWorker;
        }

        public List<Package> GetPendingPackages()
        {
            List <Package> pendingPackages = new List<Package>();
            foreach (Package package in packages)
            {
                if (package.GetStatus().Equals("Pending"))
                {
                    pendingPackages.Add(package);
                }
            }
            return pendingPackages;
        }
    }
}
