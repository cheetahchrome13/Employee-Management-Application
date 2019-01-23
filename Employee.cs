using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private string employeeType;
        private double salary;

        public Employee()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="empType"></param>
        /// <param name="salary"></param>
        public Employee(string firstName, string lastName, string employeeType, double salary)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.employeeType = employeeType;
            this.salary = salary;
        }

        #region Properties
        /// <summary>
        /// Properties/getters/setters
        /// </summary>
        public string EmployeeType
        {
            get
            {
                return employeeType;
            }

            set
            {
                employeeType = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
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
                lastName = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return lastName + ", " + firstName;
            //return lastName;
        }

        public string ToFileString()
        {
            return lastName + "," + firstName + "," + employeeType + "," + salary;
        }
    }

}
