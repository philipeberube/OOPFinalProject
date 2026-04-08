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

        public void AddWarehouse(Warehouse w)
        {
            warehouses.Add(w);
        }

        public void AddPackage(Package p)
        {
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
                foreach (Warehouse warehouse in warehouses)
                {
                    if (bestVehicle == null)
                    {
                        bestVehicle = warehouse.FindBestVehicle(package);
                        foreach (Driver driver in warehouse.AssignWorker())
                        {
                            if (driver.GetIsAvailable())
                            {
                                assignedDriver = driver;
                                break;
                            }
                        }
                        
                    }
                    if (bestVehicle != null && assignedDriver != null)
                    {
                        // Assign the package to the vehicle and driver
                        bestVehicle.SetCurrentLoad(package.GetWeight());
                        assignedDriver.AddTask(1);
                    }
                }
            }

            // Logic to assign packages to vehicles and deliver them
        }

        public void SimulateDay()
        {
            // Main simulation logic for a day
        }
    }
}
