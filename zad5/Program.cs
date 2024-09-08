using System;
using zad5;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter employee name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter employee age: ");
                    if (!int.TryParse(Console.ReadLine(), out int age))
                    {
                        Console.WriteLine("Age must be a number. Try again.");
                        continue;
                    }

                    Console.Write("Enter employee job (Driver, Mechanic, Personnel): ");
                    string job = Console.ReadLine();

                    Console.Write("Enter years of experience: ");
                    if (!int.TryParse(Console.ReadLine(), out int experience))
                    {
                        Console.WriteLine("Experience must be a number. Try again.");
                        continue;
                    }

                    Console.Write("Enter education level (Primary, Secondary, Higher): ");
                    string education = Console.ReadLine();

                    Employee employee = new Employee(name, age, job, experience, education);
                    double salary = employee.CalculateSalary();

                    Console.WriteLine("\nEmployee Details:");
                    Console.WriteLine("Name: " + employee.Name);
                    Console.WriteLine("Age: " + employee.Age);
                    Console.WriteLine("Job: " + employee.Job);
                    Console.WriteLine("Experience: " + employee.Experience + " years");
                    Console.WriteLine("Education: " + employee.Education);
                    Console.WriteLine("Calculated Salary: " + salary + " USD\n");
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                }
                else if (choice == "2")
                {
                    running = false;
                    Console.WriteLine("Exiting program...");
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again.");
                }
            }
        }
    }
}