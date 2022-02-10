using System;
using ClassLibrary1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Utils.GenNumOrder("Иванов Иван Иванович", DateTime.Now));
            Console.ReadKey();
        }
    }
}
















using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Utils
    {
        public static string GenNumOrder(string client, DateTime date)
        {
            var fullName = client.Split(' ');
            return $"{fullName[0]} {fullName[1].Substring(0, 1)}.{fullName[2].Substring(0, 1)}._{date.ToString("MM.dd.yyyy")}_{date.ToString("HH")}_{date.ToString("mm")}";
        }
    }
}

