using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "cat", "dogs", "donkey", "camel" };
            string v1 = Array.Find(array1,element=>element.StartsWith("cam",StringComparison.Ordinal));
            string v2 = Array.Find(array1, element => element.Length == 3);
            Console.WriteLine("The element that starts with 'cam' is:" + v1);
            Console.WriteLine("3 letter word in the Array is:" + v2);
            Console.ReadLine();
        }
    }
}
