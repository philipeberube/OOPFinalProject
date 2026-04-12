using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace oopfinalproject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DeliverySystem deliverySystem = new DeliverySystem();
            Vehicle[] vehicles = new Vehicle[10];
            int choice = 0;
            try
            {
                do
                {
                    Console.WriteLine("======Main Menu======");
                    Console.WriteLine("1: Add entities");
                    Console.WriteLine("2: Assign deliveries");
                    Console.WriteLine("3: Sort ");
                    Console.WriteLine("4: Search");
                    Console.WriteLine("5: Run simulation");
                    Console.WriteLine("6: Undo");
                    Console.WriteLine("7: Save/Load");
                    Console.WriteLine("8: Exit");
                    Console.WriteLine("=====================");
                    Console.WriteLine("Enter choice");
                    choice = int.Parse(Console.ReadLine());

                    if (choice < 1 || choice > 8)
                    {
                        throw new ValidationException("invalid choice please enter a number between 1 and 8");
                    }
                    else
                    {
                        switch (choice)
                        {
                            case 1:
                                if(vehicles.Length >= 10)
                                {
                                    throw new Exception("Vehicle limit has reached Max 10 vehicles");
                                }
                                AddEntities();
                                break;
                            case 2:
                                if(vehicles.Length == null || vehicles.Length == 0)
                                {
                                    throw new Exception("No vehicles added yet please add Vehicle(s) before assigning deliveries");
                                }
                                AssignDeliveries(deliverySystem);
                                break;
                            case 3:
                                if (vehicles.Length == null || vehicles.Length == 0)
                                {
                                    throw new Exception("No vehicles added yet please add Vehicle(s) to sort");
                                }
                                else if(deliverySystem == null)
                                {
                                    throw new Exception("No deliveries assigned yet please assign deliveries before sorting");
                                }
                                    Sort(deliverySystem);
                                break;
                            case 4:
                                if (vehicles.Length == null || vehicles.Length == 0)
                                {
                                    throw new Exception("No vehicles added yet please add Vehicle(s) to Search for delivery(s)");
                                }
                                else if (deliverySystem == null)
                                {
                                    throw new Exception("No deliveries assigned yet please assign deliveries before searching");
                                }
                                Search(deliverySystem);
                                break;
                            case 5:
                                if (vehicles.Length == null || vehicles.Length == 0)
                                {
                                    throw new Exception("No vehicles added yet please add Vehicle(s) to run Simulation for delivery(s)");
                                }
                                else if (deliverySystem == null)
                                {
                                    throw new Exception("No deliveries assigned yet please assign deliveries before running simulation");
                                }
                                RunSimulation(deliverySystem);
                                break;
                            case 6:
                                if (vehicles.Length == null || vehicles.Length == 0)
                                {
                                    throw new Exception("No vehicles added yet please add Vehicle(s) to undo");
                                }
                                else if (deliverySystem == null)
                                {
                                    throw new Exception("No deliveries assigned yet please assign deliveries before undoing");
                                }
                                Undo();
                                break;
                            case 7:
                                Console.WriteLine("Save/Load");
                                Console.WriteLine("Succesfully Save/Load");
                                break;
                            case 8:
                                Console.WriteLine("Byee byee");
                                break;
                            default:
                                Console.WriteLine("error");
                                break;

                        }
                    }

                } while (choice != 8);
            } catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    
        public static void AddEntities()
        {
            int choice = 0;
            try
            {
                do
                {
                    Console.WriteLine("Add entity menu");
                    Console.WriteLine("1: Add Van");
                    Console.WriteLine("2: Add Truck");
                    Console.WriteLine("3: Add Drone");
                    Console.WriteLine("4: Add Driver");
                    Console.WriteLine("5: Add Loader");
                    Console.WriteLine("6: Add Manager");
                    
                    Console.WriteLine("7: Cancel");
                    choice = int.Parse(Console.ReadLine());
                    if (choice < 1 || choice > 9)
                    {
                        throw new ValidationException("invalid choice please enter a number between 1 and 7");
                    }
                    

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Add Van");
                            string vanName;
                            Console.WriteLine("Name of van");
                            vanName = Console.ReadLine();
                            Console.WriteLine("Speed of van");
                            double vanSpeed = double.Parse(Console.ReadLine());
                            double vanMaxCapacity;
                            Console.WriteLine("Max capacity of van");
                            vanMaxCapacity = double.Parse(Console.ReadLine());
                            bool vanElectric = false;
                            Console.WriteLine("Is the van electric? (y/n)");
                            string electricInput = Console.ReadLine();
                            if (electricInput.ToLower() == "y")
                            {
                                vanElectric = true;
                            }

                            Van van = new Van(1, vanName, DateTime.Now, vanSpeed, vanMaxCapacity, 0, true, vanElectric);
                            break;
                        case 2:
                            Console.WriteLine("Add Truck");
                            string truckName;
                            Console.WriteLine("Name of truck");
                            truckName = Console.ReadLine();
                            Console.WriteLine("Speed of truck");
                            double truckSpeed = double.Parse(Console.ReadLine());
                            double truckMaxCapacity;
                            Console.WriteLine("Max capacity of truck");
                            truckMaxCapacity = double.Parse(Console.ReadLine());
                            Console.WriteLine("Fuel consumption of truck");
                            double truckFuelConsumption = double.Parse(Console.ReadLine());

                            Truck truck = new Truck(1, truckName, DateTime.Now, truckSpeed, truckMaxCapacity, 0, true, truckFuelConsumption);
                            break;
                        case 3:
                            Console.WriteLine("Add Drone");
                            string droneName;
                            Console.WriteLine("Name of drone");
                            droneName = Console.ReadLine();
                            Console.WriteLine("Speed of drone");
                            double droneSpeed = double.Parse(Console.ReadLine());
                            double droneMaxCapacity;
                            Console.WriteLine("Max capacity of drone");
                            droneMaxCapacity = double.Parse(Console.ReadLine());
                            Console.WriteLine("Max distance of drone");
                            double droneMaxDistance = double.Parse(Console.ReadLine());

                            Drone drone = new Drone(1, droneName, DateTime.Now, droneSpeed, droneMaxCapacity, 0, true, droneMaxDistance);
                            break;
                        case 4:
                            Console.WriteLine("Add Driver");
                            string driverName;
                            Console.WriteLine("Name of driver");
                            driverName = Console.ReadLine();
                            Console.WriteLine("years of experience of driver");
                            int driverExperience = int.Parse(Console.ReadLine());
                            Console.WriteLine("license type of driver");
                            string driverLicenseType = Console.ReadLine();

                            Driver driver = new Driver(1, driverName, DateTime.Now, driverExperience,0,true, driverLicenseType);
                            break;
                        case 5:
                            Console.WriteLine("Add Loader");
                            string loaderName;
                            Console.WriteLine("Name of loader");
                            loaderName = Console.ReadLine();
                            Console.WriteLine("years of experience of loader");
                            int loaderExperience = int.Parse(Console.ReadLine());
                            Console.WriteLine("max lift weight of loader");
                            double loaderMaxLiftWeight = double.Parse(Console.ReadLine());

                            Loader loader = new Loader(1, loaderName, DateTime.Now, loaderExperience, 0, true, loaderMaxLiftWeight);
                            break;
                        case 6:
                            Console.WriteLine("Add Manager");
                            string managerName;
                            Console.WriteLine("Name of manager");
                            managerName = Console.ReadLine();
                            Console.WriteLine("years of experience of manager");
                            int managerExperience = int.Parse(Console.ReadLine());
                            Console.WriteLine("number of workers under manager");
                            int teamSize = int.Parse(Console.ReadLine());

                            Manager manager = new Manager(1, managerName, DateTime.Now, managerExperience, 0, true, teamSize);
                            break;
                        
                        case 7:
                            Console.WriteLine("Canceling...");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                } while (choice != 7);
            } catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }


         public static void AssignDeliveries(DeliverySystem deliverySystem) 
        { 
            int choice = 0;
            
            try
            {
                do {
                    Console.WriteLine("Deliveries Main Menu");
                    Console.WriteLine("1: Add Warehouse");
                    Console.WriteLine("2: Add Package");
                    Console.WriteLine("3: Send Delivery");
                    Console.WriteLine("4: Cancel Delivery");
                    Console.WriteLine("5: Cancel");
                    choice = int.Parse(Console.ReadLine());
                    if (choice < 1 || choice > 5)
                    {
                        throw new ValidationException("invalid choice please enter a number between 1 and 5");
                    }
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Add Warehouse");
                            string warehouseName;
                            Console.WriteLine("Name of warehouse");
                            warehouseName = Console.ReadLine();
                            Warehouse warehouse = new Warehouse(warehouseName);
                            deliverySystem.AddWarehouse(warehouse);
                            break;
                        case 2:
                            Console.WriteLine("Add Package");
                            int packageId;
                            Console.WriteLine("ID of package");
                            packageId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Priority level of package (1-5)");
                            int priorityLevel = int.Parse(Console.ReadLine());
                            if (priorityLevel < 1 || priorityLevel > 5)
                            {
                                throw new ValidationException("Priority level must be between 1 and 5.");
                            }
                            Console.WriteLine("Weight of package");
                            double packageWeight = double.Parse(Console.ReadLine());
                            Console.WriteLine("Destination of package");
                            string packageDestination = Console.ReadLine();

                            deliverySystem.AddPackage(new Package(packageId, packageWeight, priorityLevel, packageDestination));
                            break;
                        case 3:
                            Console.WriteLine("Sending Delivery");
                            deliverySystem.ProcessDeliveries();    
                            break;
                        case 4:
                            Console.WriteLine("Canceling Delivery");
                            int pkId;
                            Console.WriteLine("Enter package ID to cancel");
                            pkId = int.Parse(Console.ReadLine());
                            deliverySystem.CancelDelivery(pkId);
                            break;
                        case 5:
                            Console.WriteLine("Canceling");
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                } while (choice != 5);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

         public static void Sort(DeliverySystem deliverySystem) 
        { 
            Console.WriteLine("Sorting packages by priority score...");
            deliverySystem.SortPackages();
        }

        public static void Search(DeliverySystem deliverySystem) 
        { 
            Console.WriteLine("Enter package ID to search:");
            int packageId = int.Parse(Console.ReadLine());
            Package package = deliverySystem.SearchPackageById(packageId);
            if (package != null)
            {
                Console.WriteLine($"Package found: {package.GetPackageID()}");
            }
            else
            {
                Console.WriteLine($"Package {packageId} not found.");
            }
        }

        public static void RunSimulation(DeliverySystem deliverySystem) 
        { 
            Console.WriteLine("Running daily simulation...");
            deliverySystem.SimulateDay();
        }

        public static void Undo()
        { }

        public static void Save() 
        { }

        public static void Load() 
        { }

    }
}

/*
 * MENU REQUIREMENT
Must include:
 Add entities
 Assign deliveries
 Sort
 Search
 Run simulation
 Undo
 Save/Load
 * */


public class CustomExceptions
{
}
public class InvalidDataException : Exception
{
    public InvalidDataException() { }
    public InvalidDataException(string message) : base(message) { }
}
public class OverCapacityException : Exception
{
    public OverCapacityException() { }
    public OverCapacityException(string message) : base(message) { }
}
public class EmptyStructureException : Exception
{
    public EmptyStructureException() { }
    public EmptyStructureException(string message) : base(message) { }
}
