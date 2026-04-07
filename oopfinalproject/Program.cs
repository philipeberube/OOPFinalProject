using System.ComponentModel.DataAnnotations;

namespace oopfinalproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entity[] machine = new Entity[10];
            Vehicle[] vehicles = new Vehicle[10];
            int choice = 0;
            try
            {
                do
                {
                    Console.WriteLine("     Main Menu");
                    Console.WriteLine("1: Add entities");
                    Console.WriteLine("2: Assign deliveries");
                    Console.WriteLine("3: Sort ");
                    Console.WriteLine("4: Search");
                    Console.WriteLine("5: Run simulation");
                    Console.WriteLine("6: Undo");
                    Console.WriteLine("7: Save/Load");
                    Console.WriteLine("8: Exit");
                    Console.WriteLine("Enter choice");
                    choice = int.Parse(Console.ReadLine());

                    if(choice < 1 || choice > 8)
                    {
                        throw new ValidationException("invalid choice please enter a number between 1 and 8");
                    }
                    else
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Add entities");
                                break;
                            case 2:
                                Console.WriteLine("Assign deliveries");
                                break;
                            case 3:
                                Console.WriteLine("Sort");
                                break;
                            case 4:
                                Console.WriteLine("Search");
                                break;
                            case 5:
                                Console.WriteLine("Run simulation");
                                break;
                            case 6:
                                Console.WriteLine("Undo");
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

                } while ( choice != 8);
            }catch(ValidationException ex)
            {
                Console.WriteLine(ex.Message);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            
            Console.WriteLine("Hello, World!");

        }
    }
}
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
