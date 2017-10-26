using System;

namespace CreateClass
{
    public class Employee : Person
    {
        private int salary;
        private string profession;
        private Room room;

        public Employee(string name, DateTime birthDate, Gender gender, int salary, string profession, Room room)
                        : base (name, birthDate, gender ) {
            this.salary = salary;
            this.profession = profession;
            this.room = room;
        }

        public int Salary {
            get { return salary; }
            set { salary = value; }
        }

        public string Profession {
            get { return profession; }
            set { profession = value; }
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