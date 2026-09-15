using System;
using System.Security.Cryptography.X509Certificates;

namespace Lesson3
{
    internal class Program
    {
        static void Main()
        {

            Person person = new Person();

            Console.WriteLine("Name:" + " " + person.name);
            Console.WriteLine("Age:" + " " + person.age);
            Console.WriteLine("BirthDay:" + " " + person.birthday.ToString("dd.MM.yyyy"));
            Console.WriteLine("Gender:" + " " + (person.gender==true?"Female":"Male"));
        }
    }
}