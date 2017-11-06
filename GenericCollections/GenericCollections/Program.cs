using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary[44] = "United Kingdom";
            dictionary[33] = "France";
            dictionary[31] = "Netherlands";
            dictionary[55] = "Brazil";
            //dictionary["55"] = "Brazil";

            Console.WriteLine("44 is {0}", dictionary[44]);

            foreach (int countrycode in dictionary.Keys)
            {
                Console.WriteLine(countrycode + " is " + dictionary[countrycode]);
            }

            Console.ReadLine();
        }
    }
}
