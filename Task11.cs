using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие
            Используя Visual Studio, создайте проект по шаблону Console Application. 
            Напишите программу, которая будет рассчитывать процент скидки в зависимости от количества 
            купленного товара. Если куплено больше 3 единиц товара, тогда скидка должна быть 10 процентов 
            от общей суммы, если же количество больше 3 и меньше 7, то 20процентов от общей суммы, иначе, 
            если больше 7 то 25 процентов от общей суммы. Цену товара и купленное количество товара 
            пользователь должен задавать вводом с консоли. */

            Console.Write("Введите цену товара: ");
            int priceProduct = int.Parse(Console.ReadLine());
            Console.Write("Введите количество товара: ");
            int quantityGoods = int.Parse(Console.ReadLine());
            if (quantityGoods <= 3 && quantityGoods > 0)
            {
                int result1 = ((priceProduct * quantityGoods) * 10 / 100);
                Console.WriteLine("Вы купили от 1-3 товаров.");
                Console.WriteLine("Скидка составляет 10%: " + result1 + " UAH");
                Console.WriteLine("К оплате " + ((priceProduct * quantityGoods) - result1) + " UAH");
            }
            if (quantityGoods > 3 && quantityGoods < 7)
            {
                int result1 = ((priceProduct * quantityGoods) * 20 / 100);
                Console.WriteLine("Вы купили от 4-6 товаров.");
                Console.WriteLine("Скидка составляет 20%: " + result1 + " UAH");
                Console.WriteLine("К оплате " + ((priceProduct * quantityGoods) - result1) + " UAH");
            }
            if (quantityGoods >= 7)
            {
                int result1 = ((priceProduct * quantityGoods) * 25 / 100);
                Console.WriteLine("Вы купили 7 и больше товаров.");
                Console.WriteLine("Скидка составляет 25%: " + result1 + " UAH");
                Console.WriteLine("К оплате " + ((priceProduct * quantityGoods) - result1) + " UAH");
            }
            if (quantityGoods <= 0)
            {
                Console.WriteLine("Неверное число!");
            }
            Console.ReadKey();
        }
    }
}
