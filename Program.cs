using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray(new int[] { 8, 13, 10, 23, 24, 6, 12, 17, 15, 20 });
            TossCoin();
            TossMuiltipleCoins(2);
            Names(10);
        }

        public static void RandomArray(int[] array)
        {
            int max = array[0];
            int min = array[0];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
                sum += array[i];
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
        }

        public static void TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Console.WriteLine("↓");
            Random rnd = new Random();
            string[] side = { "Heads", "Tails" };
            int face = rnd.Next(side.Length);
            Console.WriteLine(side[face]);
        }

        public static void TossMuiltipleCoins(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                TossCoin();
            }
        }

        public static void Names(int num)
        {
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            for (int i = 0; i <= num; i++)
            {
                for (int j = 0; j < names.Count - 1; j = j + 2)
                {
                    string temp = names[j];
                    names[j] = names[j + 1];
                    names[j + 1] = temp;
                }
                for (int j = 1; j < names.Count - 1; j = j + 2)
                {
                    string temp = names[j];
                    names[j] = names[j + 1];
                    names[j + 1] = temp;
                }
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("----------");
            foreach (string longName in names)
            {
                if (longName.Length > 5)
                {
                    Console.WriteLine(longName);
                }
            }
            {

            }
        }
    }
}
