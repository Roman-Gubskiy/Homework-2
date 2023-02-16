using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application. 
            Напишите программу,  которая определяет, является ли год високосным. Пользователь вводит год. 
            Программа должна вывести на экран ответ, является ли год високосным. Подсказка. Обычно 
            каждый год, который делится на 4, — это високосный год, кроме лет столетий (делящихся на 100). 
            Но среди последних год, делящийся на 400, также считается високосным.*/

            int a = int.Parse(Console.ReadLine());

            if ((a % 4 == 0) && (a % 100 == 0) && (a % 400 == 0))
            {
                Console.WriteLine("Высокосный");                
            }
            else if ((a % 4 == 0) && (a % 100 == 0) && (a % 400 != 0))
            {
                Console.WriteLine("Не высокосный");                
            }
            else if ((a % 4 == 0) && (a % 100 != 0) && (a % 400 != 0))
            {
                Console.WriteLine("высокосный");
            }
            else
            {
                Console.WriteLine("Не высокосный");
            }
            Console.ReadKey();
        }
    }
}
