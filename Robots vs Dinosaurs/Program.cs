using System;

namespace Robots_vs_Dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Battlefield battlefield = new Battlefield();
            battlefield.GameStart();
            
            
            Console.ReadLine();

        }
    }
}
