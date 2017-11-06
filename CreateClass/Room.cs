using System;

namespace CreateClass
{
    public class Room
    {

        private int number;

        public Room(int number){
            this.number = number;
        }

        public int Number {
            get { return number; }
            set { number = value; }
        }
    }
}