using System;

namespace CreateClass
{
    public class Employee : Person, ICloneable
    {
        private int salary;
        private string profession;
        private Room room;

        public Employee(string name, DateTime birthDate, Gender gender, int salary, string profession)
                        : base (name, birthDate, gender ) {
            this.salary = salary;
            this.profession = profession;
        }

        public int Salary {
            get { return salary; }
            set { salary = value; }
        }

        public string Profession {
            get { return profession; }
            set { profession = value; }
        }

        public Room Room {
            get { return room; }
            set { room = value; }
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }

        public override string ToString(){
            return "Employee: " + Name + ", " 
                    + BirthDate.ToShortDateString() + ", " 
                    + Gender + ", " 
                    + salary + ", "
                    + profession;
        }
    }
}