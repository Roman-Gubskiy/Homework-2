using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово (рус.): ");
            string weather = (Console.ReadLine());
          
            switch (weather)
            {
                case "дождь":
                    {
                        Console.WriteLine("(рус.) дождь - (агнл.) rain.");
                        break;
                    }
                case "туман":
                    {
                        Console.WriteLine("(рус.) туман - (агнл.) fog.");
                        break;
                    }
                case "снег":
                    {
                        Console.WriteLine("(рус.) снег - (агнл.) snow.");
                        break;
                    }
                case "снегопад":
                    {
                        Console.WriteLine("(рус.) снегопад - (агнл.) snowfall.");
                        break;
                    }
                case "ветер":
                    {
                        Console.WriteLine("(рус.) ветер - (агнл.) wind.");
                        break;
                    }
                case "осадки":
                    {
                        Console.WriteLine("(рус.) осадки - (агнл.) precipitation.");
                        break;
                    }
                case "солнечно":
                    {
                        Console.WriteLine("(рус.) солнечно - (агнл.) sunny.");
                        break;
                    }
                case "облачно":
                    {
                        Console.WriteLine("(рус.) облачно - (агнл.) cloudy.");
                        break;
                    }
                case "град":
                    {
                        Console.WriteLine("(рус.) град - (агнл.) hail.");
                        break;
                    }
                case "шторм":
                    {
                        Console.WriteLine("(рус.) облачно - (агнл.) storm.");
                        break;
                    }
                default:
                    Console.WriteLine("Неизвестное cлово!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
