
// Amir Moeini Rad
// August 2025

// Main Concept: Demonstrating the minimum and maximum values of various data types in C#

using System;

namespace MinAndMax
{
    class MyApp
    {
        public static void Main()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Min and Max value types in C#.NET.");
            Console.WriteLine("----------------------------------\n");


            Console.WriteLine("char: {0} to {1}", (int)char.MinValue, (int)char.MaxValue);
            Console.WriteLine("sbyte: {0} to {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("byte: {0} to {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("short: {0} to {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("ushort: {0} to {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("int: {0} to {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("uint: {0} to {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("long: {0} to {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("ulong: {0} to {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("float: {0} to {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double: {0} to {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal: {0} to {1}", decimal.MinValue, decimal.MaxValue);


            float a = 3.5f;
            Console.WriteLine("\na = " + a);


            Console.WriteLine("\nDone.");
        }
    }
}