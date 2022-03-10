using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class vscode
    {
        public static string GetStudNumber(string student, DateTime date, int group)
        {
            var FullName = student.Split(' ');
            return $"{date.ToString("yyyy")}.{group}.{FullName[0]} {FullName[1].Substring(0, 1)}.{FullName[2].Substring(0, 1)}";
        }
        public void add(int a, int b)
        {
            IEnumerable<int> nums = Enumerable.Range(a, b);
            Console.WriteLine("Последовательность чисел: \n");

            foreach (int i in nums)
                Console.Write(i);
            foreach (int k in nums)
                Console.Write(k);

            double average = nums.Average();
            double min = nums.Min();
            Console.WriteLine("\n\nСреднее арифметическое: " + average);
            Console.WriteLine("\n\nМеньшее арифметическое: " + min);
        }
    }
}
    
    
    
    
    
    
    using System;
using System.Reflection;
using ClassLibrary;

namespace APP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(vscode.GetStudNumber("Иванов Иван Иванович", DateTime.Now, Convert.ToInt32("12")));
            Console.ReadKey();

            Assembly a = Assembly.Load("ClassLibrary");
            Object o = a.CreateInstance("ClassLibrary.vscode");
            Type t = a.GetType("ClassLibrary.vscode");
            Object[] numbers = new Object[2];
            numbers[0] = 1;
            numbers[1] = 5;
            MethodInfo mi = t.GetMethod("add");
            Console.WriteLine(mi.Invoke(o, numbers));
            Console.ReadLine();
        }
    }
}
