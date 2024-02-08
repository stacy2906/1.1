using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Employee:Person
    {
        private string company;
        private string job;

        public string Company
        {
            get { return company; }

            set { company = value; }
        }
        public string Job

        {

            get { return job; }

            set { job = value; }
        }

        public Employee() { }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Company: {company}, Job: {job}");
        }
    }
}
