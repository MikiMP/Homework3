using System;

namespace Exercise2
{
    internal class Program
    {
        //2.	Найти все числа, большее 200 и меньше 500, которое нацело делится на 17. Реализовать через цикл While(). 
        //    На выходе мы должны получить строку, где числа разделены ‘,’

        static void Main(string[] args)
        {
            string stringResult = string.Empty;
            string stringForeachResult = string.Empty;
            int Value = 200;



            while(Value <= 500)
            {
                if (Value % 17 == 0)
                {
                    if (500 - Value >= 17)             
                    {
                        stringResult += Value + ",";
                    }
                    else
                    {
                        stringResult += Value + ".";
                    }
                    
                }
                Value++;
            }

            Console.WriteLine(stringResult);

            Console.WriteLine("Typed any key to finish application");
            Console.ReadKey();
        }
    }
}
