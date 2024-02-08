using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Person
    {
        private string name;
        private int age;
        private string surname;

        public string Name

        {

            get { return name; }

            set { name = value; }
        }
        public int Age
        {

            get { return age; }

            set { age = value; }

        }
        public string Surname
        {

            get { return surname; }

            set { surname = value; }

        }
        public Person() { }
        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(string name, int age, string surname)
        {
            this.name = name;
            this.age = age;
            this.surname = Surname;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Surname: {surname}");
        }
    }
}

 
