using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person("Joe", new DateTime(1990, 10, 10), Gender.Male);

            Console.WriteLine(person.ToString());
            
            Employee employee = new Employee("Jane", new DateTime(1980, 11, 11), Gender.Female, 5500, "Manager");
            employee.Room = new Room(5) ;

            Console.WriteLine(employee.ToString());

            Employee Kovacs = new Employee("Géza", DateTime.Now, Gender.Male, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;
            Console.WriteLine(Kovacs.ToString() + " " + Kovacs.Room.Number);
            Console.WriteLine(Kovacs2.ToString() + " " + Kovacs2.Room.Number);
            Console.ReadKey();

        }
    }
}
