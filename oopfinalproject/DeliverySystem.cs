using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    internal class DeliverySystem
    {

        private List<Warehouse> warehouses;
        private List<Package> allPackages;

        public DeliverySystem()
        {
            warehouses = new List<Warehouse>();
            allPackages = new List<Package>();
        }

        public void AddWarehouse(Warehouse w)
        {
            if (w == null)
            {
                throw new ArgumentNullException("Warehouse cannot be null");
            }
            warehouses.Add(w);
        }

        public void AddPackage(Package p)
        {
            if (p == null)
            {
                throw new ArgumentNullException("Package cannot be null");
            }
            allPackages.Add(p);
        }

        public Package SearchPackageById(int id)
        {
            foreach (Package package in allPackages)
            {
                if (package.GetPackageID() == id)
                {
                    return package;
                }
            }
            return null; // Return null if package not found
        }

        public void SortPackages()
        {
            for (int i = 0; i < allPackages.Count; i++)
            {
                for (int j = i + 1; j < allPackages.Count; j++)
                {
                    if (allPackages[i].CalculatePriorityScore() < allPackages[j].CalculatePriorityScore())
                    {
                        // Swap packages
                        Package temp = allPackages[j];
                        allPackages[j] = allPackages[i];
                        allPackages[i] = temp;
                    }
                }
            }
        }

        public void ProcessDeliveries()
        {
            foreach (Package package in allPackages)
            {
                Vehicle bestVehicle = null;
                
                Driver assignedDriver = null;
                Loader assignedLoader = null;
                foreach (Warehouse warehouse in warehouses)
                {
                    if (bestVehicle == null)
                    {
                        bestVehicle = warehouse.FindBestVehicle(package);
                        assignedDriver = warehouse.AssignDriver();
                        assignedLoader = warehouse.AssignLoader();

                    }

                    if (bestVehicle != null && assignedDriver != null && assignedLoader != null)
                    {
                        // Assign the package to the vehicle and driver
                        bestVehicle.SetCurrentLoad(package.GetWeight());
                        assignedDriver.SetIsAvailable(false); // Mark the driver as unavailable
                        assignedDriver.AddTask(1);
                        assignedLoader.SetIsAvailable(false); // Mark the loader as unavailable
                        assignedLoader.AddTask(1);
                    }
                }
            }

                  

            // Logic to assign packages to vehicles and deliver them
        }
        public void CancelDelivery(int packageId)
            {
                Package package = SearchPackageById(packageId);
                if (package != null)
                {
                    allPackages.Remove(package);
                    Console.WriteLine($"Package {packageId} has been canceled.");
                }
                else
                {
                    Console.WriteLine($"Package {packageId} not found.");
                }
            } 

        public void SimulateDay()
        {
            // Main simulation logic for a day
        }
    }
}
