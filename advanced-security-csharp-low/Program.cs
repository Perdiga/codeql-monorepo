using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace LowQualityAnalysisExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using dynamic type
            dynamic obj = new ExpandoObject();
            obj.Name = "John Doe";
            Console.WriteLine("Dynamic name: " + obj.Name);

            // Reflection used to invoke a method
            Type type = typeof(ExampleClass);
            MethodInfo methodInfo = type.GetMethod("GetSecret", BindingFlags.Static | BindingFlags.NonPublic);
            object result = methodInfo.Invoke(null, new object[] { "dynamic input" });
            Console.WriteLine("Reflection result: " + result);

            // Complex lambda expressions
            var data = new List<int> { 1, 2, 3, 4, 5 };
            var processedData = data
                .Where(x => { Console.WriteLine("Filter: " + x); return x % 2 == 0; })
                .Select(y => { Console.WriteLine("Map: " + y); return y * 2; })
                .ToList();

            Console.WriteLine("Processed Data: " + string.Join(",", processedData));
        }
    }
}