using System;
using System.Security.Cryptography.X509Certificates;

namespace Lesson3
{
    internal class Program
    {
        static void Main()
        {

            Person person = new Person();

            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
            Console.WriteLine(person.birthday.ToString("dd.MM.yyyy"));
            Console.WriteLine((person.gender==true?"Female":"Male"));
        }
    }
}