using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;

namespace DemoDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Assembly Name
            AssemblyName theName = new AssemblyName();
            theName.Name = "DemoAssembly";
            theName.Version = new Version("1.0.0.0");

            // Get the AppDomain to put our assembly in
            AppDomain domain = AppDomain.CurrentDomain;

            // Create the Assembly
            AssemblyBuilder assemBldr = domain.DefineDynamicAssembly(theName, AssemblyBuilderAccess.ReflectionOnly);

            // Define a module to hold our type
            ModuleBuilder modBldr = assemBldr.DefineDynamicModule("CodeModule", "DemoAssembly.dll");

            // Create a new type
            TypeBuilder animalBldr = modBldr.DefineType("Animal", TypeAttributes.Public);

            // Display the new Type
            Type animal = animalBldr.CreateType();
            Console.WriteLine(animal.FullName);

            foreach (MemberInfo m in animal.GetMembers())
            {
                Console.WriteLine(" Member ({0}): {1}", m.MemberType, m.Name);
            }

            Console.Read();
        }
    }
}
