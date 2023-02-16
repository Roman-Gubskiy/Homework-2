using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application. 
            Напишите программу, которая решает квадратное уравнение.Пользователь должен ввести
            коэффициенты а, b и с квадратного уравнения ах2 +bх + с = 0.После чего программа должна
            вывести на экран все корни этого уравнения или сообщение о том, что их нет. Рассмотреть случаи
            когда дискриминант(D) квадратного уравнения > 0, когда D<0 и когда D = 0.*/

            Console.Write("Введите коэффициент a: ");
            double  a = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = double.Parse(Console.ReadLine());
            double D = (b * b) - 4 * (a * c);
            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt((b * b) - 4 * (a * c))) / (2 * a);
                double x2 = (-b + Math.Sqrt((b * b) - 4 * (a * c))) / (2 * a);
                Console.WriteLine($"X1 = {x1}");
                Console.WriteLine($"X2 = {x2}");
            }
            else if (D == 0)
            {
                double x1 = (-b + Math.Sqrt((b * b) - 4 * (a * c))) / (2 * a);
                Console.WriteLine($"X1 = {x1}");
            }
            else if (D < 0)
            {
                Console.WriteLine("Корни отсутствуют.");
            }
            Console.ReadKey();
        }
    }
}
