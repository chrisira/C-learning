using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeChallenge
{
    internal class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string companyCar, string Name, string firstName, int salary) : base(Name, firstName, salary)
        {
            this.CompanyCar = companyCar;
        }
        public void Lead()
        {
            Console.WriteLine("I am the boss, you feel me?");
        }
    }
}
