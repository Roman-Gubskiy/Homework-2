using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application. 
            Напишите программу, в которой создайте переменную min. Значение переменной должен задавать 
            пользователь, интервал допустимых значений 0 до 59, необходимо организовать проверку на ввод 
            допустимого интервала. Определите в какую четверть часа попадает значение переменной (в
            первую, вторую, третью или четвертую).*/


            /*string b = (a >= 0 && a <= 15) ? "Первая" : (a > 15 && a <= 30) ? "Вторая" : (a > 30 && a <= 45) ? "Третья" : (a > 45 && a <= 60) ? "Четвертая" : "Ошибка!";
            Console.Write(b);*/

            Console.Write("Введите минуты от 0 до 59: ");

            int a = int.Parse(Console.ReadLine());

            int min = (a > 0 && a <= 15) ? 1 : (a > 15 && a <= 30) ? 2 : (a > 30 && a <= 45) ? 3 : (a > 45 && a < 60) ? 4 : 404;
            switch (min) 
            {
                case 1:
                    Console.WriteLine("Первая четверть часа");
                    break;
                case 2:
                    Console.WriteLine("Вторая четверть часа");
                    break;
                case 3:
                    Console.WriteLine("Третья четверть часа");
                    break;
                case 4:
                    Console.WriteLine("Четвертая четверть часа");
                    break;
                case 404:
                    Console.WriteLine("Error!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
