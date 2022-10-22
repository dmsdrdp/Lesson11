using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано: 0=kx+b");
            Console.WriteLine("Введите значение k");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            double b = Convert.ToDouble(Console.ReadLine());

            Linear linear = new Linear(k, b);
            Console.WriteLine(linear.Root());
            Console.ReadKey();  
        }
    }
}
