using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madeline_schimenti_A2
{
    class Employee
    {
        string firstName;
        string lastName;
        private decimal yearSalary;

        
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName= value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public decimal YearSalary
        {
            get
            {
                return yearSalary;
            }
            set
            {
                if (value >=0)
                this.yearSalary = value;
            }
        }

        public Employee(string tfirstName, string tlastName, decimal tyearSalary)
        {

            FirstName = tfirstName;

            LastName = tlastName;

            YearSalary = tyearSalary;

        } // end Employee constructor

       


       
    } // end Employee Class

}
