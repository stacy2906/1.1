using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. создать объект базового класса и обратиться к методу вывода состояния объекта базового класса;
            Person person = new Person { Name = "Johnny", Age = 25,Surname = "Cage" };
            person.Print();

            // 2. создать объект производного класса и обратиться к методу вывода информации о сотруднике производного класса;
            Employee employee = new Employee { Name = "Alex", Age = 30, Company = "Microsoft", Job = "Manager" };
            employee.Print();

            // 3. создать ссылку типа базового класса на объект производного класса и обратиться к методу вывода состояния объекта базового класса
            Person employeeAsPerson = new Employee { Name = "Jane", Age = 28, Company = "Microsoft", Job = "Development" };
            employeeAsPerson.Print();

            //List<Person> person = new List<Person>();
            //person.Add(new Person("Olga", 17, "Cage"));
            //person.Add(new Employee("stacy",17,"Microsofr","Programmer"));
            //person.Add(new Student("Kate",  new DateTime(2006, 7, 20), 1900));
            //foreach (var dt in person)
            //{
              //  dt.Print();
            //}
            Console.ReadKey();
        }
    }
}
