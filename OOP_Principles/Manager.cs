using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    //The "Manager" class "takes" the attributes and methods of "employee" class (and of "person" class too)(Inheritance)
    internal class Manager: Employee
    {
        string department;

        public Manager(string department, int employee_number, DateTime starting_date, decimal salary, string name, int age, int height, int weight, string gender) : base(employee_number, starting_date, salary, name, age, height, weight, gender)
        {
            this.department = department;
        }

        //this is polymorphism
        //the "manager" class "takes" a method from "employee" but implements it in its own way (polymorphism)
        public decimal increase_salary()
        {
            if (this.starting_date < DateTime.Now.AddYears(-1)) return (decimal)((double)salary * 1.20);
            return salary;
        }

        public string get_info()
        {
            return get_Employee_properties() + $"department: {department};\n";
        }

    }
}
