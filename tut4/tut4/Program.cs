using System;
using System.Collections.Generic;

namespace tut4
{
    class Program
    {
        static List<Employee> FilterByGender(List<Employee> staff, Gender gender)
        {
            List<Employee> employeeFiltered = new List<Employee>();
            foreach (Employee employee in staff)
            {
                if (employee.gender == gender)
                {
                    employeeFiltered.Add(new Employee { name = employee.name, id = employee.id, gender = employee.gender });
                }
            }
            return employeeFiltered;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Employee> employees = new List<Employee>();
            employees.Add( new Employee { name = "Jane", id = 1, gender = Gender.F });
            employees.Add(new Employee { name = "Bob", id = 2, gender = Gender.M });
            employees.Add(new Employee { name = "Shawn", id = 3, gender = Gender.X });
            employees.Add(new Employee { name = "Linne", id = 4, gender = Gender.F });
            employees.Add(new Employee { name = "Lily", id = 5, gender = Gender.F });
            employees.Add(new Employee { name = "Alice", id = 6, gender = Gender.F });
            // Type the gender to be filtered 
            Console.WriteLine("Enter gender (F/M/X):");

            string genderinput = Console.ReadLine();
            Gender genderIn = (Gender)Enum.Parse(typeof(Gender), genderinput);//convert string to enum value
            List<Employee> newList = FilterByGender(employees, genderIn);
            foreach (Employee employee in newList)
            {
                Console.Write($"{employee} \n");
            }

        }

    }
}
