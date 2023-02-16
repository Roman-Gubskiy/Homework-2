using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application. 
            Напишите программу, в которой создайте переменную a. Значение переменной, а должен задавать 
            пользователь. Если а < 10 то выведите 'Верно', иначе (a>10) выведите 'Неверно'.*/

            Console.Write("Задайте переменную а меньше 10: ");
            int a = int.Parse(Console.ReadLine());
            if (a < 10)
            {
                Console.WriteLine("Верно");
            }
            else 
            {
                Console.WriteLine("Неверно");
            }
            Console.ReadKey();
        }
        
    }
}
