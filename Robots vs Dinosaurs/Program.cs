using System;

namespace Robots_vs_Dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield();
            battlefield.GameStart(); 
            Console.ReadLine();

        }
    }
}
