using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrConsoleTreugolnic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("Введите сторону а1");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону а2");
            double a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону b1");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b2");
            double b2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону с1");
            double c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону с2");
            double c2 = double.Parse(Console.ReadLine());

            triangle.MetodTriangle(a1,a2,b1,b2,c1,c2);
            Console.WriteLine(triangle);

            
        }
    }
}
