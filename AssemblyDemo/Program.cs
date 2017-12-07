using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\System.dll";

            // Load a specific Assembly
            Assembly a = Assembly.LoadFile(path);
            ShowAssembly(a);

            // Get our Assembly
            Assembly ourAssembly = Assembly.GetExecutingAssembly();
            ShowAssembly(ourAssembly);

            Console.Read();
        }

        public static void ShowAssembly(Assembly assembly)
        {
            Console.WriteLine(assembly.FullName + " " + assembly.GlobalAssemblyCache + " " + assembly.Location + " " + assembly.ImageRuntimeVersion);
            foreach (var module in assembly.Modules)
            {
                Console.WriteLine(module.Name);
            } 
        }
    }
}
