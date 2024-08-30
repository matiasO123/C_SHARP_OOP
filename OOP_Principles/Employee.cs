using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Principles
{
    //This is inheritance!!
    //the "employee" class takes the attributes and methods of the "person" class (Inheritance)
    public class Employee : Person
    {
        int employee_number;
        public DateTime starting_date;
        public decimal salary;

        public Employee(int employee_number, DateTime starting_date, decimal salary, string name, int age, int height, int weight, string gender) : base(name, age, height, weight, gender)
        {
            this.employee_number = employee_number;
            this.starting_date = starting_date;
            this.salary = salary;
        }

        //This class has its own methods and can call the methods of the person class (Inheritance)
        public decimal increase_salary()
        {
            if (starting_date < DateTime.Now.AddYears(-3)) return (decimal)((double)salary * 1.10);
            return salary;
        }

        public string get_Employee_properties()
        {
            return this.Get_person_properties() + $"employee number: {employee_number};\nsalary: {salary} U$S;\n";
        }
    }
}
