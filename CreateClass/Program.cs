using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person("Joe", new DateTime(1990, 10, 10), Gender.Male);

            Console.WriteLine(person.ToString());
            
            Room room = new Room(5);
            Person employee = new Employee("Jane", new DateTime(1980, 11, 11), Gender.Female, 5500, "Manager", room);

            Console.WriteLine(employee.ToString());

        }
    }
}
