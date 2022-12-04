using System;
using System.Security.Cryptography;

namespace Exercise3
{
    //3*. Реализовать алгоритм сортировки пузырьком(bubble sort) // в четверг будем разбирать массивы
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[10];
            int intTemp = 0;
            Random rnd = new Random();

            Console.Write("Array before BubbleSort : ");
            for(int arrayCounter = 1; arrayCounter < arrayNumbers.Length; arrayCounter++)
            {
                arrayNumbers[arrayCounter] = rnd.Next(0, 100);
                Console.Write(arrayNumbers[arrayCounter] + " ");
            }

            Console.Write("\nArray after BubbleSort : ");
            for (int sortI = 0; sortI < arrayNumbers.Length; sortI++)
            {
                for (int sortJ = 0; sortJ < arrayNumbers.Length - 1; sortJ++)
                {
                    if (arrayNumbers[sortJ + 1] > arrayNumbers[sortJ])
                    {
                        intTemp = arrayNumbers[sortJ + 1];
                        arrayNumbers[sortJ + 1] = arrayNumbers[sortJ];
                        arrayNumbers[sortJ] = intTemp;

                    }

                    if (sortI == arrayNumbers.Length - 1)
                        Console.Write(arrayNumbers[sortJ] + " ");
                }
                
            }

            Console.WriteLine("\nTyped any key to finish application");
            Console.ReadKey();
        }
    }
}
