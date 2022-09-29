using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeChallenge
{
    internal class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }
        public Employee()
        {
            Name = "Chris";
            FirstName = "IRADUKUNDA";
            Salary = 20000;
        }

        public void Working()
        {
            Console.WriteLine("I am working !");
        }
        public void Pause()
        {
            Console.WriteLine("I am taking a pause");
        }
    }
}
