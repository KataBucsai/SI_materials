using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable["1"] = "One";
            hashtable["0"] = "Zero";
            hashtable["2"] = "Two";
            hashtable["3"] = "Three";
            hashtable["4"] = "Four";
            hashtable["5"] = "Five";
            hashtable["6"] = "Six";
            hashtable["7"] = "Seven";
            hashtable["8"] = "Eight";
            hashtable["9"] = "Nine";

            string number = "5351542978468";
            
            foreach (char num in number)
            {
                string digit = num.ToString();
                if (hashtable.ContainsKey(digit))
                {
                    Console.WriteLine(hashtable[digit]);
                }
            }

            
            Console.ReadLine();
        }
    }
}
