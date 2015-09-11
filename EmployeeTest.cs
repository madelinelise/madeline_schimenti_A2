using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madeline_schimenti_A2
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee("Madeline", "Schimenti", (decimal)36000.00);
            Employee employee2 = new Employee("Ronald", "Jensen", (decimal)38400.84);
          

            Console.WriteLine("Employee " + employee1.FirstName + " " + employee1.LastName + " earns " + employee1.YearSalary.ToString("C") + " a year");
            Console.WriteLine("Employee " + employee2.FirstName + " " + employee2.LastName + " earns " + employee2.YearSalary.ToString("C") + " a year");

            employee1.YearSalary = employee1.YearSalary * Convert.ToDecimal(1.1);

            employee2.YearSalary = employee2.YearSalary * Convert.ToDecimal(1.1);

            Console.WriteLine("\n Giving Employees a 10% raise... \n");

            Console.WriteLine("Employee " + employee1.FirstName + " " + employee1.LastName + " now earns " + employee1.YearSalary.ToString("C") + " a year");
            Console.WriteLine("Employee " + employee2.FirstName + " " + employee2.LastName + " now earns " + employee2.YearSalary.ToString("C") + " a year");


            Console.ReadLine();
        }
       
    }
}
