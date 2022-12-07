using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class RollsTheDice
    {
        public void Dice()
        {
            Random rand = new Random();
            int diceValue = (int)(rand.NextInt64(6) + 1);
            Console.WriteLine("Dice Value is " + diceValue);
        }
    }
}
