using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DynamicCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\System.Web.dll";

            // Get the Assembly from the file
            Assembly webAssembly = Assembly.LoadFile(path);

            // Get the type to the HttpUtility class
            Type utilType = webAssembly.GetType("System.Web.HttpUtility");

            // Get the static HtmlEncode and HtmlDecode methods
            MethodInfo encode = utilType.GetMethod("HtmlEncode", new Type[] { typeof(string) });
            MethodInfo decode = utilType.GetMethod("HtmlDecode", new Type[] { typeof(string) });

            // Create a string to be encoded
            string originalString = "This is Sally & Jack's Anniversary <sic>";

            Console.WriteLine(originalString);

            // encode it and show the encoded value
            string encoded = (string)encode.Invoke(null, new object[] { originalString });

            Console.WriteLine(encoded);

            // decode it to make sure it comes back right
            string decoded = (string)decode.Invoke(null, new object[] { encoded });

            Console.WriteLine(decoded);
            Console.ReadLine();
        }
    }
}
