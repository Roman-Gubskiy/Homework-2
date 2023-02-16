using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Дано 2 числа, а = 10, b = 20. Написать программу, которая выполняет сложение данных чисел, 
            вычитание, умножение, деление, получения остатка от деления, переменные которые хранят 
            результат данных операция должны быть типа byte. Результат  выполнения программы вывести на 
            Console.*/

            byte a = 10, b = 20;
            byte c = (byte) (a + b);
            byte d = (byte) (a - b);
            byte e = (byte) (a * b);
            byte i = (byte) (a / b);
            byte o = (byte) (a % b);
            Console.WriteLine($"{a} + {b} = {c}");
            Console.WriteLine($"{a} - {b} = {d}");
            Console.WriteLine($"{a} * {b} = {e}");
            Console.WriteLine($"{a} / {b} = {i}");
            Console.WriteLine($"{a} % {b} = {o}");
            Console.ReadKey();
        }
    }
}
