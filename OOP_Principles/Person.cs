using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    //This is a class!
    //It is a template, a model
    public class Person
    {
        //These are the attributes or properties (encapsulation)
        string name { get; set; }
        int age { get; set; }
        int height { get; set; }
        int weight { get; set; }
        string gender { get; set; }
        public int special_secret_number { get; set; }

        //These are the methods. Specific functions that only a person can do (encapsulation)
        public void breathe() { }
        public void walk() { }
        public void sleep() { }
        public void study() { }

        //This is a constructor. Calling it we can "start" a person. (encapsulation)
        public Person(string name, int age, int height, int weight, string gender)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.gender = gender;
        }

        //this is a method that has an internal processing. No one can see it from the outside.
        //this method returns a number based in the number sent in the parameters. But no one knows (except the class itself) how to generate it
        public int Generate_Special_Secret_Number(int number)
        {
            return number * 2 + 1 * 2 * 2;
        }

        public string Get_person_properties()
        {
            return $"Name: {name};\nage: {age};\ngender: {gender};\n";
        }
    }
}
