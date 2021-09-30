using System;

namespace DICE
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice1 = new Dice();
            Dice dice2 = new Dice(7);

            Console.WriteLine("Dice:" + dice1.Roll());
        }
    }
    }
}
