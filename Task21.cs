using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Дана длина 𝐿 окружности. Найти ее радиус 𝑟 и площадь 𝑆 круга, ограниченного этой окружностью, 
            учитывая, что 𝐿 = 2𝜋r, 𝑆 = 𝜋𝑟2. В качестве значения 𝜋 использовать 3.14*/
            
            double r, L, S, PI = 3.14;
            Console.Write("Введите радиус окружности: ");
            r = double.Parse(Console.ReadLine());
            L = 2 * PI * r;
            S = PI * r * r;
            Console.WriteLine($"Длина окружности равнa: {L}");
            Console.WriteLine($"Площадь круга равна: {S}");
            Console.ReadKey();
        }
    }
}
