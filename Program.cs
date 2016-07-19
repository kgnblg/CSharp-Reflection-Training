using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ReflectionTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFile("C:/Users/KGN/Documents/Visual Studio 2015/Projects/Doviz/Doviz/bin/Debug/Doviz.exe");
            var types = assembly.GetTypes();

            Console.WriteLine("Tipler;");
            foreach (var type in types)
            {
                var typeInfo = type.GetTypeInfo();
                Console.WriteLine("Type " + type.FullName + " has " + typeInfo.DeclaredProperties.Count().ToString() + " properties");
            }
            Console.WriteLine("************");
            Type theType = Type.GetType(types[1].ToString());
            MemberInfo[] mbrInfoArray = theType.GetMembers();
            foreach (MemberInfo mbrInfo in mbrInfoArray)
            {
                Console.WriteLine("{0}			{1}", mbrInfo.MemberType, mbrInfo.Name);
            }




            Console.ReadKey();

        }
    }
}
