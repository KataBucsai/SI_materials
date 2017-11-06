using System;

namespace CreateClass
{
    public class Person
    {
       private string name;
       private DateTime birthDate;
       private Gender gender;

        public  Person() {

        } 

       public Person(string name, DateTime birthDate, Gender gender) {
           this.name = name;
           this.birthDate = birthDate;
           this.gender = gender;
       }
       
       public string Name {
           set { name = value; } 
           get { return name;}
       }

       public DateTime BirthDate {
           set { birthDate = value; }
           get { return birthDate; }
       }

       public Gender Gender {
           set { gender = value; }
           get { return gender; }
       }

       public override string ToString() {
           return "Person: " + Name + ", " + BirthDate.ToShortDateString() + ", " + Gender;
       }

    }
    public enum Gender { Male, Female };

}
