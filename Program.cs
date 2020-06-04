using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new Mario();
            Console.WriteLine("Mario: ");
            mario.Correr();
            mario.Pular();
            Console.WriteLine();
            Luigi luigi = new Luigi();
            Console.WriteLine("Luigi: ");
            luigi.Correr();
            luigi.Pular();

        }
    }
}
