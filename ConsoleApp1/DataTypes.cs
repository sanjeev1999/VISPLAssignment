using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DataTypes
    {

        public static void datatype()
        {

            // Implicit conversions (Widening)
            int intValue = 42;
            long longValue = intValue; 
            float floatValue = intValue; 
            double doubleValue = floatValue; 

            Console.WriteLine($"Implicit Conversions (Widening):");
            Console.WriteLine($"int to long: {longValue}");
            Console.WriteLine($"int to float: {floatValue}");
            Console.WriteLine($"float to double: {doubleValue}");

            double doubleVal = 123.45;
            int intVal = (int)doubleVal; // Explicit conversion from double to int using casting

            Console.WriteLine($"\nExplicit Conversions (Narrowing):");
            Console.WriteLine($"double to int: {intVal}");

            
            int anotherIntValue = 55;
            short shortValue = (short)anotherIntValue; // Explicit conversion from int to short

            char charValue = 'A';
            int charToInt = (int)charValue;          // Explicit conversion from char to int

            Console.WriteLine($"\nMore Explicit Conversions:");
            Console.WriteLine($"int to short: {shortValue}");
            Console.WriteLine($"char to int: {charToInt}");

          
            

        }

    }
}



