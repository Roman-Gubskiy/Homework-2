using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application. 
            Напишите программу - консольный калькулятор. Создайте две переменные с именами operand1 и 
            operand2. Задайте переменным некоторые произвольные значения. Предложите пользователю 
            ввести знак арифметической операции. Примите значение введенное пользователем и поместите 
            его в строковую переменную sign. Для организации выбора алгоритма вычислительного процесса, 
            используйте переключатель switch. Выведите на экран результат выполнения арифметической 
            операции. В случае использования операции деления, организуйте проверку попытки деления на 
            ноль. И если таковая имеется, то отмените выполнение арифметической операции и уведомите об 
            ошибке пользователя.*/

            Console.Write("Введите первое число: ");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double operand2 = double.Parse(Console.ReadLine());
            Console.Write("Выберите действие + , - , / , * ,: ");
            string sign = (Console.ReadLine());
            switch (sign) 
            {
                case "+":
                    double result1 = (operand1 + operand2);
                    Console.Write($"Cумма: {operand1} + {operand2} = {result1}");
                    break;
                case "-":
                    double result2 = (operand1 - operand2);
                    Console.Write($"Cумма: {operand1} - {operand2} = {result2}");
                    break;
                case "/":
                    if (operand2 == 0) //проверка деления на 0!
                    {
                        Console.Write($"Cумма: {operand1} / {operand2} = 0");
                    }
                    else
                    {
                        double result3 = (operand1 / operand2);
                        Console.Write($"Cумма: {operand1} / {operand2} = {result3}");
                    }
                    break;
                case "*":
                    double result4 = (operand1 * operand2);
                    Console.Write($"Cумма: {operand1} * {operand2} = {result4}");
                    break;
                default:
                    Console.WriteLine("Неверное действие!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
