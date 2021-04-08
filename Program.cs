using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {

        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("Enter employee's first name: (leave empty to exit): ");
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    break;
                }
                Console.WriteLine("Enter employee's last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter employee's ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee's photo url: ");
                string photoUrl = Console.ReadLine();

                //create a new Employee instance
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                //adds the user input into the list, combining the first and last name as one as defined in Employee.cs
                employees.Add(currentEmployee);
            }
            // This is important!
            return employees;
        }
        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {

                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));

            }
        }

        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }


    }
   
}