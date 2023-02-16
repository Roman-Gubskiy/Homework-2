using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Создать программу, которая запрашивает имя пользователя и здоровается с ним. Для вывода 
            информации использовать 3 варианта конкатенации строк.*/
            
            Console.Write("Введите Ваше имя: ");
            string name = (Console.ReadLine());
            string hello = "Привет";
            Console.WriteLine(hello + " " + name);
            Console.WriteLine($"{hello} {name}");
            Console.WriteLine("Привет " + name);
            Console.ReadKey();
        }
    }
}
