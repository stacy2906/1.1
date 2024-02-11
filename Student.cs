using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Student:Person
    {
        private DateTime birth;

        private int kurs;



        public DateTime Birth

        {

            get { return birth; }



            set { birth = value; }

        }

        public int Kurs



        {



            get { return kurs; }



            set { kurs = value; }

        }



        public Student() { }

        public Student(string name, DateTime birth, int kurs) : base(name)

        {

            this.birth = birth;

            this.kurs = kurs;

        }

        public override void Print()
        {

            Console.WriteLine($"Name: {Name}, Birth: {birth.ToShortDateString()}, Kurs: {kurs}");

        }


    }
}
