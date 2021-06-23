using System;

namespace ConsoleAppPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ulf", "Bengtsson");

            Console.WriteLine(person.FullName);
        }
    }
}
