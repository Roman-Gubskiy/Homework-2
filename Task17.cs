using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Используя Visual Studio, создайте проект по шаблону Console Application. 
            Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в 
            числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100]. Если да, то укажите, в какой именно 
            промежуток. Если пользователь указывает число не входящее ни в один из имеющихся числовых 
            промежутков, то выводится соответствующее сообщение.*/

            Console.Write("(if-else) Введите число для числового ромежутка: ");
            int numberGap = int.Parse(Console.ReadLine());
            if (numberGap >= 0 && numberGap <= 14)
            {
                Console.WriteLine("Числовой промежуток [0 - 14]");
            }
            else if (numberGap >= 15 && numberGap <=35)
            {
                Console.WriteLine("Числовой промежуток [15 - 35]");
            }
            else if (numberGap >= 36 && numberGap <= 50)
            {
                Console.WriteLine("Числовой промежуток [36 - 50]");
            }
            else if (numberGap >= 51  && numberGap <= 100)
            {
                Console.WriteLine("Числовой промежуток [51 - 100]");
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.ReadKey();

            int num = 0;
            Console.Write("(switch) Введите число для числового ромежутка: ");
            int numberGap2 = int.Parse(Console.ReadLine());
            num = (numberGap2 >= 0 && numberGap2 <= 14) ? num + 1 :
                (numberGap2 >= 15 && numberGap2 <= 35) ? num + 2 :
                (numberGap2 >= 36 && numberGap2 <= 50) ? num + 3 :
                (numberGap2 >= 51 && numberGap2 <= 100) ? num + 4 : 0;


            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Числовой промежуток [0 - 14]");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Числовой промежуток [15 - 35]");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Числовой промежуток [36 - 50]");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Числовой промежуток [51 - 100]");
                        break;
                    }
                default:
                    Console.WriteLine("Неправильное число!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
