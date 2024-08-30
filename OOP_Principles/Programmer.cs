using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    //The "Programmer" class "takes" the attributes and methods of "employee" class (and of "person" class too)(Inheritance)
    internal class Programmer: Employee
    {
        string language;

        public Programmer(string language, int employee_number, DateTime starting_date, decimal salary, string name, int age, int height, int weight, string gender) : base(employee_number, starting_date, salary, name, age, height, weight, gender)
        {
            this.language = language;
        }
    }
}
