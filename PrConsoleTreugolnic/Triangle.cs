using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrConsoleTreugolnic
{
    public class Triangle
    {

        public void MetodTriangle(double a1, double a2, double b1, double b2, double c1, double c2)
        {

            double a = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b1 - b2, 2));
            double b = Math.Sqrt(Math.Pow(b2 - b1, 2) + Math.Pow(c1 - c2, 2));
            double c = Math.Sqrt(Math.Pow(c2 - c1, 2) + Math.Pow(a1 - a2, 2));
            double alpha = 0;
            double betta = 0;
            double gamma = 0;
            
            alpha = (((Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180)) / Math.PI);
            betta = (((Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180)) / Math.PI);
            gamma = (((Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180)) / Math.PI);
            Console.WriteLine("_______________________________________________________");
            if ((a < b + c) & (b < c + a) & (c < b + a))
            {
                if ((alpha == 90) || (betta == 90) || (gamma == 90)) Console.WriteLine(" Треугольник прямоугольный");
                else
                    if ((alpha > 90) || (betta > 90) || (gamma > 90)) Console.WriteLine("Треугольник тупоугольный");
                else
                    Console.WriteLine("Треугольник остроугольный");
            }
            else
                Console.WriteLine("Теугольник не существует");
            Console.ReadKey();
        }
    }
}
