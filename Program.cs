using System;

namespace UC2_Snakes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int genRand = r.Next(1, 6);
            Console.WriteLine("Random Number = " + genRand);
        }
    }
}
