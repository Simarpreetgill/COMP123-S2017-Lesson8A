using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("-----------------");
            Console.WriteLine();

            Person person = new Person("Deep",22);
            person.Talks();

            Student student = new Student("Simar", 19, "123456789");
            student.Studies();
            student.Talks();

            DomesticStudent domestic = new DomesticStudent("Mary", 21, "45678912");
            student.Studies();
            student.Talks();
            domestic.Talks();
        }
    }
}
