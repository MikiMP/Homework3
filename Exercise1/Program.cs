using System;

namespace Exercise1
{
    internal class Program
    {
        //1. 	Содайте Console Application(Core или .Net5) в Visual Studio.
        //    Дано: у вас есть 3 промежутка чисел: от 0 до 30, от 31 до 60 и от 61 до 100.
        //    Входной параметр: пользователь вводит число.
        //    Что мы делаем: нужно понять в какой промежуток попало число.
        //    выводим на консоль: в каком промежутке число.Если не попало, пишем “Я такого числа не знаю.”

        static void Main(string[] args)
        {
            int intNumber = 0;
            
            Console.WriteLine("Type any word from range: 0 - 100");
            bool bResult = int.TryParse(Console.ReadLine(), out intNumber);
            if (bResult)
            {
                if (intNumber >= 0 & intNumber <= 30)
                    Console.WriteLine("Number is in the range: 0-30");
                else if (intNumber >= 31 & intNumber <= 60)
                    Console.WriteLine("Number is in the range: 31-60");
                else if (intNumber >= 61 & intNumber <= 100)
                    Console.WriteLine("Number is in the range: 61-100");
                else
                    Console.WriteLine("I don't know this number");//("Я такого числа не знаю.");

            }
            else
            { 
                Console.WriteLine("Typed not number");
            }
            Console.WriteLine("Typed any key to finish application");
            Console.ReadKey();
        }
    }
}
