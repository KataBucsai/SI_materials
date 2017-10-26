using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person("Joe", new DateTime(1990, 10, 10), Gender.Male);

            Console.WriteLine(person.ToString());
            
        }
    }
}
