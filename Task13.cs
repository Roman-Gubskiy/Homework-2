using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application. 
            напишите программу, в которой пользователь вводит целое число. Программа в свою очередь 
            должна ответить, четным или нечетным является это число, делится ли оно на 3 и делится ли оно на 
            6.*/

            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            string a = (number % 2 == 0 ) ? ", Четное" : ", Нечетное";
            string b = (number % 3 == 0) ? ", делится на 3" : ", не делится на 3";
            string c = (number % 6 == 0) ? ", делится на 6. " : ", не делится на 6. ";
            Console.Write("Число: " + number + a + b + c);
            Console.ReadKey();
        }
    }
}
